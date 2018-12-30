namespace CSharpTest
{

    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelCom = new System.Windows.Forms.Label();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.labelDatabits = new System.Windows.Forms.Label();
            this.comboBoxDatabits = new System.Windows.Forms.ComboBox();
            this.labelStopbits = new System.Windows.Forms.Label();
            this.comboBoxStopbits = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxHexRecive = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.textBoxRecive = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSocketClean = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonSocketOpen = new System.Windows.Forms.Button();
            this.checkBoxSocketHexSend = new System.Windows.Forms.CheckBox();
            this.checkBoxSocketHexRecive = new System.Windows.Forms.CheckBox();
            this.buttonSocketSend = new System.Windows.Forms.Button();
            this.textBoxSocketSend = new System.Windows.Forms.TextBox();
            this.textBoxSocketRecive = new System.Windows.Forms.TextBox();
            this.comboBoxIPAddress = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(33, 236);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "打开";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(31, 59);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(41, 12);
            this.labelCom.TabIndex = 1;
            this.labelCom.Text = "串口号";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(31, 84);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(41, 12);
            this.labelBaudrate.TabIndex = 3;
            this.labelBaudrate.Text = "波特率";
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(78, 81);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBaudrate.TabIndex = 4;
            // 
            // labelDatabits
            // 
            this.labelDatabits.AutoSize = true;
            this.labelDatabits.Location = new System.Drawing.Point(31, 110);
            this.labelDatabits.Name = "labelDatabits";
            this.labelDatabits.Size = new System.Drawing.Size(41, 12);
            this.labelDatabits.TabIndex = 5;
            this.labelDatabits.Text = "数据位";
            // 
            // comboBoxDatabits
            // 
            this.comboBoxDatabits.FormattingEnabled = true;
            this.comboBoxDatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDatabits.Location = new System.Drawing.Point(78, 107);
            this.comboBoxDatabits.Name = "comboBoxDatabits";
            this.comboBoxDatabits.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDatabits.TabIndex = 6;
            // 
            // labelStopbits
            // 
            this.labelStopbits.AutoSize = true;
            this.labelStopbits.Location = new System.Drawing.Point(31, 136);
            this.labelStopbits.Name = "labelStopbits";
            this.labelStopbits.Size = new System.Drawing.Size(41, 12);
            this.labelStopbits.TabIndex = 7;
            this.labelStopbits.Text = "停止位";
            // 
            // comboBoxStopbits
            // 
            this.comboBoxStopbits.FormattingEnabled = true;
            this.comboBoxStopbits.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "1.5"});
            this.comboBoxStopbits.Location = new System.Drawing.Point(78, 133);
            this.comboBoxStopbits.Name = "comboBoxStopbits";
            this.comboBoxStopbits.Size = new System.Drawing.Size(121, 20);
            this.comboBoxStopbits.TabIndex = 8;
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(31, 162);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(41, 12);
            this.labelParity.TabIndex = 9;
            this.labelParity.Text = "校验位";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(78, 159);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 20);
            this.comboBoxParity.TabIndex = 10;
            // 
            // comboBoxCom
            // 
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Location = new System.Drawing.Point(78, 56);
            this.comboBoxCom.Name = "comboBoxCom";
            this.comboBoxCom.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCom.TabIndex = 11;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(124, 236);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 393);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxCheck);
            this.tabPage1.Controls.Add(this.checkBoxHexSend);
            this.tabPage1.Controls.Add(this.checkBoxHexRecive);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.buttonSend);
            this.tabPage1.Controls.Add(this.textBoxSend);
            this.tabPage1.Controls.Add(this.textBoxRecive);
            this.tabPage1.Controls.Add(this.labelStopbits);
            this.tabPage1.Controls.Add(this.buttonRefresh);
            this.tabPage1.Controls.Add(this.buttonConnect);
            this.tabPage1.Controls.Add(this.comboBoxCom);
            this.tabPage1.Controls.Add(this.labelCom);
            this.tabPage1.Controls.Add(this.comboBoxParity);
            this.tabPage1.Controls.Add(this.labelBaudrate);
            this.tabPage1.Controls.Add(this.labelParity);
            this.tabPage1.Controls.Add(this.comboBoxBaudrate);
            this.tabPage1.Controls.Add(this.comboBoxStopbits);
            this.tabPage1.Controls.Add(this.labelDatabits);
            this.tabPage1.Controls.Add(this.comboBoxDatabits);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "串口";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxCheck
            // 
            this.checkBoxCheck.AutoSize = true;
            this.checkBoxCheck.Location = new System.Drawing.Point(134, 214);
            this.checkBoxCheck.Name = "checkBoxCheck";
            this.checkBoxCheck.Size = new System.Drawing.Size(48, 16);
            this.checkBoxCheck.TabIndex = 19;
            this.checkBoxCheck.Text = "校验";
            this.checkBoxCheck.UseVisualStyleBackColor = true;
            this.checkBoxCheck.CheckedChanged += new System.EventHandler(this.checkBoxCheck_CheckedChanged);
            // 
            // checkBoxHexSend
            // 
            this.checkBoxHexSend.AutoSize = true;
            this.checkBoxHexSend.Location = new System.Drawing.Point(33, 211);
            this.checkBoxHexSend.Name = "checkBoxHexSend";
            this.checkBoxHexSend.Size = new System.Drawing.Size(66, 16);
            this.checkBoxHexSend.TabIndex = 18;
            this.checkBoxHexSend.Text = "HEX发送";
            this.checkBoxHexSend.UseVisualStyleBackColor = true;
            this.checkBoxHexSend.CheckedChanged += new System.EventHandler(this.checkBoxHexSend_CheckedChanged);
            // 
            // checkBoxHexRecive
            // 
            this.checkBoxHexRecive.AutoSize = true;
            this.checkBoxHexRecive.Location = new System.Drawing.Point(33, 189);
            this.checkBoxHexRecive.Name = "checkBoxHexRecive";
            this.checkBoxHexRecive.Size = new System.Drawing.Size(66, 16);
            this.checkBoxHexRecive.TabIndex = 17;
            this.checkBoxHexRecive.Text = "HEX接收";
            this.checkBoxHexRecive.UseVisualStyleBackColor = true;
            this.checkBoxHexRecive.CheckedChanged += new System.EventHandler(this.checkBoxHexRecive_CheckedChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(124, 185);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(512, 236);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 15;
            this.buttonSend.Text = "发送";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(205, 236);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(301, 21);
            this.textBoxSend.TabIndex = 14;
            // 
            // textBoxRecive
            // 
            this.textBoxRecive.Location = new System.Drawing.Point(205, 56);
            this.textBoxRecive.Multiline = true;
            this.textBoxRecive.Name = "textBoxRecive";
            this.textBoxRecive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRecive.Size = new System.Drawing.Size(382, 174);
            this.textBoxRecive.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Controls.Add(this.comboBoxIPAddress);
            this.tabPage2.Controls.Add(this.buttonSocketSend);
            this.tabPage2.Controls.Add(this.textBoxSocketSend);
            this.tabPage2.Controls.Add(this.textBoxSocketRecive);
            this.tabPage2.Controls.Add(this.buttonSocketClean);
            this.tabPage2.Controls.Add(this.textBoxPort);
            this.tabPage2.Controls.Add(this.labelPort);
            this.tabPage2.Controls.Add(this.labelIPAddress);
            this.tabPage2.Controls.Add(this.labelType);
            this.tabPage2.Controls.Add(this.comboBoxType);
            this.tabPage2.Controls.Add(this.buttonSocketOpen);
            this.tabPage2.Controls.Add(this.checkBoxSocketHexSend);
            this.tabPage2.Controls.Add(this.checkBoxSocketHexRecive);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(653, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "网络";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSocketClean
            // 
            this.buttonSocketClean.Location = new System.Drawing.Point(53, 176);
            this.buttonSocketClean.Name = "buttonSocketClean";
            this.buttonSocketClean.Size = new System.Drawing.Size(138, 23);
            this.buttonSocketClean.TabIndex = 28;
            this.buttonSocketClean.Text = "清空";
            this.buttonSocketClean.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(53, 127);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(138, 21);
            this.textBoxPort.TabIndex = 27;
            this.textBoxPort.Text = "5000";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(51, 112);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(41, 12);
            this.labelPort.TabIndex = 26;
            this.labelPort.Text = "端口号";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(51, 73);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(41, 12);
            this.labelIPAddress.TabIndex = 25;
            this.labelIPAddress.Text = "IP地址";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(51, 35);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(53, 12);
            this.labelType.TabIndex = 24;
            this.labelType.Text = "协议类型";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "UDP",
            "TCP Server",
            "TCP Client"});
            this.comboBoxType.Location = new System.Drawing.Point(53, 50);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(138, 20);
            this.comboBoxType.TabIndex = 23;
            // 
            // buttonSocketOpen
            // 
            this.buttonSocketOpen.Location = new System.Drawing.Point(53, 205);
            this.buttonSocketOpen.Name = "buttonSocketOpen";
            this.buttonSocketOpen.Size = new System.Drawing.Size(138, 23);
            this.buttonSocketOpen.TabIndex = 21;
            this.buttonSocketOpen.Text = "连接";
            this.buttonSocketOpen.UseVisualStyleBackColor = true;
            this.buttonSocketOpen.Click += new System.EventHandler(this.buttonSocketOpen_Click);
            // 
            // checkBoxSocketHexSend
            // 
            this.checkBoxSocketHexSend.AutoSize = true;
            this.checkBoxSocketHexSend.Location = new System.Drawing.Point(125, 154);
            this.checkBoxSocketHexSend.Name = "checkBoxSocketHexSend";
            this.checkBoxSocketHexSend.Size = new System.Drawing.Size(66, 16);
            this.checkBoxSocketHexSend.TabIndex = 20;
            this.checkBoxSocketHexSend.Text = "HEX发送";
            this.checkBoxSocketHexSend.UseVisualStyleBackColor = true;
            // 
            // checkBoxSocketHexRecive
            // 
            this.checkBoxSocketHexRecive.AutoSize = true;
            this.checkBoxSocketHexRecive.Location = new System.Drawing.Point(53, 154);
            this.checkBoxSocketHexRecive.Name = "checkBoxSocketHexRecive";
            this.checkBoxSocketHexRecive.Size = new System.Drawing.Size(66, 16);
            this.checkBoxSocketHexRecive.TabIndex = 19;
            this.checkBoxSocketHexRecive.Text = "HEX接收";
            this.checkBoxSocketHexRecive.UseVisualStyleBackColor = true;
            // 
            // buttonSocketSend
            // 
            this.buttonSocketSend.Location = new System.Drawing.Point(504, 207);
            this.buttonSocketSend.Name = "buttonSocketSend";
            this.buttonSocketSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSocketSend.TabIndex = 31;
            this.buttonSocketSend.Text = "发送";
            this.buttonSocketSend.UseVisualStyleBackColor = true;
            // 
            // textBoxSocketSend
            // 
            this.textBoxSocketSend.Location = new System.Drawing.Point(197, 207);
            this.textBoxSocketSend.Name = "textBoxSocketSend";
            this.textBoxSocketSend.Size = new System.Drawing.Size(301, 21);
            this.textBoxSocketSend.TabIndex = 30;
            // 
            // textBoxSocketRecive
            // 
            this.textBoxSocketRecive.Location = new System.Drawing.Point(197, 35);
            this.textBoxSocketRecive.Multiline = true;
            this.textBoxSocketRecive.Name = "textBoxSocketRecive";
            this.textBoxSocketRecive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSocketRecive.Size = new System.Drawing.Size(382, 164);
            this.textBoxSocketRecive.TabIndex = 29;
            // 
            // comboBoxIPAddress
            // 
            this.comboBoxIPAddress.FormattingEnabled = true;
            this.comboBoxIPAddress.Location = new System.Drawing.Point(53, 88);
            this.comboBoxIPAddress.Name = "comboBoxIPAddress";
            this.comboBoxIPAddress.Size = new System.Drawing.Size(138, 20);
            this.comboBoxIPAddress.TabIndex = 32;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 417);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Label labelDatabits;
        private System.Windows.Forms.ComboBox comboBoxDatabits;
        private System.Windows.Forms.Label labelStopbits;
        private System.Windows.Forms.ComboBox comboBoxStopbits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.TextBox textBoxRecive;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxCheck;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.CheckBox checkBoxHexRecive;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox checkBoxSocketHexSend;
        private System.Windows.Forms.CheckBox checkBoxSocketHexRecive;
        private System.Windows.Forms.Button buttonSocketOpen;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonSocketClean;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonSocketSend;
        private System.Windows.Forms.TextBox textBoxSocketSend;
        private System.Windows.Forms.TextBox textBoxSocketRecive;
        private System.Windows.Forms.ComboBox comboBoxIPAddress;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;


    }
}


