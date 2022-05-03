namespace PainePS
{
    partial class Form1
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
            Iocomp.Classes.PlotChannelTrace plotChannelTrace5 = new Iocomp.Classes.PlotChannelTrace();
            Iocomp.Classes.PlotChannelTrace plotChannelTrace6 = new Iocomp.Classes.PlotChannelTrace();
            Iocomp.Classes.PlotDataCursorXY plotDataCursorXY3 = new Iocomp.Classes.PlotDataCursorXY();
            Iocomp.Classes.PlotDataView plotDataView3 = new Iocomp.Classes.PlotDataView();
            Iocomp.Classes.PlotLabelBasic plotLabelBasic3 = new Iocomp.Classes.PlotLabelBasic();
            Iocomp.Classes.PlotLegendBasic plotLegendBasic3 = new Iocomp.Classes.PlotLegendBasic();
            Iocomp.Classes.PlotXAxis plotXAxis3 = new Iocomp.Classes.PlotXAxis();
            Iocomp.Classes.PlotYAxis plotYAxis3 = new Iocomp.Classes.PlotYAxis();
            this.plot1 = new Iocomp.Instrumentation.Plotting.Plot();
            this.sevenSegmentAnalog1 = new Iocomp.Instrumentation.Standard.SevenSegmentAnalog();
            this.sevenSegmentAnalog2 = new Iocomp.Instrumentation.Standard.SevenSegmentAnalog();
            this.label_COM = new System.Windows.Forms.Label();
            this.text_COM = new System.Windows.Forms.TextBox();
            this.button_OPEN_COM_Port = new System.Windows.Forms.Button();
            this.serialPort_Paine = new System.IO.Ports.SerialPort(this.components);
            this.listBox_Messages = new System.Windows.Forms.ListBox();
            this.button_RECORD = new System.Windows.Forms.Button();
            this.timer_SendReceive = new System.Windows.Forms.Timer(this.components);
            this.textBox_Command = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SendCommand = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Plot_Enabled = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Fit_All = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Expand = new System.Windows.Forms.Button();
            this.check_Auto_Scale = new System.Windows.Forms.CheckBox();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_COM_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Change_Node_Address = new System.Windows.Forms.Button();
            this.textBox_Node_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_Read_Serial = new System.Windows.Forms.Button();
            this.button_Read_Version = new System.Windows.Forms.Button();
            this.button_Read_T = new System.Windows.Forms.Button();
            this.button_Read_P = new System.Windows.Forms.Button();
            this.button_Request_PT = new System.Windows.Forms.Button();
            this.button_Stop_Continuous = new System.Windows.Forms.Button();
            this.button_Start_Continuous = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox_Mode_Commands = new System.Windows.Forms.GroupBox();
            this.comboBox_decimals = new System.Windows.Forms.ComboBox();
            this.button_Set_Decimals = new System.Windows.Forms.Button();
            this.textBox_Acquisitio_Time = new System.Windows.Forms.TextBox();
            this.button_Set_ACQ_Time = new System.Windows.Forms.Button();
            this.button_Factory_Reset = new System.Windows.Forms.Button();
            this.comboBox_Node_Address = new System.Windows.Forms.ComboBox();
            this.comboBox_Multimode = new System.Windows.Forms.ComboBox();
            this.comboBox_Terminal_Embedded = new System.Windows.Forms.ComboBox();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.button_Parity = new System.Windows.Forms.Button();
            this.comboBox_Baud_Rate = new System.Windows.Forms.ComboBox();
            this.button_Baud_Rate = new System.Windows.Forms.Button();
            this.button_Node_Address = new System.Windows.Forms.Button();
            this.button_Terrminal_Embedded = new System.Windows.Forms.Button();
            this.button_Multimode = new System.Windows.Forms.Button();
            this.button_Setup_Mode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox_Mode_Commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot1
            // 
            this.plot1.LoadingBegin();
            this.plot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            plotChannelTrace5.Color = System.Drawing.Color.Red;
            plotChannelTrace5.Name = "Pressure";
            plotChannelTrace5.TitleText = "Pressure";
            plotChannelTrace5.Trace.Thickness = 2D;
            plotChannelTrace6.Color = System.Drawing.Color.Blue;
            plotChannelTrace6.Name = "Temperature";
            plotChannelTrace6.TitleText = "Temperature";
            plotChannelTrace6.Trace.Thickness = 2D;
            this.plot1.Channels.Add(plotChannelTrace5);
            this.plot1.Channels.Add(plotChannelTrace6);
            plotDataCursorXY3.Hint.Fill.Pen.Color = System.Drawing.SystemColors.InfoText;
            plotDataCursorXY3.Name = "Data-Cursor 1";
            plotDataCursorXY3.TitleText = "Data-Cursor 1";
            this.plot1.DataCursors.Add(plotDataCursorXY3);
            plotDataView3.Name = "Data-View 1";
            plotDataView3.TitleText = "Data-View 1";
            this.plot1.DataViews.Add(plotDataView3);
            plotLabelBasic3.DockOrder = 0;
            plotLabelBasic3.Name = "Title";
            plotLabelBasic3.Text = "Paine Pressure Sensor - Pressure & Temperature";
            plotLabelBasic3.TitleText = "Label 1";
            this.plot1.Labels.Add(plotLabelBasic3);
            plotLegendBasic3.DockOrder = 0;
            plotLegendBasic3.Name = "Legend 1";
            plotLegendBasic3.TitleText = "Legend 1";
            this.plot1.Legends.Add(plotLegendBasic3);
            this.plot1.Location = new System.Drawing.Point(3, 3);
            this.plot1.Name = "plot1";
            this.plot1.Size = new System.Drawing.Size(866, 334);
            this.plot1.TabIndex = 0;
            plotXAxis3.DockOrder = 0;
            plotXAxis3.Name = "X-Axis 1";
            plotXAxis3.Title.Text = "X-Axis 1";
            this.plot1.XAxes.Add(plotXAxis3);
            plotYAxis3.DockOrder = 0;
            plotYAxis3.Name = "Y-Axis 1";
            plotYAxis3.Title.Text = "Y-Axis 1";
            this.plot1.YAxes.Add(plotYAxis3);
            this.plot1.LoadingEnd();
            // 
            // sevenSegmentAnalog1
            // 
            this.sevenSegmentAnalog1.LoadingBegin();
            this.sevenSegmentAnalog1.DigitCount = 4;
            this.sevenSegmentAnalog1.Location = new System.Drawing.Point(24, 93);
            this.sevenSegmentAnalog1.Name = "sevenSegmentAnalog1";
            this.sevenSegmentAnalog1.Segment.ColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sevenSegmentAnalog1.Segment.ColorOffAuto = false;
            this.sevenSegmentAnalog1.Size = new System.Drawing.Size(91, 39);
            this.sevenSegmentAnalog1.Value.AsDouble = 75D;
            this.sevenSegmentAnalog1.LoadingEnd();
            // 
            // sevenSegmentAnalog2
            // 
            this.sevenSegmentAnalog2.LoadingBegin();
            this.sevenSegmentAnalog2.Location = new System.Drawing.Point(6, 29);
            this.sevenSegmentAnalog2.Name = "sevenSegmentAnalog2";
            this.sevenSegmentAnalog2.Segment.ColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sevenSegmentAnalog2.Segment.ColorOffAuto = false;
            this.sevenSegmentAnalog2.Size = new System.Drawing.Size(108, 42);
            this.sevenSegmentAnalog2.LoadingEnd();
            // 
            // label_COM
            // 
            this.label_COM.AutoSize = true;
            this.label_COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COM.Location = new System.Drawing.Point(9, 21);
            this.label_COM.Name = "label_COM";
            this.label_COM.Size = new System.Drawing.Size(71, 25);
            this.label_COM.TabIndex = 10;
            this.label_COM.Text = "COM:";
            // 
            // text_COM
            // 
            this.text_COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_COM.Location = new System.Drawing.Point(80, 18);
            this.text_COM.Name = "text_COM";
            this.text_COM.Size = new System.Drawing.Size(60, 31);
            this.text_COM.TabIndex = 11;
            this.text_COM.Text = "1";
            this.text_COM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_OPEN_COM_Port
            // 
            this.button_OPEN_COM_Port.Location = new System.Drawing.Point(9, 113);
            this.button_OPEN_COM_Port.Name = "button_OPEN_COM_Port";
            this.button_OPEN_COM_Port.Size = new System.Drawing.Size(131, 30);
            this.button_OPEN_COM_Port.TabIndex = 12;
            this.button_OPEN_COM_Port.Text = "Open COM Port";
            this.button_OPEN_COM_Port.UseVisualStyleBackColor = true;
            this.button_OPEN_COM_Port.Click += new System.EventHandler(this.button_OPEN_COM_Port_Click);
            // 
            // listBox_Messages
            // 
            this.listBox_Messages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Messages.FormattingEnabled = true;
            this.listBox_Messages.Items.AddRange(new object[] {
            "Open the serial port with the same BR (Baud Rate) and Parity the sensor was set l" +
                "ast time.",
            "Default BR is 19200",
            "Default Parity is odd",
            "It is imperative to ensure that the host system is capable of communication at th" +
                "e",
            "desired baud rate and parity before changing them. ",
            "To plot and display data, send \"Start Continuous\" command (START_OUT - start cont" +
                "inuous data output).",
            "To display data, send \"Request T and P\" command (POOL_DATA - request pressure and" +
                " temperature)."});
            this.listBox_Messages.Location = new System.Drawing.Point(293, 375);
            this.listBox_Messages.Name = "listBox_Messages";
            this.listBox_Messages.Size = new System.Drawing.Size(584, 147);
            this.listBox_Messages.TabIndex = 13;
            // 
            // button_RECORD
            // 
            this.button_RECORD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RECORD.BackColor = System.Drawing.Color.Green;
            this.button_RECORD.Location = new System.Drawing.Point(755, 273);
            this.button_RECORD.Name = "button_RECORD";
            this.button_RECORD.Size = new System.Drawing.Size(102, 36);
            this.button_RECORD.TabIndex = 14;
            this.button_RECORD.Text = "RECORD";
            this.button_RECORD.UseVisualStyleBackColor = false;
            this.button_RECORD.Click += new System.EventHandler(this.button_RECORD_Click);
            // 
            // timer_SendReceive
            // 
            this.timer_SendReceive.Enabled = true;
            this.timer_SendReceive.Interval = 1000;
            this.timer_SendReceive.Tick += new System.EventHandler(this.timer_SendReceive_Tick);
            // 
            // textBox_Command
            // 
            this.textBox_Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Command.Location = new System.Drawing.Point(6, 35);
            this.textBox_Command.Name = "textBox_Command";
            this.textBox_Command.Size = new System.Drawing.Size(109, 31);
            this.textBox_Command.TabIndex = 15;
            this.textBox_Command.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sensor Command:";
            // 
            // button_SendCommand
            // 
            this.button_SendCommand.Location = new System.Drawing.Point(6, 72);
            this.button_SendCommand.Name = "button_SendCommand";
            this.button_SendCommand.Size = new System.Drawing.Size(109, 30);
            this.button_SendCommand.TabIndex = 17;
            this.button_SendCommand.Text = "Send Command";
            this.button_SendCommand.UseVisualStyleBackColor = true;
            this.button_SendCommand.Click += new System.EventHandler(this.button_SendCommand_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox_Plot_Enabled);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_Fit_All);
            this.groupBox1.Controls.Add(this.button_Reset);
            this.groupBox1.Controls.Add(this.button_Expand);
            this.groupBox1.Controls.Add(this.check_Auto_Scale);
            this.groupBox1.Location = new System.Drawing.Point(755, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 165);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLOT";
            // 
            // checkBox_Plot_Enabled
            // 
            this.checkBox_Plot_Enabled.AutoSize = true;
            this.checkBox_Plot_Enabled.Location = new System.Drawing.Point(12, 142);
            this.checkBox_Plot_Enabled.Name = "checkBox_Plot_Enabled";
            this.checkBox_Plot_Enabled.Size = new System.Drawing.Size(76, 17);
            this.checkBox_Plot_Enabled.TabIndex = 15;
            this.checkBox_Plot_Enabled.Text = "ENABLED";
            this.checkBox_Plot_Enabled.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "Scroll";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Fit_All
            // 
            this.button_Fit_All.Location = new System.Drawing.Point(12, 42);
            this.button_Fit_All.Name = "button_Fit_All";
            this.button_Fit_All.Size = new System.Drawing.Size(77, 24);
            this.button_Fit_All.TabIndex = 12;
            this.button_Fit_All.Text = "Fit All";
            this.button_Fit_All.UseVisualStyleBackColor = true;
            this.button_Fit_All.Click += new System.EventHandler(this.button_Fit_All_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(12, 15);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(77, 24);
            this.button_Reset.TabIndex = 13;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Expand
            // 
            this.button_Expand.Location = new System.Drawing.Point(12, 69);
            this.button_Expand.Name = "button_Expand";
            this.button_Expand.Size = new System.Drawing.Size(77, 24);
            this.button_Expand.TabIndex = 11;
            this.button_Expand.Text = "Expand";
            this.button_Expand.UseVisualStyleBackColor = true;
            this.button_Expand.Click += new System.EventHandler(this.button_Expand_Click);
            // 
            // check_Auto_Scale
            // 
            this.check_Auto_Scale.AutoSize = true;
            this.check_Auto_Scale.Checked = true;
            this.check_Auto_Scale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_Auto_Scale.Location = new System.Drawing.Point(11, 124);
            this.check_Auto_Scale.Name = "check_Auto_Scale";
            this.check_Auto_Scale.Size = new System.Drawing.Size(78, 17);
            this.check_Auto_Scale.TabIndex = 10;
            this.check_Auto_Scale.Text = "Auto Scale";
            this.check_Auto_Scale.UseVisualStyleBackColor = true;
            // 
            // comboBox_Baud
            // 
            this.comboBox_Baud.FormattingEnabled = true;
            this.comboBox_Baud.Items.AddRange(new object[] {
            "19200",
            "115200"});
            this.comboBox_Baud.Location = new System.Drawing.Point(80, 54);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(60, 21);
            this.comboBox_Baud.TabIndex = 20;
            this.comboBox_Baud.Text = "19200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "BR:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.comboBox_COM_Parity);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_Baud);
            this.groupBox2.Controls.Add(this.button_OPEN_COM_Port);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.text_COM);
            this.groupBox2.Controls.Add(this.label_COM);
            this.groupBox2.Location = new System.Drawing.Point(9, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 149);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Communication";
            // 
            // comboBox_COM_Parity
            // 
            this.comboBox_COM_Parity.FormattingEnabled = true;
            this.comboBox_COM_Parity.Items.AddRange(new object[] {
            "none",
            "odd",
            "even"});
            this.comboBox_COM_Parity.Location = new System.Drawing.Point(80, 81);
            this.comboBox_COM_Parity.Name = "comboBox_COM_Parity";
            this.comboBox_COM_Parity.Size = new System.Drawing.Size(60, 21);
            this.comboBox_COM_Parity.TabIndex = 22;
            this.comboBox_COM_Parity.Text = "odd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Parity:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_SendCommand);
            this.groupBox3.Controls.Add(this.textBox_Command);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(22, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 111);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual Command";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.sevenSegmentAnalog2);
            this.groupBox4.Controls.Add(this.sevenSegmentAnalog1);
            this.groupBox4.Location = new System.Drawing.Point(166, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 149);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DATA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Temperature [F]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pressure [psi]:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 366);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button_RECORD);
            this.tabPage1.Controls.Add(this.plot1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PLOT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Change_Node_Address);
            this.tabPage2.Controls.Add(this.textBox_Node_Address);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.groupBox_Mode_Commands);
            this.tabPage2.Controls.Add(this.button_Setup_Mode);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commands";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Change_Node_Address
            // 
            this.button_Change_Node_Address.Location = new System.Drawing.Point(158, 41);
            this.button_Change_Node_Address.Name = "button_Change_Node_Address";
            this.button_Change_Node_Address.Size = new System.Drawing.Size(71, 31);
            this.button_Change_Node_Address.TabIndex = 35;
            this.button_Change_Node_Address.Text = "Change";
            this.button_Change_Node_Address.UseVisualStyleBackColor = true;
            this.button_Change_Node_Address.Click += new System.EventHandler(this.button_Change_Node_Address_Click);
            // 
            // textBox_Node_Address
            // 
            this.textBox_Node_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Node_Address.Location = new System.Drawing.Point(112, 41);
            this.textBox_Node_Address.Name = "textBox_Node_Address";
            this.textBox_Node_Address.Size = new System.Drawing.Size(43, 31);
            this.textBox_Node_Address.TabIndex = 34;
            this.textBox_Node_Address.Text = "NA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Address: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_Read_Serial);
            this.groupBox6.Controls.Add(this.button_Read_Version);
            this.groupBox6.Controls.Add(this.button_Read_T);
            this.groupBox6.Controls.Add(this.button_Read_P);
            this.groupBox6.Controls.Add(this.button_Request_PT);
            this.groupBox6.Controls.Add(this.button_Stop_Continuous);
            this.groupBox6.Controls.Add(this.button_Start_Continuous);
            this.groupBox6.Location = new System.Drawing.Point(468, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(142, 264);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Operating Commands";
            // 
            // button_Read_Serial
            // 
            this.button_Read_Serial.Location = new System.Drawing.Point(4, 229);
            this.button_Read_Serial.Name = "button_Read_Serial";
            this.button_Read_Serial.Size = new System.Drawing.Size(132, 30);
            this.button_Read_Serial.TabIndex = 36;
            this.button_Read_Serial.Text = "Read Serial#";
            this.button_Read_Serial.UseVisualStyleBackColor = true;
            this.button_Read_Serial.Click += new System.EventHandler(this.button_Read_Serial_Click);
            // 
            // button_Read_Version
            // 
            this.button_Read_Version.Location = new System.Drawing.Point(4, 194);
            this.button_Read_Version.Name = "button_Read_Version";
            this.button_Read_Version.Size = new System.Drawing.Size(132, 30);
            this.button_Read_Version.TabIndex = 35;
            this.button_Read_Version.Text = "Read Version";
            this.button_Read_Version.UseVisualStyleBackColor = true;
            this.button_Read_Version.Click += new System.EventHandler(this.button_Read_Version_Click);
            // 
            // button_Read_T
            // 
            this.button_Read_T.Location = new System.Drawing.Point(4, 159);
            this.button_Read_T.Name = "button_Read_T";
            this.button_Read_T.Size = new System.Drawing.Size(132, 30);
            this.button_Read_T.TabIndex = 34;
            this.button_Read_T.Text = "Read Temperature";
            this.button_Read_T.UseVisualStyleBackColor = true;
            this.button_Read_T.Click += new System.EventHandler(this.button_Read_T_Click);
            // 
            // button_Read_P
            // 
            this.button_Read_P.Location = new System.Drawing.Point(4, 124);
            this.button_Read_P.Name = "button_Read_P";
            this.button_Read_P.Size = new System.Drawing.Size(132, 30);
            this.button_Read_P.TabIndex = 33;
            this.button_Read_P.Text = "Read Pressure";
            this.button_Read_P.UseVisualStyleBackColor = true;
            this.button_Read_P.Click += new System.EventHandler(this.button_Read_P_Click);
            // 
            // button_Request_PT
            // 
            this.button_Request_PT.Location = new System.Drawing.Point(4, 89);
            this.button_Request_PT.Name = "button_Request_PT";
            this.button_Request_PT.Size = new System.Drawing.Size(132, 30);
            this.button_Request_PT.TabIndex = 32;
            this.button_Request_PT.Text = "Request P and T";
            this.button_Request_PT.UseVisualStyleBackColor = true;
            this.button_Request_PT.Click += new System.EventHandler(this.button_Request_PT_Click);
            // 
            // button_Stop_Continuous
            // 
            this.button_Stop_Continuous.Location = new System.Drawing.Point(4, 54);
            this.button_Stop_Continuous.Name = "button_Stop_Continuous";
            this.button_Stop_Continuous.Size = new System.Drawing.Size(132, 30);
            this.button_Stop_Continuous.TabIndex = 31;
            this.button_Stop_Continuous.Text = "Stop Continuous";
            this.button_Stop_Continuous.UseVisualStyleBackColor = true;
            this.button_Stop_Continuous.Click += new System.EventHandler(this.button_Stop_Continuous_Click);
            // 
            // button_Start_Continuous
            // 
            this.button_Start_Continuous.Location = new System.Drawing.Point(4, 19);
            this.button_Start_Continuous.Name = "button_Start_Continuous";
            this.button_Start_Continuous.Size = new System.Drawing.Size(132, 30);
            this.button_Start_Continuous.TabIndex = 30;
            this.button_Start_Continuous.Text = "Start Continuous";
            this.button_Start_Continuous.UseVisualStyleBackColor = true;
            this.button_Start_Continuous.Click += new System.EventHandler(this.button_Start_Continuous_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(18, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(130, 29);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Multimode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox_Mode_Commands
            // 
            this.groupBox_Mode_Commands.Controls.Add(this.comboBox_decimals);
            this.groupBox_Mode_Commands.Controls.Add(this.button_Set_Decimals);
            this.groupBox_Mode_Commands.Controls.Add(this.textBox_Acquisitio_Time);
            this.groupBox_Mode_Commands.Controls.Add(this.button_Set_ACQ_Time);
            this.groupBox_Mode_Commands.Controls.Add(this.button_Factory_Reset);
            this.groupBox_Mode_Commands.Controls.Add(this.comboBox_Node_Address);
            this.groupBox_Mode_Commands.Controls.Add(this.comboBox_Multimode);
            this.groupBox_Mode_Commands.Controls.Add(this.comboBox_Terminal_Embedded);
            this.groupBox_Mode_Commands.Controls.Add(this.comboBox_Parity);
            this.groupBox_Mode_Commands.Controls.Add(this.button_Parity);
            this.groupBox_Mode_Commands.Controls.Add(this.comboBox_Baud_Rate);
            this.groupBox_Mode_Commands.Controls.Add(this.button_Baud_Rate);
            this.groupBox_Mode_Commands.Controls.Add(this.button_Node_Address);
            this.groupBox_Mode_Commands.Controls.Add(this.button_Terrminal_Embedded);
            this.groupBox_Mode_Commands.Controls.Add(this.button_Multimode);
            this.groupBox_Mode_Commands.Enabled = false;
            this.groupBox_Mode_Commands.Location = new System.Drawing.Point(616, 11);
            this.groupBox_Mode_Commands.Name = "groupBox_Mode_Commands";
            this.groupBox_Mode_Commands.Size = new System.Drawing.Size(249, 323);
            this.groupBox_Mode_Commands.TabIndex = 28;
            this.groupBox_Mode_Commands.TabStop = false;
            this.groupBox_Mode_Commands.Text = "Setup Mode Commands";
            // 
            // comboBox_decimals
            // 
            this.comboBox_decimals.FormattingEnabled = true;
            this.comboBox_decimals.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_decimals.Location = new System.Drawing.Point(156, 245);
            this.comboBox_decimals.Name = "comboBox_decimals";
            this.comboBox_decimals.Size = new System.Drawing.Size(83, 21);
            this.comboBox_decimals.TabIndex = 44;
            this.comboBox_decimals.Text = "0";
            // 
            // button_Set_Decimals
            // 
            this.button_Set_Decimals.Location = new System.Drawing.Point(7, 240);
            this.button_Set_Decimals.Name = "button_Set_Decimals";
            this.button_Set_Decimals.Size = new System.Drawing.Size(143, 30);
            this.button_Set_Decimals.TabIndex = 43;
            this.button_Set_Decimals.Text = "Set Decimals";
            this.button_Set_Decimals.UseVisualStyleBackColor = true;
            this.button_Set_Decimals.Click += new System.EventHandler(this.button_Set_Decimals_Click);
            // 
            // textBox_Acquisitio_Time
            // 
            this.textBox_Acquisitio_Time.Location = new System.Drawing.Point(156, 209);
            this.textBox_Acquisitio_Time.Name = "textBox_Acquisitio_Time";
            this.textBox_Acquisitio_Time.Size = new System.Drawing.Size(83, 20);
            this.textBox_Acquisitio_Time.TabIndex = 42;
            this.textBox_Acquisitio_Time.Text = "1000";
            // 
            // button_Set_ACQ_Time
            // 
            this.button_Set_ACQ_Time.Location = new System.Drawing.Point(7, 204);
            this.button_Set_ACQ_Time.Name = "button_Set_ACQ_Time";
            this.button_Set_ACQ_Time.Size = new System.Drawing.Size(143, 30);
            this.button_Set_ACQ_Time.TabIndex = 41;
            this.button_Set_ACQ_Time.Text = "Set ACQ Time [ms]";
            this.button_Set_ACQ_Time.UseVisualStyleBackColor = true;
            this.button_Set_ACQ_Time.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_Factory_Reset
            // 
            this.button_Factory_Reset.Location = new System.Drawing.Point(6, 276);
            this.button_Factory_Reset.Name = "button_Factory_Reset";
            this.button_Factory_Reset.Size = new System.Drawing.Size(143, 30);
            this.button_Factory_Reset.TabIndex = 40;
            this.button_Factory_Reset.Text = "Restore Factory Settings";
            this.button_Factory_Reset.UseVisualStyleBackColor = true;
            this.button_Factory_Reset.Click += new System.EventHandler(this.button_Factory_Reset_Click);
            // 
            // comboBox_Node_Address
            // 
            this.comboBox_Node_Address.FormattingEnabled = true;
            this.comboBox_Node_Address.Items.AddRange(new object[] {
            "1",
            "2",
            "Read"});
            this.comboBox_Node_Address.Location = new System.Drawing.Point(156, 98);
            this.comboBox_Node_Address.Name = "comboBox_Node_Address";
            this.comboBox_Node_Address.Size = new System.Drawing.Size(83, 21);
            this.comboBox_Node_Address.TabIndex = 39;
            this.comboBox_Node_Address.Text = "1";
            // 
            // comboBox_Multimode
            // 
            this.comboBox_Multimode.FormattingEnabled = true;
            this.comboBox_Multimode.Items.AddRange(new object[] {
            "Single",
            "Multiple",
            "Read"});
            this.comboBox_Multimode.Location = new System.Drawing.Point(156, 25);
            this.comboBox_Multimode.Name = "comboBox_Multimode";
            this.comboBox_Multimode.Size = new System.Drawing.Size(83, 21);
            this.comboBox_Multimode.TabIndex = 38;
            this.comboBox_Multimode.Text = "Multiple";
            // 
            // comboBox_Terminal_Embedded
            // 
            this.comboBox_Terminal_Embedded.FormattingEnabled = true;
            this.comboBox_Terminal_Embedded.Items.AddRange(new object[] {
            "Terminal",
            "Embedded",
            "Read"});
            this.comboBox_Terminal_Embedded.Location = new System.Drawing.Point(156, 61);
            this.comboBox_Terminal_Embedded.Name = "comboBox_Terminal_Embedded";
            this.comboBox_Terminal_Embedded.Size = new System.Drawing.Size(83, 21);
            this.comboBox_Terminal_Embedded.TabIndex = 37;
            this.comboBox_Terminal_Embedded.Text = "Embedded";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Items.AddRange(new object[] {
            "none",
            "odd",
            "even",
            "Read"});
            this.comboBox_Parity.Location = new System.Drawing.Point(156, 172);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(83, 21);
            this.comboBox_Parity.TabIndex = 36;
            this.comboBox_Parity.Text = "none";
            // 
            // button_Parity
            // 
            this.button_Parity.Location = new System.Drawing.Point(6, 167);
            this.button_Parity.Name = "button_Parity";
            this.button_Parity.Size = new System.Drawing.Size(143, 30);
            this.button_Parity.TabIndex = 35;
            this.button_Parity.Text = "Set Parity";
            this.button_Parity.UseVisualStyleBackColor = true;
            this.button_Parity.Click += new System.EventHandler(this.button_Parity_Click);
            // 
            // comboBox_Baud_Rate
            // 
            this.comboBox_Baud_Rate.FormattingEnabled = true;
            this.comboBox_Baud_Rate.Items.AddRange(new object[] {
            "19200",
            "115200",
            "Read"});
            this.comboBox_Baud_Rate.Location = new System.Drawing.Point(156, 134);
            this.comboBox_Baud_Rate.Name = "comboBox_Baud_Rate";
            this.comboBox_Baud_Rate.Size = new System.Drawing.Size(83, 21);
            this.comboBox_Baud_Rate.TabIndex = 34;
            this.comboBox_Baud_Rate.Text = "115200";
            // 
            // button_Baud_Rate
            // 
            this.button_Baud_Rate.Location = new System.Drawing.Point(6, 130);
            this.button_Baud_Rate.Name = "button_Baud_Rate";
            this.button_Baud_Rate.Size = new System.Drawing.Size(143, 30);
            this.button_Baud_Rate.TabIndex = 33;
            this.button_Baud_Rate.Text = "Set Baud Rate";
            this.button_Baud_Rate.UseVisualStyleBackColor = true;
            this.button_Baud_Rate.Click += new System.EventHandler(this.button_Baud_Rate_Click);
            // 
            // button_Node_Address
            // 
            this.button_Node_Address.Location = new System.Drawing.Point(6, 93);
            this.button_Node_Address.Name = "button_Node_Address";
            this.button_Node_Address.Size = new System.Drawing.Size(143, 30);
            this.button_Node_Address.TabIndex = 31;
            this.button_Node_Address.Text = "Set Node Address";
            this.button_Node_Address.UseVisualStyleBackColor = true;
            this.button_Node_Address.Click += new System.EventHandler(this.button_Node_Address_Click);
            // 
            // button_Terrminal_Embedded
            // 
            this.button_Terrminal_Embedded.Location = new System.Drawing.Point(6, 56);
            this.button_Terrminal_Embedded.Name = "button_Terrminal_Embedded";
            this.button_Terrminal_Embedded.Size = new System.Drawing.Size(143, 30);
            this.button_Terrminal_Embedded.TabIndex = 28;
            this.button_Terrminal_Embedded.Text = "Set Terminal/Embeded";
            this.button_Terrminal_Embedded.UseVisualStyleBackColor = true;
            this.button_Terrminal_Embedded.Click += new System.EventHandler(this.button_Terrminal_Embedded_Click);
            // 
            // button_Multimode
            // 
            this.button_Multimode.Location = new System.Drawing.Point(6, 19);
            this.button_Multimode.Name = "button_Multimode";
            this.button_Multimode.Size = new System.Drawing.Size(143, 30);
            this.button_Multimode.TabIndex = 27;
            this.button_Multimode.Text = "Set Multimode";
            this.button_Multimode.UseVisualStyleBackColor = true;
            this.button_Multimode.Click += new System.EventHandler(this.button_Multimode_Click);
            // 
            // button_Setup_Mode
            // 
            this.button_Setup_Mode.Location = new System.Drawing.Point(468, 18);
            this.button_Setup_Mode.Name = "button_Setup_Mode";
            this.button_Setup_Mode.Size = new System.Drawing.Size(142, 39);
            this.button_Setup_Mode.TabIndex = 26;
            this.button_Setup_Mode.Text = "Change Setup Mode";
            this.button_Setup_Mode.UseVisualStyleBackColor = true;
            this.button_Setup_Mode.Click += new System.EventHandler(this.button_Setup_Mode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox_Messages);
            this.Name = "Form1";
            this.Text = "Weatherford - Paine Pressure Sensor Interface";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox_Mode_Commands.ResumeLayout(false);
            this.groupBox_Mode_Commands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Iocomp.Instrumentation.Plotting.Plot plot1;
        private Iocomp.Instrumentation.Standard.SevenSegmentAnalog sevenSegmentAnalog1;
        private Iocomp.Instrumentation.Standard.SevenSegmentAnalog sevenSegmentAnalog2;
        private System.Windows.Forms.Label label_COM;
        private System.Windows.Forms.TextBox text_COM;
        private System.Windows.Forms.Button button_OPEN_COM_Port;
        private System.IO.Ports.SerialPort serialPort_Paine;
        private System.Windows.Forms.ListBox listBox_Messages;
        private System.Windows.Forms.Button button_RECORD;
        private System.Windows.Forms.Timer timer_SendReceive;
        private System.Windows.Forms.TextBox textBox_Command;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SendCommand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Fit_All;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Expand;
        private System.Windows.Forms.CheckBox check_Auto_Scale;
        private System.Windows.Forms.ComboBox comboBox_Baud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox_Mode_Commands;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.Button button_Parity;
        private System.Windows.Forms.ComboBox comboBox_Baud_Rate;
        private System.Windows.Forms.Button button_Baud_Rate;
        private System.Windows.Forms.Button button_Node_Address;
        private System.Windows.Forms.Button button_Terrminal_Embedded;
        private System.Windows.Forms.Button button_Multimode;
        private System.Windows.Forms.Button button_Setup_Mode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_Read_Serial;
        private System.Windows.Forms.Button button_Read_Version;
        private System.Windows.Forms.Button button_Read_T;
        private System.Windows.Forms.Button button_Read_P;
        private System.Windows.Forms.Button button_Request_PT;
        private System.Windows.Forms.Button button_Stop_Continuous;
        private System.Windows.Forms.Button button_Start_Continuous;
        private System.Windows.Forms.TextBox textBox_Acquisitio_Time;
        private System.Windows.Forms.Button button_Set_ACQ_Time;
        private System.Windows.Forms.Button button_Factory_Reset;
        private System.Windows.Forms.ComboBox comboBox_Node_Address;
        private System.Windows.Forms.ComboBox comboBox_Multimode;
        private System.Windows.Forms.ComboBox comboBox_Terminal_Embedded;
        private System.Windows.Forms.CheckBox checkBox_Plot_Enabled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_COM_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_decimals;
        private System.Windows.Forms.Button button_Set_Decimals;
        private System.Windows.Forms.TextBox textBox_Node_Address;
        private System.Windows.Forms.Button button_Change_Node_Address;
    }
}

