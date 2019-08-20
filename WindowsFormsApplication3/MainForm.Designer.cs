namespace WindowsFormsApplication3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.SendReceiveData = new System.Windows.Forms.Button();
            this.DataCnt = new System.Windows.Forms.TextBox();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.MainComPort = new System.IO.Ports.SerialPort(this.components);
            this.BtnSerialConnect = new System.Windows.Forms.Button();
            this.BtnChartShow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SelectFile = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.NoPortDataCnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ParityBitsList = new System.Windows.Forms.ComboBox();
            this.DataBitsList = new System.Windows.Forms.ComboBox();
            this.RateList = new System.Windows.Forms.ComboBox();
            this.BtnSerialDisconnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HandShakeList = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StopBitsList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NoPortGenerateData = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.NowTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPortName = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusDataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStopBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusParityBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusHandShake = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowTime = new System.Windows.Forms.Timer(this.components);
            this.SetUPMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetUPMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(73, 17);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(390, 138);
            this.chartControl1.TabIndex = 0;
            // 
            // SendReceiveData
            // 
            this.SendReceiveData.Location = new System.Drawing.Point(191, 35);
            this.SendReceiveData.Name = "SendReceiveData";
            this.SendReceiveData.Size = new System.Drawing.Size(127, 23);
            this.SendReceiveData.TabIndex = 1;
            this.SendReceiveData.Text = "TX DATA";
            this.SendReceiveData.UseVisualStyleBackColor = true;
            this.SendReceiveData.Click += new System.EventHandler(this.BtnReceiveData_Click);
            // 
            // DataCnt
            // 
            this.DataCnt.Location = new System.Drawing.Point(115, 35);
            this.DataCnt.Name = "DataCnt";
            this.DataCnt.Size = new System.Drawing.Size(67, 22);
            this.DataCnt.TabIndex = 2;
            // 
            // chartControl2
            // 
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(72, 159);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(390, 138);
            this.chartControl2.TabIndex = 3;
            // 
            // chartControl3
            // 
            this.chartControl3.Legend.Name = "Default Legend";
            this.chartControl3.Location = new System.Drawing.Point(72, 301);
            this.chartControl3.Name = "chartControl3";
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl3.Size = new System.Drawing.Size(390, 138);
            this.chartControl3.TabIndex = 4;
            // 
            // MainComPort
            // 
            this.MainComPort.PortName = "COM3";
            this.MainComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.MainComPort_DataReceived);
            // 
            // BtnSerialConnect
            // 
            this.BtnSerialConnect.Location = new System.Drawing.Point(18, 252);
            this.BtnSerialConnect.Name = "BtnSerialConnect";
            this.BtnSerialConnect.Size = new System.Drawing.Size(85, 23);
            this.BtnSerialConnect.TabIndex = 5;
            this.BtnSerialConnect.Text = "OPEN PORT";
            this.BtnSerialConnect.UseVisualStyleBackColor = true;
            this.BtnSerialConnect.Click += new System.EventHandler(this.BtnSerialConnect_Click);
            // 
            // BtnChartShow
            // 
            this.BtnChartShow.Location = new System.Drawing.Point(179, 88);
            this.BtnChartShow.Name = "BtnChartShow";
            this.BtnChartShow.Size = new System.Drawing.Size(115, 23);
            this.BtnChartShow.TabIndex = 9;
            this.BtnChartShow.Text = "Chart Show";
            this.BtnChartShow.UseVisualStyleBackColor = true;
            this.BtnChartShow.Click += new System.EventHandler(this.BtnChartShow_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 10;
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(43, 88);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(115, 23);
            this.SelectFile.TabIndex = 11;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            this.ofdFile.Filter = "텍스트 파일 (*.txt) |*.txt|모든 파일(*.*)|*.*";
            this.ofdFile.ReadOnlyChecked = true;
            // 
            // NoPortDataCnt
            // 
            this.NoPortDataCnt.Location = new System.Drawing.Point(115, 35);
            this.NoPortDataCnt.Name = "NoPortDataCnt";
            this.NoPortDataCnt.Size = new System.Drawing.Size(67, 22);
            this.NoPortDataCnt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "DATA COUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "DATA COUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "LOAD DATA";
            // 
            // PortList
            // 
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(84, 28);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(126, 22);
            this.PortList.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Port Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Baud Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data Bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "Parity Bits";
            // 
            // ParityBitsList
            // 
            this.ParityBitsList.FormattingEnabled = true;
            this.ParityBitsList.Location = new System.Drawing.Point(84, 175);
            this.ParityBitsList.Name = "ParityBitsList";
            this.ParityBitsList.Size = new System.Drawing.Size(126, 22);
            this.ParityBitsList.TabIndex = 23;
            // 
            // DataBitsList
            // 
            this.DataBitsList.FormattingEnabled = true;
            this.DataBitsList.Location = new System.Drawing.Point(84, 101);
            this.DataBitsList.Name = "DataBitsList";
            this.DataBitsList.Size = new System.Drawing.Size(126, 22);
            this.DataBitsList.TabIndex = 25;
            // 
            // RateList
            // 
            this.RateList.FormattingEnabled = true;
            this.RateList.Location = new System.Drawing.Point(84, 64);
            this.RateList.Name = "RateList";
            this.RateList.Size = new System.Drawing.Size(126, 22);
            this.RateList.TabIndex = 26;
            // 
            // BtnSerialDisconnect
            // 
            this.BtnSerialDisconnect.Location = new System.Drawing.Point(114, 252);
            this.BtnSerialDisconnect.Name = "BtnSerialDisconnect";
            this.BtnSerialDisconnect.Size = new System.Drawing.Size(87, 23);
            this.BtnSerialDisconnect.TabIndex = 27;
            this.BtnSerialDisconnect.Text = "CLOSE PORT";
            this.BtnSerialDisconnect.UseVisualStyleBackColor = true;
            this.BtnSerialDisconnect.Click += new System.EventHandler(this.BtnSerialDisconnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSerialConnect);
            this.groupBox1.Controls.Add(this.HandShakeList);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.BtnSerialDisconnect);
            this.groupBox1.Controls.Add(this.RateList);
            this.groupBox1.Controls.Add(this.PortList);
            this.groupBox1.Controls.Add(this.DataBitsList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StopBitsList);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ParityBitsList);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 300);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properity";
            // 
            // HandShakeList
            // 
            this.HandShakeList.FormattingEnabled = true;
            this.HandShakeList.Location = new System.Drawing.Point(84, 211);
            this.HandShakeList.Name = "HandShakeList";
            this.HandShakeList.Size = new System.Drawing.Size(126, 22);
            this.HandShakeList.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 14);
            this.label13.TabIndex = 28;
            this.label13.Text = "Hand Shake";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 211);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 22);
            this.comboBox1.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "Parity Bits";
            // 
            // StopBitsList
            // 
            this.StopBitsList.FormattingEnabled = true;
            this.StopBitsList.Location = new System.Drawing.Point(84, 138);
            this.StopBitsList.Name = "StopBitsList";
            this.StopBitsList.Size = new System.Drawing.Size(126, 22);
            this.StopBitsList.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Stop Bits";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.chartControl3);
            this.groupBox2.Controls.Add(this.chartControl1);
            this.groupBox2.Controls.Add(this.chartControl2);
            this.groupBox2.Location = new System.Drawing.Point(650, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 451);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gragh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 14);
            this.label9.TabIndex = 30;
            this.label9.Text = "RMS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 14);
            this.label10.TabIndex = 31;
            this.label10.Text = "FFT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 14);
            this.label11.TabIndex = 32;
            this.label11.Text = "DATA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.DataCnt);
            this.groupBox3.Controls.Add(this.SendReceiveData);
            this.groupBox3.Location = new System.Drawing.Point(278, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 81);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PORT DATA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NoPortGenerateData);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.NoPortDataCnt);
            this.groupBox4.Location = new System.Drawing.Point(278, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 81);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GENERATE DATA";
            // 
            // NoPortGenerateData
            // 
            this.NoPortGenerateData.Location = new System.Drawing.Point(191, 34);
            this.NoPortGenerateData.Name = "NoPortGenerateData";
            this.NoPortGenerateData.Size = new System.Drawing.Size(127, 23);
            this.NoPortGenerateData.TabIndex = 16;
            this.NoPortGenerateData.Text = "GENERATE DATA";
            this.NoPortGenerateData.UseVisualStyleBackColor = true;
            this.NoPortGenerateData.Click += new System.EventHandler(this.NoPortGenerateData_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.BtnChartShow);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.SelectFile);
            this.groupBox5.Location = new System.Drawing.Point(278, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 143);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "READ FILE DATA";
            // 
            // TxTimer
            // 
            this.TxTimer.Tick += new System.EventHandler(this.TxTimer_Tick);
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.Black;
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NowTimeLabel,
            this.StatusPortName,
            this.StatusBaudRate,
            this.StatusDataBits,
            this.StatusStopBits,
            this.StatusParityBits,
            this.StatusHandShake,
            this.StatusPort});
            this.StatusBar.Location = new System.Drawing.Point(0, 662);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusBar.Size = new System.Drawing.Size(1168, 22);
            this.StatusBar.TabIndex = 32;
            this.StatusBar.Text = "statusStrip1";
            // 
            // NowTimeLabel
            // 
            this.NowTimeLabel.ForeColor = System.Drawing.Color.White;
            this.NowTimeLabel.Margin = new System.Windows.Forms.Padding(0, 3, 24, 2);
            this.NowTimeLabel.Name = "NowTimeLabel";
            this.NowTimeLabel.Size = new System.Drawing.Size(86, 17);
            this.NowTimeLabel.Text = "NowTimeLabel";
            // 
            // StatusPortName
            // 
            this.StatusPortName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.StatusPortName.ForeColor = System.Drawing.Color.White;
            this.StatusPortName.Name = "StatusPortName";
            this.StatusPortName.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.StatusPortName.Size = new System.Drawing.Size(28, 17);
            // 
            // StatusBaudRate
            // 
            this.StatusBaudRate.ForeColor = System.Drawing.Color.White;
            this.StatusBaudRate.Margin = new System.Windows.Forms.Padding(24, 3, 0, 2);
            this.StatusBaudRate.Name = "StatusBaudRate";
            this.StatusBaudRate.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusDataBits
            // 
            this.StatusDataBits.ForeColor = System.Drawing.Color.White;
            this.StatusDataBits.Margin = new System.Windows.Forms.Padding(24, 3, 0, 2);
            this.StatusDataBits.Name = "StatusDataBits";
            this.StatusDataBits.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusStopBits
            // 
            this.StatusStopBits.ForeColor = System.Drawing.Color.White;
            this.StatusStopBits.Margin = new System.Windows.Forms.Padding(24, 3, 0, 2);
            this.StatusStopBits.Name = "StatusStopBits";
            this.StatusStopBits.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusParityBits
            // 
            this.StatusParityBits.ForeColor = System.Drawing.Color.White;
            this.StatusParityBits.Margin = new System.Windows.Forms.Padding(24, 3, 0, 2);
            this.StatusParityBits.Name = "StatusParityBits";
            this.StatusParityBits.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusHandShake
            // 
            this.StatusHandShake.ForeColor = System.Drawing.Color.White;
            this.StatusHandShake.Margin = new System.Windows.Forms.Padding(24, 3, 24, 2);
            this.StatusHandShake.Name = "StatusHandShake";
            this.StatusHandShake.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusPort
            // 
            this.StatusPort.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.StatusPort.ForeColor = System.Drawing.Color.White;
            this.StatusPort.LinkVisited = true;
            this.StatusPort.Name = "StatusPort";
            this.StatusPort.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.StatusPort.Size = new System.Drawing.Size(52, 17);
            // 
            // NowTime
            // 
            this.NowTime.Enabled = true;
            this.NowTime.Interval = 1000;
            this.NowTime.Tick += new System.EventHandler(this.NowTime_Tick);
            // 
            // SetUPMenu
            // 
            this.SetUPMenu.Name = "SetUPMenu";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // MainForm
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1168, 684);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "FFT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetUPMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Button SendReceiveData;
        private System.Windows.Forms.TextBox DataCnt;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
        private System.IO.Ports.SerialPort MainComPort;
        private System.Windows.Forms.Button BtnSerialConnect;
        private System.Windows.Forms.Button BtnChartShow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.TextBox NoPortDataCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ParityBitsList;
        private System.Windows.Forms.ComboBox DataBitsList;
        private System.Windows.Forms.ComboBox RateList;
        private System.Windows.Forms.Button BtnSerialDisconnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox StopBitsList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NoPortGenerateData;
        private System.Windows.Forms.ComboBox HandShakeList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer TxTimer;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel NowTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusPortName;
        private System.Windows.Forms.Timer NowTime;
        private System.Windows.Forms.ToolStripStatusLabel StatusBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel StatusDataBits;
        private System.Windows.Forms.ToolStripStatusLabel StatusStopBits;
        private System.Windows.Forms.ToolStripStatusLabel StatusParityBits;
        private System.Windows.Forms.ToolStripStatusLabel StatusHandShake;
        private System.Windows.Forms.ToolStripStatusLabel StatusPort;
        private DevExpress.XtraBars.PopupMenu SetUPMenu;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}

