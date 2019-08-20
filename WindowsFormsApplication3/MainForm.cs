using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using System.Collections;
using FFTLibrary;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        byte STX = 0x02;
        byte ETX = 0x03;
        Random r = new Random();
        int NRXCOUNT = 0;
        byte[] RxBuffer = new byte[65536];
        Stopwatch sw = new Stopwatch();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetProperity();
            BtnSerialConnect.Enabled = true;
            BtnSerialDisconnect.Enabled = false;
            StatusPort.Text = "OPENED";
        }

        private void SetProperity()
        {
            string[] s1 = SerialPort.GetPortNames();
            foreach (string portname in s1)
            {
                PortList.Items.Add(portname);
            }

            string[] s2 = { "9600", "19200", "38400", "57600", "115200" };
            RateList.Items.AddRange(s2);
            RateList.SelectedIndex = 4;

            string[] s3 = { "6", "7", "8" };
            DataBitsList.Items.AddRange(s3);
            DataBitsList.SelectedIndex = 2;

            StopBitsList.DataSource = Enum.GetValues(typeof(StopBits));
            StopBitsList.SelectedIndex = 1;

            ParityBitsList.DataSource = Enum.GetValues(typeof(Parity));
            ParityBitsList.SelectedIndex = 0;

            HandShakeList.DataSource = Enum.GetValues(typeof(Handshake));
            HandShakeList.SelectedIndex = 0;
        }

        private void DisplayChart(int InputLength, double[] Data, double[] FFT, double[] RMS)
        {
            Series[] series = new Series[3];
            series[0] = new Series("data", ViewType.Line);
            series[1] = new Series("FFT", ViewType.Line);
            series[2] = new Series("RMS", ViewType.Line);
            try
            {
                for (int i = 0; i < InputLength; i++)
                {
                    series[0].Points.Add(new SeriesPoint((double)i * 100 / InputLength, Data[i]));

                    if (i < InputLength / 2)
                    {
                        series[1].Points.Add(new SeriesPoint((double)i * 100 / InputLength, FFT[i]));
                        series[2].Points.Add(new SeriesPoint((double)i * 100 / InputLength, RMS[i]));
                    }
                }
                chartControl1.Series.Add(series[0]);
                chartControl2.Series.Add(series[1]);
                chartControl3.Series.Add(series[2]);
            }
            catch (Exception) { }
        }

        private void SelectDisplayChart_Data(double[] Data)
        {
            Series series = new Series("data", ViewType.Line);
            for (int i = 0; i < Data.Length; i++)
                series.Points.Add(new SeriesPoint((double)i * 100 / Data.Length, Data[i]));
            chartControl1.Series.Add(series);
        }

        private void SelectDisplayChart_FFT(double[] FFT)
        {
            Series series = new Series("data", ViewType.Line);
            for (int i = 0; i < FFT.Length; i++)
                series.Points.Add(new SeriesPoint((double)i * 50 / FFT.Length, FFT[i]));
            chartControl2.Series.Add(series);
        }

        private void SelectDisplayChart_RMS(double[] RMS)
        {
            Series series = new Series("data", ViewType.Line);
            for (int i = 0; i < RMS.Length; i++)
                series.Points.Add(new SeriesPoint((double)i * 50 / RMS.Length, RMS[i]));
            chartControl3.Series.Add(series);
        }

        private void BtnSerialConnect_Click(object sender, EventArgs e)
        {
            SerialPortOpen();

            StatusPortName.Text = "Port Name : " + MainComPort.PortName;
            StatusBaudRate.Text = "Baud Rate : " + MainComPort.BaudRate;
            StatusDataBits.Text = "Data Bits : " + MainComPort.DataBits;
            StatusStopBits.Text = "Stop Bits : " + MainComPort.StopBits;
            StatusParityBits.Text = "Parity Bits : " + MainComPort.Parity;
            StatusHandShake.Text = "Hand Shake : " + MainComPort.Handshake;
     
            StatusPort.Text = "OPENED";

        }

        private void SerialPortOpen()
        {
            if (PortList.SelectedIndex < 0)
                return;

            try
            {
                if (!MainComPort.IsOpen)
                {
                    MainComPort.PortName = PortList.SelectedItem.ToString();
                    MainComPort.BaudRate = Convert.ToInt32(RateList.SelectedItem);
                    MainComPort.DataBits = Convert.ToInt32(DataBitsList.SelectedItem);
                    MainComPort.StopBits = (StopBits)StopBitsList.SelectedItem;
                    MainComPort.Parity = (Parity)ParityBitsList.SelectedItem;
                    MainComPort.Handshake = (Handshake)HandShakeList.SelectedItem;
                    MainComPort.DataReceived += new SerialDataReceivedEventHandler(MainComPort_DataReceived);
                    MainComPort.Open();

                    BtnSerialConnect.Enabled = false;
                    BtnSerialDisconnect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("THIS PORT IS ALREADY OPENED");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("PORT OPEN ERROR");
                throw;
            }

        }
        

        private void BtnReceiveData_Click(object sender, EventArgs e)
        {
            ChartClear();
            //
            try
            {
                //
                if (DataCnt.Text.Length <= 0)
                    return;

                int InputLength = Convert.ToInt32(DataCnt.Text);
                double[] Data;

                Data = new double[InputLength];

                Data = GenData(InputLength);
                SendData(Data, InputLength);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SendData(double[] Data, int InputLength)
        {
            byte[] TxBuffer = new byte[(InputLength + 1) * 8];
            byte[] TempData = new byte[8];
            byte[] Length = new byte[4];
            byte[] Temp = new byte[2];
            byte[] CheckSum = new byte[2];
            int nTxCount = 5;
            int nTempCount = 0;
            Int16 intCheckSum = 0;

            Length = IntToByte(InputLength * 8 + 2);
            TxBuffer[0] = STX;
            TxBuffer[TxBuffer.Length - 1] = ETX;
            for (int i = 0; i < 4; i++)
                TxBuffer[i + 1] = Length[i];

            try
            {
                for (int i = 0; i < InputLength; i++)
                {
                    TempData = DoubleToByte(Data[i]);

                    for (int j = 0; j < 8; j++) {
                        TxBuffer[nTxCount + j] = TempData[j];
                    }

                    nTxCount += 8;
                }

                // Checksum
                intCheckSum = 0x00;
                for (int i = 5; i < TxBuffer.Length - 3; i++)
                {
                    Temp[nTempCount] = TxBuffer[i];
                    nTempCount++;
                    if (nTempCount == 2)
                    {
                        intCheckSum += BitConverter.ToInt16(Temp, 0);
                        nTempCount = 0;
                    }
                }

                CheckSum = BitConverter.GetBytes(intCheckSum);
                TxBuffer[TxBuffer.Length - 3] = CheckSum[0];
                TxBuffer[TxBuffer.Length - 2] = CheckSum[1];
                MainComPort.Write(TxBuffer, 0, TxBuffer.Length);
            }
            catch (Exception) { }
        }

        private bool ParsingData(int TxLength, int OutputLength)
        { 
            bool bRtn = false;
            byte[] Temp = new byte[8];
            int nTempCount =0;
            int nDataCount =0;
            byte[] CheckSum = new byte[2];
            double[] ReceiveData = new double[OutputLength];

            for (int i = 5; i < TxLength - 3; i++)
            {
                Temp[nTempCount] = RxBuffer[i];
                nTempCount++;
                if (nTempCount == 8)
                {
                    ReceiveData[nDataCount] = ByteToDouble(Temp);
                    nDataCount++;
                    nTempCount = 0;
                }
            }

            for (int i = (TxLength/8-1); i < OutputLength; i++)
                ReceiveData[i] = 0.0;

            CheckSum = CalCheckSum(TxLength);

            if (CheckSum[0] == RxBuffer[TxLength - 3] && CheckSum[1] == RxBuffer[TxLength - 2])
            {
                bRtn = true;

                if (bRtn == true)
                {
                    TransData(ReceiveData, TxLength/8-1);
                    NRXCOUNT = 0;
                }
            }
            else
            {
                MessageBox.Show("Checksum Error");
            }

            return bRtn;
        }

        private byte[] CalCheckSum(int TxLength)
        {
            byte[] Temp = new byte[2];
            Int16 intCheckSum = 0;
            for (int i = 5; i < TxLength - 3; )
            {
                for (int j = 0; j < 2; j++)
                {
                    Temp[j] = RxBuffer[i];
                    i++;
                }
                intCheckSum += BitConverter.ToInt16(Temp, 0);
            }
            Temp = BitConverter.GetBytes(intCheckSum);
            return Temp;
        }

        private void TransData(double[] ReceiveData, int DataLength)
        {
            double[] ReceiveFFT = new double[ReceiveData.Length];
            double[] ReceiveRMS = new double[ReceiveData.Length];

            ReceiveFFT = Complex.MakeFFT(ReceiveData.Length, ReceiveData);
            ReceiveRMS = Complex.MakeRMS(ReceiveData.Length, ReceiveData);

            MemoWrite(ReceiveData, ReceiveFFT, ReceiveRMS);

            DisplayChart(DataLength, ReceiveData, ReceiveFFT, ReceiveRMS);
            sw.Stop();
            MessageBox.Show(sw.ElapsedMilliseconds.ToString() + "ms");
            sw.Reset();
        }

        private void MainComPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            sw.Start();
            byte[] Length = new byte[4];
            int DataLength = 0;
            int OutputLength = 0;
            
            int ReadByteCount = MainComPort.BytesToRead;
            byte TempBuff = 0x00;

            if (MainComPort.BytesToRead > 0)
            {
                for (int j = 0; j < ReadByteCount; j++) 
                {
                    TempBuff = (byte)MainComPort.ReadByte();
                    RxBuffer[NRXCOUNT] = TempBuff;

                    if (RxBuffer[0] == STX)
                    {
                        NRXCOUNT++;
                        if (NRXCOUNT >= 5)
                        {
                            if (DataLength == 0)
                            {
                                for (int i = 0; i < 4; i++)
                                    Length[i] = RxBuffer[i + 1];
                                DataLength = ByteToInt(Length);
                                OutputLength = Complex.TransSize(DataLength / 8);
                            }

                            if (NRXCOUNT == DataLength + 6)
                            {
                                if (RxBuffer[NRXCOUNT - 1] == ETX)
                                {
                                    ParsingData(DataLength + 6, OutputLength);
                                    NRXCOUNT = 0;
                                }
                                else
                                {
                                    NRXCOUNT = 0;
                                }
                            }
                        }
                    }
                    else
                        NRXCOUNT = 0x00;
                }
            }
        }

        private void MemoWrite(double[] Data, double[] FFT, double[] RMS)
        {
            string SavePathDATA = @"C:\Temp\" + DateTime.Now.ToString("yyyy-MM-dd_hhmmss") + "_DATA" +  ".txt";
            string SavePathFFT = @"C:\Temp\" + DateTime.Now.ToString("yyyy-MM-dd_hhmmss") + "_FFT" + ".txt";
            string SavePathRMS = @"C:\Temp\" + DateTime.Now.ToString("yyyy-MM-dd_hhmmss") + "_RMS" + ".txt";

            for (int i = 0; i < Data.Length; i++) { 
                File.AppendAllText(SavePathDATA, Data[i].ToString() + "\n", Encoding.Default);
            }
            for (int i = 0; i < FFT.Length / 2 ; i++)
            {
                File.AppendAllText(SavePathFFT, FFT[i].ToString() + "\n", Encoding.Default);
            }
            for (int i = 0; i < RMS.Length; i++)
            {
                File.AppendAllText(SavePathRMS, RMS[i].ToString() + "\n", Encoding.Default);
            }
        }

        private void BtnChartShow_Click(object sender, EventArgs e)
        {
            ChartClear();
            string s1 = "FFT";
            string s2 = "RMS";
            string Path = textBox1.Text;
            string[] strValue = File.ReadAllLines(Path);
            double[] Value = new double[strValue.Length];

            for (int i = 0; i < strValue.Length; i++)
            {
                Value[i] = Convert.ToDouble(strValue[i]);
            }

            if (Path.Contains(s1) == true)
                SelectDisplayChart_FFT(Value);
            else if (Path.Contains(s2) == true)
                SelectDisplayChart_RMS(Value);
            else
                SelectDisplayChart_Data(Value);
        }

        private void NoPortGenerateData_Click(object sender, EventArgs e)
        {
            ChartClear();
            int InputLength = Convert.ToInt32(NoPortDataCnt.Text);
            int OutputLength = Complex.TransSize(InputLength);
            double[] Data = NoPortGenData(InputLength, OutputLength);

            TransData(Data, InputLength);
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            if (this.ofdFile.ShowDialog() == DialogResult.OK)
                this.textBox1.Text = this.ofdFile.FileName;
        }

        private static double ByteToDouble(byte[] Byte)
        {
            double Double = BitConverter.ToDouble(Byte, 0);
            return Double;
        }
        
        private static byte[] DoubleToByte(double Double)
        {
            byte[] Byte;
            Byte = BitConverter.GetBytes(Double);
            return Byte;
        }

        private static byte[] IntToByte(int Int)
        {
            byte[] Byte;
            Byte = BitConverter.GetBytes(Int);
            return Byte;
        }

        private static int ByteToInt(byte[] Byte)
        {
            int Int = BitConverter.ToInt32(Byte, 0);
            return Int;
        }

        // 데이터 생성
        private double[] GenData(int InputLength)
        {
            if (InputLength == 0) return null;

            int i = 0;
            double[] Data;

            try
            {
                Data = new double[InputLength];
                /*
                if (OutputLength != InputLength)
                {
                    for (i = InputLength; i < OutputLength; i++)
                        Data[i] = 0.0;
                }*/

                for (i = 0; i < InputLength; i++)
                {
                    Data[i] = Math.Sin(2 * Math.PI * 10 * ((double)i / 100)) + Math.Sin(2 * Math.PI * 20 * ((double)i / 100)) + Math.Cos(2 * Math.PI * 15 * ((double)i / 100));
                    //Data[i] = r.Next(-100, 100);
                }
            }
            catch
            {
                throw;
            }

            return Data;
        }

        // 데이터 생성
        private double[] NoPortGenData(int InputLength, int OutputLength)
        {
            if (InputLength == 0) return null;

            int i = 0;
            double[] Data;

            try
            {
                Data = new double[OutputLength];
                
                if (OutputLength != InputLength)
                {
                    for (i = InputLength; i < OutputLength; i++)
                        Data[i] = 0.0;
                }

                for (i = 0; i < InputLength; i++)
                {
                    Data[i] = Math.Sin(2 * Math.PI * 10 * ((double)i / 100)) + Math.Sin(2 * Math.PI * 20 * ((double)i / 100)) + Math.Cos(2 * Math.PI * 15 * ((double)i / 100));
                    //Data[i] = r.Next(-100, 100);
                }
            }
            catch
            {
                throw;
            }

            return Data;
        }

        private void ChartClear()
        {
            chartControl1.Series.Clear();
            chartControl2.Series.Clear();
            chartControl3.Series.Clear();
        }

        private void BtnSerialDisconnect_Click(object sender, EventArgs e)
        {
            MainComPort.Close();
            BtnSerialConnect.Enabled = true;
            BtnSerialDisconnect.Enabled = false;

            StatusPortName.Text = "";
            StatusBaudRate.Text = "";
            StatusDataBits.Text = "";
            StatusStopBits.Text = "";
            StatusParityBits.Text = "";
            StatusHandShake.Text = "";
            StatusPort.Text = "CLOSED";
        }

        private void TxTimer_Tick(object sender, EventArgs e)
        {
            // Interval 간격 마다 이 함수 실행

        }

        private void NowTime_Tick(object sender, EventArgs e)
        {
            NowTimeLabel.Text = String.Format("{0}시 {1:0#}분 {2}초",
                DateTime.Now.Hour, DateTime.Now.Minute,
                DateTime.Now.Second.ToString().PadLeft(2, '0'));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}