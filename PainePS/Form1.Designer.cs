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
            this.plot1.Location = new System.Drawing.Point(4, 7);
            this.plot1.Name = "plot1";
            this.plot1.Size = new System.Drawing.Size(604, 326);
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
            this.sevenSegmentAnalog1.Location = new System.Drawing.Point(657, 74);
            this.sevenSegmentAnalog1.Name = "sevenSegmentAnalog1";
            this.sevenSegmentAnalog1.Segment.ColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sevenSegmentAnalog1.Segment.ColorOffAuto = false;
            this.sevenSegmentAnalog1.ShowSign = false;
            this.sevenSegmentAnalog1.Size = new System.Drawing.Size(74, 31);
            this.sevenSegmentAnalog1.Value.AsDouble = 24D;
            this.sevenSegmentAnalog1.LoadingEnd();
            // 
            // sevenSegmentAnalog2
            // 
            this.sevenSegmentAnalog2.LoadingBegin();
            this.sevenSegmentAnalog2.Location = new System.Drawing.Point(640, 151);
            this.sevenSegmentAnalog2.Name = "sevenSegmentAnalog2";
            this.sevenSegmentAnalog2.Segment.ColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sevenSegmentAnalog2.Segment.ColorOffAuto = false;
            this.sevenSegmentAnalog2.ShowSign = false;
            this.sevenSegmentAnalog2.Size = new System.Drawing.Size(91, 31);
            this.sevenSegmentAnalog2.LoadingEnd();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sevenSegmentAnalog2);
            this.Controls.Add(this.sevenSegmentAnalog1);
            this.Controls.Add(this.plot1);
            this.Name = "Form1";
            this.Text = "Weatherford - Paine Pressure Sensor Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Iocomp.Instrumentation.Plotting.Plot plot1;
        private Iocomp.Instrumentation.Standard.SevenSegmentAnalog sevenSegmentAnalog1;
        private Iocomp.Instrumentation.Standard.SevenSegmentAnalog sevenSegmentAnalog2;
    }
}

