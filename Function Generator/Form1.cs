using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
using NationalInstruments.Restricted;

namespace Function_Generator
{
    public partial class Form1 : Form
    {
        NationalInstruments.DAQmx.Task myTask = new NationalInstruments.DAQmx.Task();
        AnalogSingleChannelWriter writer;

        double[] data; 
        double maxSampleRate = 833000;
        double maxBuffer = 8000;
        double points;
        double sampleRate = 8000;
        double Freq = 1;


        public Form1()
        {
            InitializeComponent();

            cboDev.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));
            if (cboDev.Items.Count > 0) cboDev.SelectedIndex = 0;
        }


        private void cbOnOff_CheckedChanged(object sender, EventArgs e)
        {


            if (cbOnOff.Checked)
            {

                myTask.Stop();
                cbOnOff.Text = "On";
                cbOnOff.BackColor = System.Drawing.Color.Green;
                UpdateData();

            }
            else
            {
                myTask.Stop();
                cbOnOff.Text = "Off";
                cbOnOff.BackColor = System.Drawing.Color.Red;
                for (int i = 0; i < (int)points; i++) data[i] = 0;
                try { writer.WriteMultiSample(true, data); }
                catch(Exception ex) { }
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            writer = new AnalogSingleChannelWriter(myTask.Stream);
            nudAmp.Value = 5;
            nudOff.Value = 0;
            nudDuty.Value = 50;
            nudFreq.Value = 1;
            cboMult.SelectedIndex= 0;
            cbOnOff.Checked = false;
            rbSine.Checked = true;
            rbSaw.Checked = false;
            rbTri.Checked = false;
            rbSquare.Checked = false;
            rbTtl.Checked = false;
            nudAmp.Minimum = 0;
            nudAmp.Maximum = 10;
            nudOff.Minimum = -10;
            nudOff.Maximum = 10;
            nudDuty.Minimum = 1;
            nudDuty.Maximum = 99;


            try
            {
                cboDev.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));
                if (cboDev.Items.Count > 0) cboDev.SelectedIndex = 0;

                myTask.AOChannels.CreateVoltageChannel("Dev1/ao" + 0, "aoChannel" + 0, -10, 10, AOVoltageUnits.Volts);

                myTask.Timing.ConfigureSampleClock("", 800000, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples);

                myTask.AOChannels.All.UseOnlyOnBoardMemory = true;

                myTask.Control(TaskAction.Verify);
            }
            catch
            {
                MessageBox.Show("Error connecting to DAQ board");
                this.Close();
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            try {
                myTask.Stop();
                for (int i = 0; i < points; i++) data[i] = 0;
                writer.WriteMultiSample(true, data); }
            catch (Exception ex) { }


            if (myTask != null)
            {
                myTask.Dispose();
            }
        }

        //=========================================================================================================
        //This method will update our data values-can be called from any change event in the program
        //=========================================================================================================
        public void UpdateData()
        {
            double mult; //frequency multiplier
            double amp = (double)nudAmp.Value;
            double offset = (double)nudOff.Value;
            double duty = (double)nudDuty.Value/100;


            if(cboMult.SelectedIndex == 0)
            {
                mult = 1;
            }
            else if(cboMult.SelectedIndex == 1)
            {
                mult = 10;
            }
            else if(cboMult.SelectedIndex == 2)
            {
                mult = 100;
            }
            else if(cboMult.SelectedIndex == 3)
            {
                mult = 1000;
            }
            else
            {
                mult = 10000;
            }

            Freq = ((double)nudFreq.Value * mult);


            sampleRate = maxSampleRate;

            if(Freq > 0) points = Convert.ToInt32(833000 / Freq);

            if (points > maxBuffer)
            {
                points = maxBuffer;
                sampleRate = Convert.ToInt32(Freq * points);
            }

            try
            {
                myTask.Timing.ConfigureSampleClock("", sampleRate, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples);
            }
            catch(Exception ex) { }

            if(Freq > 0) data = new double[Convert.ToInt32(points)];

            if (rbSine.Checked)
            {
                for(int i = 0; i < (int)points; i++)
                {
                    data[i] = amp * Math.Sin((2*Math.PI*i/points)) + offset;

                    if (data[i] > 10) data[i] = 10;
                    else if (data[i] < -10) data[i] = -10;
                }
                nudDuty.Enabled = false;
                nudOff.Enabled = true;
                nudAmp.Enabled = true;
            }
            else if (rbSquare.Checked)
            {
                double perc;
                for(double i = 0; i < (int)points; i++)
                {
                    perc = i / (double)points;
                    if (perc <  duty)
                    {
                        data[(int)i] = amp + offset;
                    }
                    else data[(int)i] = -amp + offset;
                    if (data[(int)i] > 10) data[(int)i] = 10;
                    else if (data[(int)i] < -10) data[(int)i] = -10;
                }
                nudDuty.Enabled = true;
                nudOff.Enabled = true;
                nudAmp.Enabled = true;
            }
            else if (rbSaw.Checked)
            {
                for(int i = 0; i < (int)points; i++)
                {
                    data[i] = 2 * amp * (i / sampleRate) * Freq - amp + offset;
                    if (data[(int)i] > 10) data[(int)i] = 10;
                    else if (data[(int)i] < -10) data[(int)i] = -10;
                }
                nudDuty.Enabled = false;
                nudOff.Enabled = true;
                nudAmp.Enabled = true;
            }
            else if(rbTri.Checked)
            {
                double perc;
                for (double i = 0; i < (int)points; i++)
                {
                    perc = i / (double)points;
                    if (perc < duty)
                    {
                        data[(int)i] = (2 * amp * (i / sampleRate)  /((1 / Freq) * (duty))) - amp + offset;
                    }

                    else data[(int)i] = (-2 * amp * ((i/sampleRate) - ((1/Freq)*duty))/((1/Freq)*(1-duty))) + amp + offset;

                    if (data[(int)i] > 10) data[(int)i] = 10;
                    else if (data[(int)i] < -10) data[(int)i] = -10;
                    nudDuty.Enabled = true;
                    nudOff.Enabled = true;
                    nudAmp.Enabled = true;
                }
            }
            else if(rbTtl.Checked)
            {
                double perc;
                for (double i = 0; i < (int)points; i++)
                {
                    perc = i / (double)points;
                    if (perc < duty)
                    {
                        data[(int)i] = 5;
                    }
                    else data[(int)i] = 0;
                }
                nudOff.Enabled = false;
                nudAmp.Enabled = false;
                nudDuty.Enabled = true;
            }





            try
            {
                myTask.Stop();
                if (chart1.Series.Count > 0) { chart1.Series.RemoveAt(0); }

                chart1.Series.Add("Channel0");

                chart1.Series["Channel0"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                for (int i = 1; i < (int)points + 1; i++)
                {
                    chart1.Series["Channel0"].Points.AddXY(i, data[i - 1]);
                }

                if (cbOnOff.Checked)
                {
                    double actfreq = sampleRate / points;
                    writer.WriteMultiSample(true, data);
                    textBox1.Text = Convert.ToString(actfreq);
                }
                else
                {
                    textBox1.Text = "0";
                }
            }
            catch { }
        }

        private void cboMult_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
         
        }

        private void nudFreq_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void nudAmp_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();

        }

        private void nudOff_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void nudDuty_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void rbSine_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void rbSaw_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void rbTri_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void rbTtl_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
