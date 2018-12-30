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
using System.Net;
using System.Net.Sockets;

namespace CSharpTest
{
    public partial class Form1 : Form
    {

        private bool _HexSend = false;
        private bool _HexRecive = false;
        private bool _ReciveCheck = false;
        Socket socket;

        //变量定义
        delegate void UpdateTextEventHandler(string text);       //委托
        UpdateTextEventHandler updateText;                       //事件

        /// <summary> 初始化函数
        /// </summary>
        public Form1()
        {
            //串口初始化
            InitializeComponent();
            comboBoxDatabits.SelectedIndex = 3;
            comboBoxBaudrate.SelectedIndex = 0;
            comboBoxParity.SelectedIndex = 0;
            comboBoxStopbits.SelectedIndex = 1;

            string[] ports = SerialPort.GetPortNames();
            comboBoxCom.Items.Clear();
            comboBoxCom.Items.AddRange(ports);
            comboBoxCom.SelectedIndex = 0;

            //网络初始化
            comboBoxType.SelectedIndex = 0;

            //本地IP地址获取
            comboBoxIPAddress.Items.Add("127.0.0.1");
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        comboBoxIPAddress.Items.Add(IpEntry.AddressList[i].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comboBoxIPAddress.SelectedIndex = 0;

            updateText += new UpdateTextEventHandler(UpdateTextBox);                    //委托方法
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataRecive);  //处理串口对象的数据接受事件的方法
        }

        /// <summary> 串口连接按钮，点击后自动填写参数，打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary> 串口信息刷新按钮，点击后刷新串口信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxCom.Items.Clear();
            comboBoxCom.Items.AddRange(ports);
            comboBoxCom.SelectedIndex = 0;
        }

        /// <summary> 委托方法更新串口接收textBox区域内容
        /// </summary>
        /// <param name="text"></param>
        private void UpdateTextBox(string text)
        {
            string data = "收->";
            data += text + "\n";
            textBoxRecive.AppendText(data);
        }

        /// <summary> 串口接收数据处理函数，接收数据处理后委托UI更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataRecive(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(50);

            //提取串口信息
            byte[] buffer = Encoding.ASCII.GetBytes(serialPort.ReadExisting());
            string checkString = Encoding.ASCII.GetString(buffer);
            string newString = "";

            //是否需要校验
            if(_ReciveCheck)
                if (!stringCheck(checkString))
                    return;

            //HEX显示或者字符显示
            if(_HexRecive)
            {
                foreach(byte b in buffer)
                {
                    newString += b.ToString("X").PadLeft(2, '0') +" ";
                }
            }
            else
            {
                newString = Encoding.ASCII.GetString(buffer);
            }
            

            this.Invoke(updateText, new string[] { newString });    //控件基础句柄线程上，执行委托
        }

        /// <summary> 串口数据发送按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            //判断串口是否打开
            if (serialPort.IsOpen)
            {
                string data;

                //根据是否HEX发送处理
                if(_HexSend)
                {
                    try
                    {
                        string ori = textBoxSend.Text;
                        data = ori.Replace(" ", "");
                        if ((data.Length % 2) != 0)
                            data += " ";
                        byte[] returnBytes = new byte[data.Length / 2];
                        for (int i = 0; i < returnBytes.Length; i++)
                            returnBytes[i] = Convert.ToByte(data.Substring(i * 2, 2), 16);
                        data = Encoding.ASCII.GetString(returnBytes);
                    }
                    catch (Exception ex)
                    {
                        //字符分割时异常处理
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    data = textBoxSend.Text;
                }

                //是否需要校验位
                if(_ReciveCheck)
                {
                    data = generateCheckedString(data);
                }

                //UI记录
                string boxData = "发->" + data + "\n";
                textBoxRecive.AppendText(boxData);
                //串口发送
                serialPort.Write(data);
            }
            else
            {
                //串口没有打开
                MessageBox.Show("请先打开串口！");
            }
        }

        /// <summary> 清空按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRecive.Clear();
        }

        /// <summary> 校验勾选框打勾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxCheck_CheckedChanged(object sender, EventArgs e)
        {
            _ReciveCheck = checkBoxCheck.Checked;
        }

        /// <summary> HEX接收勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxHexRecive_CheckedChanged(object sender, EventArgs e)
        {
            _HexRecive = checkBoxHexRecive.Checked;
        }

        /// <summary> HEX发送勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxHexSend_CheckedChanged(object sender, EventArgs e)
        {
            _HexSend = checkBoxHexSend.Checked;
        }

        /// <summary> 字符串校验
        /// </summary>
        /// <param name="s">待校验的字符串</param>
        /// <returns>校验结果</returns>
        private bool stringCheck(string s)
        {
            return true;
        }

        /// <summary>生成字符串校验后序列
        /// </summary>
        /// <param name="s">待校验字符串</param>
        /// <returns>带校验的字符串</returns>
        private string generateCheckedString(string s)
        {
            return s;
        }

        /// <summary> Socket 连接打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSocketOpen_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            int port;

            //获取IP 和端口，并处理异常
            try
            {
                ip = IPAddress.Parse(comboBoxIPAddress.Text);
                port = Convert.ToInt32(textBoxPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IPEndPoint ipe = new IPEndPoint(ip, port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (comboBoxType.SelectedIndex == 1)
            {
                //TCP Server
                socket.Bind(ipe);                               //绑定
                socket.Listen(0);                               //连接数无限制
                socket.BeginAccept(AcceptCallBack, socket);     //调用异步连接

                toolStripStatusLabel.Text = "开始监听";
            }
            else if(comboBoxType.SelectedIndex == 2)
            {
                //TCP Client
                socket.Connect(ipe);
            }
        }

        /// <summary> 服务器端异步连接
        /// </summary>
        /// <param name="result"></param>
        static void AcceptCallBack(IAsyncResult result)
        {
            Socket serverSocket = result.AsyncState as Socket;
        }
    }
}
