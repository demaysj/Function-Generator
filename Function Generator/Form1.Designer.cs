﻿namespace Function_Generator
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbSine = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbSaw = new System.Windows.Forms.RadioButton();
            this.tbTri = new System.Windows.Forms.RadioButton();
            this.tbTtl = new System.Windows.Forms.RadioButton();
            this.nudOff = new System.Windows.Forms.NumericUpDown();
            this.nudAmp = new System.Windows.Forms.NumericUpDown();
            this.nudDuty = new System.Windows.Forms.NumericUpDown();
            this.lblOff = new System.Windows.Forms.Label();
            this.lblAmp = new System.Windows.Forms.Label();
            this.lblDuty = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAct = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuty)).BeginInit();
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
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(53, 241);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "x1 Hz",
            "x10 Hz",
            "x100 Hz",
            "x1k Hz",
            "x10k Hz"});
            this.comboBox1.Location = new System.Drawing.Point(139, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 2;
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
            this.tabPage1.Controls.Add(this.tbTtl);
            this.tabPage1.Controls.Add(this.tbTri);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDuty);
            this.tabPage2.Controls.Add(this.lblAmp);
            this.tabPage2.Controls.Add(this.lblOff);
            this.tabPage2.Controls.Add(this.nudDuty);
            this.tabPage2.Controls.Add(this.nudAmp);
            this.tabPage2.Controls.Add(this.nudOff);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(220, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wave Parameters";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // 
            // tbTri
            // 
            this.tbTri.AutoSize = true;
            this.tbTri.Location = new System.Drawing.Point(8, 75);
            this.tbTri.Name = "tbTri";
            this.tbTri.Size = new System.Drawing.Size(63, 17);
            this.tbTri.TabIndex = 0;
            this.tbTri.TabStop = true;
            this.tbTri.Text = "Triangle";
            this.tbTri.UseVisualStyleBackColor = true;
            // 
            // tbTtl
            // 
            this.tbTtl.AutoSize = true;
            this.tbTtl.Location = new System.Drawing.Point(8, 98);
            this.tbTtl.Name = "tbTtl";
            this.tbTtl.Size = new System.Drawing.Size(45, 17);
            this.tbTtl.TabIndex = 0;
            this.tbTtl.TabStop = true;
            this.tbTtl.Text = "TTL";
            this.tbTtl.UseVisualStyleBackColor = true;
            // 
            // nudOff
            // 
            this.nudOff.Location = new System.Drawing.Point(98, 12);
            this.nudOff.Name = "nudOff";
            this.nudOff.Size = new System.Drawing.Size(91, 20);
            this.nudOff.TabIndex = 0;
            // 
            // nudAmp
            // 
            this.nudAmp.Location = new System.Drawing.Point(98, 38);
            this.nudAmp.Name = "nudAmp";
            this.nudAmp.Size = new System.Drawing.Size(91, 20);
            this.nudAmp.TabIndex = 0;
            // 
            // nudDuty
            // 
            this.nudDuty.Location = new System.Drawing.Point(98, 64);
            this.nudDuty.Name = "nudDuty";
            this.nudDuty.Size = new System.Drawing.Size(91, 20);
            this.nudDuty.TabIndex = 0;
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
            // lblAmp
            // 
            this.lblAmp.AutoSize = true;
            this.lblAmp.Location = new System.Drawing.Point(13, 14);
            this.lblAmp.Name = "lblAmp";
            this.lblAmp.Size = new System.Drawing.Size(53, 13);
            this.lblAmp.TabIndex = 1;
            this.lblAmp.Text = "Amplitude";
            // 
            // lblDuty
            // 
            this.lblDuty.AutoSize = true;
            this.lblDuty.Location = new System.Drawing.Point(13, 66);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(58, 13);
            this.lblDuty.TabIndex = 1;
            this.lblDuty.Text = "Duty Cycle";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 65);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(154, 336);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 65);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAct);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton tbTtl;
        private System.Windows.Forms.RadioButton tbTri;
        private System.Windows.Forms.RadioButton rbSaw;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbSine;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.Label lblAmp;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.NumericUpDown nudDuty;
        private System.Windows.Forms.NumericUpDown nudAmp;
        private System.Windows.Forms.NumericUpDown nudOff;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuit;
    }
}
