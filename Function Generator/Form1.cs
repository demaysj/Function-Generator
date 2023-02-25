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

namespace Function_Generator
{
    public partial class Form1 : Form
    {
        NationalInstruments.DAQmx.Task myTask = new NationalInstruments.DAQmx.Task();
        AnalogMultiChannelWriter writer;

        public Form1()
        {
            InitializeComponent();
            cboDev.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AO, PhysicalChannelAccess.External));
            if (cboDev.Items.Count > 0) cboDev.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbOnOff.Checked)
            {
                cbOnOff.Text = "On";
                cbOnOff.BackColor = System.Drawing.Color.Green;

            }
            else
            {
                cbOnOff.Text = "Off";
                cbOnOff.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            writer = new AnalogMultiChannelWriter(myTask.Stream);
            nudAmp.Value = 5;
            nudOff.Value = 0;
            nudDuty.Value = 50;
            rbSine.Checked = true;
            rbSaw.Checked = false;
            rbTri.Checked = false;
            rbSquare.Checked = false;
            rbTtl.Checked = false;

            try
            {
                for (int i = 0; i < cboDev.Items.Count; i++)
                {
                    myTask.AOChannels.CreateVoltageChannel("Dev1/ao" + i, "aoChannel" + i, -10, 10, AOVoltageUnits.Volts);
                }
            }
            catch
            {
                MessageBox.Show("Error connecting to DAQ board");
                this.Close();
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myTask != null)
            {
                myTask.Dispose();
            }
        }
    }
}
