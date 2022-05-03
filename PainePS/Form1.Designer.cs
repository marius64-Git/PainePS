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
            Iocomp.Classes.PlotChannelTrace plotChannelTrace1 = new Iocomp.Classes.PlotChannelTrace();
            Iocomp.Classes.PlotChannelTrace plotChannelTrace2 = new Iocomp.Classes.PlotChannelTrace();
            Iocomp.Classes.PlotDataCursorXY plotDataCursorXY1 = new Iocomp.Classes.PlotDataCursorXY();
            Iocomp.Classes.PlotDataView plotDataView1 = new Iocomp.Classes.PlotDataView();
            Iocomp.Classes.PlotLabelBasic plotLabelBasic1 = new Iocomp.Classes.PlotLabelBasic();
            Iocomp.Classes.PlotLegendBasic plotLegendBasic1 = new Iocomp.Classes.PlotLegendBasic();
            Iocomp.Classes.PlotXAxis plotXAxis1 = new Iocomp.Classes.PlotXAxis();
            Iocomp.Classes.PlotYAxis plotYAxis1 = new Iocomp.Classes.PlotYAxis();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button_Fit_All = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Expand = new System.Windows.Forms.Button();
            this.check_Auto_Scale = new System.Windows.Forms.CheckBox();
            this.comboBox_Baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot1
            // 
            this.plot1.LoadingBegin();
            plotChannelTrace1.Color = System.Drawing.Color.Red;
            plotChannelTrace1.Name = "Pressure";
            plotChannelTrace1.TitleText = "Pressure";
            plotChannelTrace1.Trace.Thickness = 2D;
            plotChannelTrace2.Color = System.Drawing.Color.Blue;
            plotChannelTrace2.Name = "Temperature";
            plotChannelTrace2.TitleText = "Temperature";
            plotChannelTrace2.Trace.Thickness = 2D;
            this.plot1.Channels.Add(plotChannelTrace1);
            this.plot1.Channels.Add(plotChannelTrace2);
            plotDataCursorXY1.Hint.Fill.Pen.Color = System.Drawing.SystemColors.InfoText;
            plotDataCursorXY1.Name = "Data-Cursor 1";
            plotDataCursorXY1.TitleText = "Data-Cursor 1";
            this.plot1.DataCursors.Add(plotDataCursorXY1);
            plotDataView1.Name = "Data-View 1";
            plotDataView1.TitleText = "Data-View 1";
            this.plot1.DataViews.Add(plotDataView1);
            plotLabelBasic1.DockOrder = 0;
            plotLabelBasic1.Name = "Title";
            plotLabelBasic1.Text = "Paine Pressure Sensor - Pressure & Temperature";
            plotLabelBasic1.TitleText = "Label 1";
            this.plot1.Labels.Add(plotLabelBasic1);
            plotLegendBasic1.DockOrder = 0;
            plotLegendBasic1.Name = "Legend 1";
            plotLegendBasic1.TitleText = "Legend 1";
            this.plot1.Legends.Add(plotLegendBasic1);
            this.plot1.Location = new System.Drawing.Point(3, 3);
            this.plot1.Name = "plot1";
            this.plot1.Size = new System.Drawing.Size(866, 334);
            this.plot1.TabIndex = 0;
            plotXAxis1.DockOrder = 0;
            plotXAxis1.Name = "X-Axis 1";
            plotXAxis1.Title.Text = "X-Axis 1";
            this.plot1.XAxes.Add(plotXAxis1);
            plotYAxis1.DockOrder = 0;
            plotYAxis1.Name = "Y-Axis 1";
            plotYAxis1.Title.Text = "Y-Axis 1";
            this.plot1.YAxes.Add(plotYAxis1);
            this.plot1.LoadingEnd();
            // 
            // sevenSegmentAnalog1
            // 
            this.sevenSegmentAnalog1.LoadingBegin();
            this.sevenSegmentAnalog1.DigitCount = 4;
            this.sevenSegmentAnalog1.Location = new System.Drawing.Point(30, 75);
            this.sevenSegmentAnalog1.Name = "sevenSegmentAnalog1";
            this.sevenSegmentAnalog1.Segment.ColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sevenSegmentAnalog1.Segment.ColorOffAuto = false;
            this.sevenSegmentAnalog1.ShowSign = false;
            this.sevenSegmentAnalog1.Size = new System.Drawing.Size(81, 48);
            this.sevenSegmentAnalog1.Value.AsDouble = 24D;
            this.sevenSegmentAnalog1.LoadingEnd();
            // 
            // sevenSegmentAnalog2
            // 
            this.sevenSegmentAnalog2.LoadingBegin();
            this.sevenSegmentAnalog2.Location = new System.Drawing.Point(6, 19);
            this.sevenSegmentAnalog2.Name = "sevenSegmentAnalog2";
            this.sevenSegmentAnalog2.Segment.ColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sevenSegmentAnalog2.Segment.ColorOffAuto = false;
            this.sevenSegmentAnalog2.ShowSign = false;
            this.sevenSegmentAnalog2.Size = new System.Drawing.Size(105, 50);
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
            this.button_OPEN_COM_Port.Location = new System.Drawing.Point(9, 93);
            this.button_OPEN_COM_Port.Name = "button_OPEN_COM_Port";
            this.button_OPEN_COM_Port.Size = new System.Drawing.Size(131, 30);
            this.button_OPEN_COM_Port.TabIndex = 12;
            this.button_OPEN_COM_Port.Text = "Open COM Port";
            this.button_OPEN_COM_Port.UseVisualStyleBackColor = true;
            this.button_OPEN_COM_Port.Click += new System.EventHandler(this.button_OPEN_COM_Port_Click);
            // 
            // listBox_Messages
            // 
            this.listBox_Messages.FormattingEnabled = true;
            this.listBox_Messages.Items.AddRange(new object[] {
            "Open the serial port with the same BR (Baud Rate) the sensor was set last time",
            "Default BR is 9600"});
            this.listBox_Messages.Location = new System.Drawing.Point(293, 375);
            this.listBox_Messages.Name = "listBox_Messages";
            this.listBox_Messages.Size = new System.Drawing.Size(588, 134);
            this.listBox_Messages.TabIndex = 13;
            // 
            // button_RECORD
            // 
            this.button_RECORD.BackColor = System.Drawing.Color.Green;
            this.button_RECORD.Location = new System.Drawing.Point(755, 261);
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
            this.textBox_Command.Location = new System.Drawing.Point(6, 46);
            this.textBox_Command.Name = "textBox_Command";
            this.textBox_Command.Size = new System.Drawing.Size(109, 31);
            this.textBox_Command.TabIndex = 15;
            this.textBox_Command.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sensor Command:";
            // 
            // button_SendCommand
            // 
            this.button_SendCommand.Location = new System.Drawing.Point(6, 93);
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
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_Fit_All);
            this.groupBox1.Controls.Add(this.button_Reset);
            this.groupBox1.Controls.Add(this.button_Expand);
            this.groupBox1.Controls.Add(this.check_Auto_Scale);
            this.groupBox1.Location = new System.Drawing.Point(755, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 151);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLOT";
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
            this.check_Auto_Scale.Location = new System.Drawing.Point(11, 128);
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
            "9600",
            "115200"});
            this.comboBox_Baud.Location = new System.Drawing.Point(80, 54);
            this.comboBox_Baud.Name = "comboBox_Baud";
            this.comboBox_Baud.Size = new System.Drawing.Size(60, 21);
            this.comboBox_Baud.TabIndex = 20;
            this.comboBox_Baud.Text = "9600";
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
            this.groupBox2.Controls.Add(this.comboBox_Baud);
            this.groupBox2.Controls.Add(this.button_OPEN_COM_Port);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.text_COM);
            this.groupBox2.Controls.Add(this.label_COM);
            this.groupBox2.Location = new System.Drawing.Point(9, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 134);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Communication";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_SendCommand);
            this.groupBox3.Controls.Add(this.textBox_Command);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 134);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual Commands";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sevenSegmentAnalog2);
            this.groupBox4.Controls.Add(this.sevenSegmentAnalog1);
            this.groupBox4.Location = new System.Drawing.Point(166, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 134);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DATA";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
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
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(872, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commands";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 521);
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
    }
}

