namespace Function_Generator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nudFreq = new System.Windows.Forms.NumericUpDown();
            this.cboMult = new System.Windows.Forms.ComboBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbTtl = new System.Windows.Forms.RadioButton();
            this.rbTri = new System.Windows.Forms.RadioButton();
            this.rbSaw = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbSine = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDuty = new System.Windows.Forms.Label();
            this.lblAmp = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.nudDuty = new System.Windows.Forms.NumericUpDown();
            this.nudOff = new System.Windows.Forms.NumericUpDown();
            this.nudAmp = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAct = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.cbOnOff = new System.Windows.Forms.CheckBox();
            this.cboDev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFreq)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmp)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(308, 48);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(454, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title1.Name = "Title1";
            title1.Text = "Volts (V)";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Name = "Title2";
            title2.Text = "Points";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            // 
            // nudFreq
            // 
            this.nudFreq.DecimalPlaces = 1;
            this.nudFreq.Location = new System.Drawing.Point(53, 241);
            this.nudFreq.Name = "nudFreq";
            this.nudFreq.Size = new System.Drawing.Size(80, 20);
            this.nudFreq.TabIndex = 1;
            this.nudFreq.ValueChanged += new System.EventHandler(this.nudFreq_ValueChanged);
            // 
            // cboMult
            // 
            this.cboMult.FormattingEnabled = true;
            this.cboMult.Items.AddRange(new object[] {
            "x1 Hz",
            "x10 Hz",
            "x100 Hz",
            "x1k Hz",
            "x10k Hz"});
            this.cboMult.Location = new System.Drawing.Point(139, 241);
            this.cboMult.Name = "cboMult";
            this.cboMult.Size = new System.Drawing.Size(112, 21);
            this.cboMult.TabIndex = 2;
            this.cboMult.SelectedIndexChanged += new System.EventHandler(this.cboMult_SelectedIndexChanged);
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(54, 225);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(57, 13);
            this.lblFreq.TabIndex = 3;
            this.lblFreq.Text = "Frequency";
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.Location = new System.Drawing.Point(171, 225);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(48, 13);
            this.lblMulti.TabIndex = 4;
            this.lblMulti.Text = "Multiplier";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(45, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(228, 162);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbTtl);
            this.tabPage1.Controls.Add(this.rbTri);
            this.tabPage1.Controls.Add(this.rbSaw);
            this.tabPage1.Controls.Add(this.rbSquare);
            this.tabPage1.Controls.Add(this.rbSine);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(220, 136);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wave Type";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbTtl
            // 
            this.rbTtl.AutoSize = true;
            this.rbTtl.Location = new System.Drawing.Point(8, 98);
            this.rbTtl.Name = "rbTtl";
            this.rbTtl.Size = new System.Drawing.Size(45, 17);
            this.rbTtl.TabIndex = 0;
            this.rbTtl.TabStop = true;
            this.rbTtl.Text = "TTL";
            this.rbTtl.UseVisualStyleBackColor = true;
            this.rbTtl.CheckedChanged += new System.EventHandler(this.rbTtl_CheckedChanged);
            // 
            // rbTri
            // 
            this.rbTri.AutoSize = true;
            this.rbTri.Location = new System.Drawing.Point(8, 75);
            this.rbTri.Name = "rbTri";
            this.rbTri.Size = new System.Drawing.Size(63, 17);
            this.rbTri.TabIndex = 0;
            this.rbTri.TabStop = true;
            this.rbTri.Text = "Triangle";
            this.rbTri.UseVisualStyleBackColor = true;
            this.rbTri.CheckedChanged += new System.EventHandler(this.rbTri_CheckedChanged);
            // 
            // rbSaw
            // 
            this.rbSaw.AutoSize = true;
            this.rbSaw.Location = new System.Drawing.Point(8, 52);
            this.rbSaw.Name = "rbSaw";
            this.rbSaw.Size = new System.Drawing.Size(70, 17);
            this.rbSaw.TabIndex = 0;
            this.rbSaw.TabStop = true;
            this.rbSaw.Text = "Sawtooth";
            this.rbSaw.UseVisualStyleBackColor = true;
            this.rbSaw.CheckedChanged += new System.EventHandler(this.rbSaw_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(8, 29);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(59, 17);
            this.rbSquare.TabIndex = 0;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbSquare_CheckedChanged);
            // 
            // rbSine
            // 
            this.rbSine.AutoSize = true;
            this.rbSine.Location = new System.Drawing.Point(8, 6);
            this.rbSine.Name = "rbSine";
            this.rbSine.Size = new System.Drawing.Size(46, 17);
            this.rbSine.TabIndex = 0;
            this.rbSine.TabStop = true;
            this.rbSine.Text = "Sine";
            this.rbSine.UseVisualStyleBackColor = true;
            this.rbSine.CheckedChanged += new System.EventHandler(this.rbSine_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDuty);
            this.tabPage2.Controls.Add(this.lblAmp);
            this.tabPage2.Controls.Add(this.lblOff);
            this.tabPage2.Controls.Add(this.nudDuty);
            this.tabPage2.Controls.Add(this.nudOff);
            this.tabPage2.Controls.Add(this.nudAmp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(220, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wave Parameters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Location = new System.Drawing.Point(13, 66);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(75, 13);
            this.lblDuty.TabIndex = 1;
            this.lblDuty.Text = "Duty Cycle (%)";
            // 
            // lblAmp
            // 
            this.lblAmp.AutoSize = true;
            this.lblAmp.Location = new System.Drawing.Point(13, 14);
            this.lblAmp.Name = "lblAmp";
            this.lblAmp.Size = new System.Drawing.Size(53, 13);
            this.lblAmp.TabIndex = 1;
            this.lblAmp.Text = "Amplitude";
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.Location = new System.Drawing.Point(13, 42);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(69, 13);
            this.lblOff.TabIndex = 1;
            this.lblOff.Text = "DC Offset (V)";
            // 
            // nudDuty
            // 
            this.nudDuty.Location = new System.Drawing.Point(98, 64);
            this.nudDuty.Name = "nudDuty";
            this.nudDuty.Size = new System.Drawing.Size(91, 20);
            this.nudDuty.TabIndex = 0;
            this.nudDuty.ValueChanged += new System.EventHandler(this.nudDuty_ValueChanged);
            // 
            // nudOff
            // 
            this.nudOff.Location = new System.Drawing.Point(98, 38);
            this.nudOff.Name = "nudOff";
            this.nudOff.Size = new System.Drawing.Size(91, 20);
            this.nudOff.TabIndex = 0;
            this.nudOff.ValueChanged += new System.EventHandler(this.nudOff_ValueChanged);
            // 
            // nudAmp
            // 
            this.nudAmp.Location = new System.Drawing.Point(98, 12);
            this.nudAmp.Name = "nudAmp";
            this.nudAmp.Size = new System.Drawing.Size(91, 20);
            this.nudAmp.TabIndex = 0;
            this.nudAmp.ValueChanged += new System.EventHandler(this.nudAmp_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(154, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lblAct
            // 
            this.lblAct.AutoSize = true;
            this.lblAct.Location = new System.Drawing.Point(33, 281);
            this.lblAct.Name = "lblAct";
            this.lblAct.Size = new System.Drawing.Size(115, 13);
            this.lblAct.TabIndex = 7;
            this.lblAct.Text = "Actual Frequency (Hz):";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(154, 336);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 65);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // cbOnOff
            // 
            this.cbOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbOnOff.BackColor = System.Drawing.Color.Red;
            this.cbOnOff.Checked = true;
            this.cbOnOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOnOff.Location = new System.Drawing.Point(45, 336);
            this.cbOnOff.Name = "cbOnOff";
            this.cbOnOff.Size = new System.Drawing.Size(100, 65);
            this.cbOnOff.TabIndex = 9;
            this.cbOnOff.Text = "Off";
            this.cbOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbOnOff.UseVisualStyleBackColor = false;
            this.cbOnOff.CheckedChanged += new System.EventHandler(this.cbOnOff_CheckedChanged);
            // 
            // cboDev
            // 
            this.cboDev.FormattingEnabled = true;
            this.cboDev.Location = new System.Drawing.Point(467, 380);
            this.cboDev.Name = "cboDev";
            this.cboDev.Size = new System.Drawing.Size(229, 21);
            this.cboDev.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Device/Channel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDev);
            this.Controls.Add(this.cbOnOff);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblAct);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.cboMult);
            this.Controls.Add(this.nudFreq);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFreq)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown nudFreq;
        private System.Windows.Forms.ComboBox cboMult;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbTtl;
        private System.Windows.Forms.RadioButton rbTri;
        private System.Windows.Forms.RadioButton rbSaw;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbSine;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.Label lblAmp;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.NumericUpDown nudDuty;
        private System.Windows.Forms.NumericUpDown nudOff;
        private System.Windows.Forms.NumericUpDown nudAmp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox cbOnOff;
        private System.Windows.Forms.ComboBox cboDev;
        private System.Windows.Forms.Label label1;
    }
}

