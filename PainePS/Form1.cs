using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO;

namespace PainePS
{
    public partial class Form1 : Form
    {
        private StreamWriter stream_writer;
        bool flag_stream_writer = false;
        bool flag_record = false;
        int plot_points = 0;
        double pressure=0.0d, temperature=0.0d;
        int state = 0;
        int sensor;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_OPEN_COM_Port_Click(object sender, EventArgs e)
        {
            int com_nr = 0;

            if (button_OPEN_COM_Port.Text == "Open COM Port")
            {

                button_OPEN_COM_Port.Text = "Close COM Port";
                if (!int.TryParse(text_COM.Text, out com_nr))
                {
                    com_nr = 1;
                    text_COM.Text = "1";
                    SendToDiagList("Not a valid com number. Changed to default value: 1.");

                }
                text_COM.Enabled = false;
                button_OPEN_COM_Port.Enabled = false;

                try
                {
                    if (serialPort_Paine.IsOpen)
                    {
                        SendToDiagList("Serial " + serialPort_Paine.PortName + " closed.");
                        serialPort_Paine.Close();
                    }
                }
                catch { }

                if (int.TryParse(text_COM.Text, out com_nr))
                {
                    //serialPort1 = new System.IO.Ports.SerialPort();
                    serialPort_Paine.PortName = "COM" + com_nr.ToString();
                    serialPort_Paine.BaudRate = Convert.ToInt32(comboBox_Baud.Text); //9600 or 115200
                    serialPort_Paine.DataBits = 8;
                    serialPort_Paine.DiscardNull = false;
                    //serialPort_Paine.DtrEnable = true;
                    //serialPort_Paine.RtsEnable = true;
                    // serialPort_Paine.Handshake = System.IO.Ports.Handshake.None; //(Handshake)Enum.Parse(typeof(Handshake), "None");
                    serialPort_Paine.Parity = System.IO.Ports.Parity.Odd; //.None; // (Parity)Enum.Parse(typeof(Parity), "None");
                    serialPort_Paine.ReadBufferSize = 1024;
                    serialPort_Paine.StopBits = System.IO.Ports.StopBits.One; // (StopBits)Enum.Parse(typeof(StopBits), "1");
                    serialPort_Paine.WriteBufferSize = 1024;
                    //serialPort_Paine.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Serial_Port_DataReceived);
                    serialPort_Paine.ReadTimeout = 50;
                    serialPort_Paine.WriteTimeout = 50;
                    //serialPort_Paine.NewLine = "\xA\xD";

                    try
                    {
                        serialPort_Paine.Open();
                        serialPort_Paine.DiscardInBuffer();

                        SendToDiagList("Serial COM" + com_nr.ToString() + " opened, BR = " + serialPort_Paine.BaudRate.ToString ());
                        Thread.Sleep(100);
                        button_OPEN_COM_Port.Enabled = true;
                        text_COM.Enabled = true;
                    }
                    catch
                    {
                        //MessageBox.Show(error_msg);
                        SendToDiagList("Serial COM" + com_nr.ToString() + " not opened.");
                        button_OPEN_COM_Port.Enabled = true;
                        text_COM.Enabled = true;
                        button_OPEN_COM_Port.Text = "Open COM Port";
                    }
                }
                else
                {
                    SendToDiagList("COM port is not a valid number!");
                    button_OPEN_COM_Port.Enabled = true;
                    text_COM.Enabled = true;
                    button_OPEN_COM_Port.Text = "Open COM Port";
                }
            }
            else
            {
                try
                {
                    if (serialPort_Paine.IsOpen)
                    {
                        SendToDiagList("Serial " + serialPort_Paine.PortName + " closed.");
                        serialPort_Paine.Close();
                    }
                }
                catch { }
                button_OPEN_COM_Port.Text = "Open COM Port";
                text_COM.Enabled = true;
            }
        }

        public void SendToDiagList(string DiagStr)
        {
            DiagStr = String.Format("{0}:{1}:{2} - ", DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"),
                DateTime.Now.Second.ToString("00")) + DiagStr;
            listBox_Messages.Items.Insert(0, DiagStr);
            while (listBox_Messages.Items.Count > 60)
            {
                listBox_Messages.Items.RemoveAt(listBox_Messages.Items.Count - 1);
            }
            //if (flag_record_log)
            //{
            //    stream_writer_log.WriteLine(DiagStr);
            //}
        }

        private void button_RECORD_Click(object sender, EventArgs e)
        {
            string error_msg, to_stream;

            if (button_RECORD.Text == "RECORD")
            {

                if (!Directory.Exists(@"C:\Log_Data"))
                    try
                    {
                        Directory.CreateDirectory(@"C:\Log_Data");
                    }
                    catch // (Exception ex)
                    {
                        error_msg = "Cannot create Log_Data folder. Check if you have administrator rights.";
                        SendToDiagList(error_msg);
                        return;
                    }
                button_RECORD.Text = "STOP REC."; button_RECORD.BackColor = Color.Red;
                string Date_Time = String.Format("{0}{1}{2}{3}{4}{5}", DateTime.Now.Year, DateTime.Now.Month.ToString("00"),
                        DateTime.Now.Day.ToString("00"), DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"),
                        DateTime.Now.Second.ToString("00"));
                try
                {
                    stream_writer = File.CreateText(@"C:\Log_Data\WFT_Paine_" + Date_Time + ".csv");
                    flag_stream_writer = true;
                    to_stream = "DateTime,Pressure,Temperature";
                    stream_writer.WriteLine(to_stream);
                    error_msg = "Started recording data in " + @"C:\Log_Data\WFT_Paine_" + Date_Time + ".csv";
                    SendToDiagList(error_msg);
                    flag_record = true;
                }
                catch
                {
                    flag_stream_writer = false;
                    flag_record = false;
                    button_RECORD.Text = "RECORD"; button_RECORD.BackColor = Color.Green;
                    error_msg = "Cannot create file to record voltage data. Check if you have administrator rights.";
                    SendToDiagList(error_msg);
                }
            }
            else
            {
                button_RECORD.Text = "RECORD"; button_RECORD.BackColor = Color.Green;
                if (flag_stream_writer)
                {
                    stream_writer.Close();
                    error_msg = "Stopped recording voltage data.";
                    SendToDiagList(error_msg);
                    flag_record = false;
                }
            }
        }

        private void timer_SendReceive_Tick(object sender, EventArgs e)
        {
            string to_stream;

            Receive_Data();

            if ((flag_stream_writer) && (flag_record))
            {
                to_stream = String.Format("{0}/{1}/{2}-{3}:{4}:{5},{6},{7}",
                        DateTime.Now.Year, DateTime.Now.Month.ToString("00"), DateTime.Now.Day.ToString("00"),
                        DateTime.Now.Hour.ToString("00"), DateTime.Now.Minute.ToString("00"), DateTime.Now.Second.ToString("00"),
                        pressure.ToString("0.0"), temperature.ToString("0.0"));
                stream_writer.WriteLine(to_stream);
            }
            try
            {
                plot1.BeginUpdate();
                plot1.Channels[1].AddXY(plot_points, pressure);
                plot1.Channels[0].AddXY(plot_points, temperature);
                plot1.EndUpdate();
                plot_points++;
                Set_YMax();
            }
            catch { SendToDiagList("Plot error1"); }
        }

        void Set_YMax()
        {
            double max = 10;
            double min = 0;

            if (check_Auto_Scale.Checked)
            {

                    if (plot1.Channels[0].YMax > max) max = plot1.Channels[0].YMax;
                    if (plot1.Channels[1].YMax > max) max = plot1.Channels[1].YMax;

             }

                plot1.YAxes[0].Min = min / 1.05;
                if ((max - min) != 0)
                    plot1.YAxes[0].Span = 1.1 * (max - min);
                else plot1.YAxes[0].Span = 6;
        }
        void Receive_Data()
        {
            string serial_in = "";
            string[] serial_data;           

            try
            {
                if (serialPort_Paine.IsOpen)
                {
                    if (serialPort_Paine.BytesToRead > 0)
                        while ((serial_in = serialPort_Paine.ReadLine()) != "")
                        {
                            //serial_in = serialPort_Paine.ReadExisting(); //.ReadLine()
                            //SendToDiagList("*");
                            SendToDiagList("COM: " + serial_in);
                            serial_data = serial_in.Split(new char[] { ' ', ',', '\\' }, StringSplitOptions.RemoveEmptyEntries);
                            if (serial_in.Contains(">>"))
                            {
                                if (serial_data.Length > 0)
                                {
                                    sensor = Convert.ToInt32(serial_data[0]);
                                }
                            }

                                switch (state)
                            {
                                case 0:

                                    
                                    break;

                                default:

                                    break;
                            }
                            serial_data = serial_in.Split(new char[] { ' ', ',', '\\' }, StringSplitOptions.RemoveEmptyEntries);
                            if (serial_data.Length > 0)
                            {
                                if (serial_data[0].Contains(">")) //contains date and time, it's CFG or CMD
                                {

                                }
                                else
                                {
                                    //if (chirp_cmd.rx_data[0, y] == 0) chirp_cmd.rx_data[0, y] = Convert.ToDouble(serial_data[2]);
                                }
                            }

                        }

                    //serialPort_Paine.Write("..."); 
                }
                else //serial not OPEN
                {

                }
            }
            catch //(Exception e)
            {
                //SendToDiagList("Error in receiving serial data from DSP: " + e.ToString());
            }
        }

        private void button_SendCommand_Click(object sender, EventArgs e)
        {
            char[] buff = new char[1];

            if (serialPort_Paine.IsOpen)
            {
                button_SendCommand.Enabled = false;
                //serialPort_Paine.Write(textBox_Command.Text + "\n");
                foreach (char ch in textBox_Command.Text)
                {
                    buff[0] = ch;
                    serialPort_Paine.Write(buff,0,1);
                    Thread.Sleep(1);
                }
                serialPort_Paine.Write("\n");
                Thread.Sleep(100);
                button_SendCommand.Enabled = true;
            }
                
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            plot1.ClearAllData();
            plot_points = 0;
            plot1.XAxes[0].Span = 100;
            plot1.YAxes[0].Span = 100;
        }

        private void button_Fit_All_Click(object sender, EventArgs e)
        {
            plot1.XAxes[0].Tracking.ZoomToFitAll();
            plot1.YAxes[0].Tracking.ZoomToFitAll();
        }

        private void button_Expand_Click(object sender, EventArgs e)
        {
            plot1.XAxes[0].Tracking.Style = Iocomp.Types.PlotTrackingStyle.ExpandMax;
            plot1.YAxes[0].Tracking.Style = Iocomp.Types.PlotTrackingStyle.ExpandMax;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plot1.XAxes[0].Tracking.Style = Iocomp.Types.PlotTrackingStyle.ScrollSmooth;
            plot1.YAxes[0].Tracking.Style = Iocomp.Types.PlotTrackingStyle.ScrollSmooth;
        }
    }
}
