using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace CSharpTest
{
    public partial class Form1 : Form
    {

        //变量定义
        delegate void UpdateTextEventHandler(string text);      //委托
        UpdateTextEventHandler updateText;                       //事件

        public Form1()
        {
            InitializeComponent();
            comboBoxDatabits.SelectedIndex = 3;
            comboBoxBaudrate.SelectedIndex = 0;
            comboBoxParity.SelectedIndex = 0;
            comboBoxStopbits.SelectedIndex = 1;

            string[] ports = SerialPort.GetPortNames();
            comboBoxCom.Items.Clear();
            comboBoxCom.Items.AddRange(ports);
            comboBoxCom.SelectedIndex = 0;

            updateText += new UpdateTextEventHandler(UpdateTextBox);                    //委托方法
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataRecive);  //处理串口对象的数据接受事件的方法
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                //串口已经打开，尝试关闭
                try
                {
                    serialPort.Close();
                    buttonConnect.Text = "打开";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //串口没有打开，尝试打开
                serialPort.PortName = comboBoxCom.SelectedItem.ToString();
                serialPort.BaudRate = Convert.ToInt32(comboBoxBaudrate.SelectedItem.ToString());
                serialPort.Parity = (Parity)Convert.ToInt32(comboBoxParity.SelectedIndex.ToString());
                serialPort.StopBits = (StopBits)Convert.ToInt32(comboBoxStopbits.SelectedIndex.ToString());
                serialPort.DataBits = Convert.ToInt32(comboBoxDatabits.SelectedItem.ToString());
                try
                {
                    serialPort.Open();
                    buttonConnect.Text = "关闭";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            comboBoxBaudrate.Enabled = !serialPort.IsOpen;
            comboBoxCom.Enabled = !serialPort.IsOpen; ;
            comboBoxDatabits.Enabled = !serialPort.IsOpen;
            comboBoxParity.Enabled = !serialPort.IsOpen;
            comboBoxStopbits.Enabled = !serialPort.IsOpen;

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxCom.Items.Clear();
            comboBoxCom.Items.AddRange(ports);
            comboBoxCom.SelectedIndex = 0;
        }

        private void UpdateTextBox(string text)
        {
            string data = "收->";
            data += text;
            textBoxRecive.AppendText(data);
        }


        private void dataRecive(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            byte[] buffer = Encoding.UTF8.GetBytes(serialPort.ReadExisting());
            string newString = Encoding.UTF8.GetString(buffer);

            this.Invoke(updateText, new string[] { newString });    //控件基础句柄线程上，执行委托
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                string data = textBoxSend.Text;
                string boxData = "发->" + data + "\n";
                textBoxRecive.AppendText(boxData);
                serialPort.Write(data);
            }
            else
            {
                //串口没有打开
                MessageBox.Show("请先打开串口！");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRecive.Clear();
        }

    }
}
