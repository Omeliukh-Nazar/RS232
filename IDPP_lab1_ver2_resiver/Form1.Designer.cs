
namespace IDPP_lab1_ver2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint33 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint36 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 0D);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParituBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxByteNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lLeter = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParituBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(360, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM порт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Парність";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Стоповий біт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Кількість біт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Шв. передачі";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM порт";
            // 
            // cBoxParituBits
            // 
            this.cBoxParituBits.FormattingEnabled = true;
            this.cBoxParituBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParituBits.Location = new System.Drawing.Point(104, 155);
            this.cBoxParituBits.Name = "cBoxParituBits";
            this.cBoxParituBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxParituBits.TabIndex = 0;
            this.cBoxParituBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(104, 121);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxStopBits.TabIndex = 0;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(104, 87);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxDataBits.TabIndex = 0;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "600",
            "2400",
            "4800",
            "9600"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(104, 53);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cBoxBaudRate.TabIndex = 0;
            this.cBoxBaudRate.Text = "600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(104, 19);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.cBoxCOMPORT.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(497, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.Location = new System.Drawing.Point(360, 531);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(118, 33);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Відкрити";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Location = new System.Drawing.Point(12, 369);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.Size = new System.Drawing.Size(314, 74);
            this.tBoxDataIn.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(10, 12);
            this.chart1.Name = "chart1";
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.LabelBorderColor = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.White;
            series4.MarkerColor = System.Drawing.Color.White;
            series4.Name = "Signal";
            dataPoint31.LabelBackColor = System.Drawing.Color.White;
            dataPoint31.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint32.BorderWidth = 4;
            dataPoint32.LabelBackColor = System.Drawing.Color.White;
            dataPoint32.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint33.BorderWidth = 4;
            dataPoint33.LabelBackColor = System.Drawing.Color.White;
            dataPoint33.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint34.LabelBackColor = System.Drawing.Color.White;
            dataPoint34.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint35.LabelBackColor = System.Drawing.Color.White;
            dataPoint35.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint36.LabelBackColor = System.Drawing.Color.White;
            dataPoint36.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint37.LabelBackColor = System.Drawing.Color.White;
            dataPoint37.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint38.LabelBackColor = System.Drawing.Color.White;
            dataPoint38.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint39.LabelBackColor = System.Drawing.Color.White;
            dataPoint39.LabelBorderColor = System.Drawing.Color.Black;
            dataPoint40.LabelBackColor = System.Drawing.Color.White;
            dataPoint40.LabelBorderColor = System.Drawing.Color.Black;
            series4.Points.Add(dataPoint31);
            series4.Points.Add(dataPoint32);
            series4.Points.Add(dataPoint33);
            series4.Points.Add(dataPoint34);
            series4.Points.Add(dataPoint35);
            series4.Points.Add(dataPoint36);
            series4.Points.Add(dataPoint37);
            series4.Points.Add(dataPoint38);
            series4.Points.Add(dataPoint39);
            series4.Points.Add(dataPoint40);
            series4.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series4.SmartLabelStyle.CalloutLineWidth = 2;
            series4.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.None;
            series4.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series4.SmartLabelStyle.MinMovingDistance = 5D;
            series4.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right)));
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(610, 291);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Номер байту";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tBoxByteNumber
            // 
            this.tBoxByteNumber.Location = new System.Drawing.Point(124, 329);
            this.tBoxByteNumber.Name = "tBoxByteNumber";
            this.tBoxByteNumber.Size = new System.Drawing.Size(36, 20);
            this.tBoxByteNumber.TabIndex = 7;
            this.tBoxByteNumber.Text = "0";
            this.tBoxByteNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxByteNumber.TextChanged += new System.EventHandler(this.tBoxByteNumber_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(183, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Показати байт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lLeter
            // 
            this.lLeter.AutoSize = true;
            this.lLeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLeter.Location = new System.Drawing.Point(306, 327);
            this.lLeter.Name = "lLeter";
            this.lLeter.Size = new System.Drawing.Size(0, 20);
            this.lLeter.TabIndex = 9;
            this.lLeter.Click += new System.EventHandler(this.lLeter_Click);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTime.Location = new System.Drawing.Point(261, 673);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(0, 20);
            this.lTime.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Іваненко В. А. КІ-34";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(638, 579);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.lLeter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxByteNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tBoxDataIn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Приймач";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParituBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tBoxDataIn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxByteNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lLeter;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label label7;
    }
}

