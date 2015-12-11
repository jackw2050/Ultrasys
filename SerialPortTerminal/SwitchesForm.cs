using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltraSys
{
    public partial class SwitchesForm : Form
    {
        public SwitchesForm()
        {
            InitializeComponent();

        }

        private void switchesGyroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (switchesGyroCheckBox.Checked == true)
            {
                switchesGyroCheckBox.Text = "Gyro (200Hz) ON";
                SwitchesTorqueMotorsCheckBox.Enabled = true;
            }
            else
            {
                switchesGyroCheckBox.Text = "Gyro (200Hz) OFF";
            }
        }

        private void SwitchesTorqueMotorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchesTorqueMotorsCheckBox.Checked == true)
            {
                SwitchesTorqueMotorsCheckBox.Text = "Torque Motors ON";
                SwitchesSpringTensionCheckBox.Enabled = true;
            }
            else
            {
                SwitchesTorqueMotorsCheckBox.Text = "Torque Motors OFF";
            }
        }

        private void SwitchesSpringTensionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchesSpringTensionCheckBox.Checked == true)
            {
                SwitchesSpringTensionCheckBox.Text = "Spring Tension ON";
            }
            else
            {
                SwitchesSpringTensionCheckBox.Text = "Spring Tension Off";
            }
        }

        private void SwitchesAlarmsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SwitchesAlarmsCheckBox.Checked == true)
            {
                SwitchesAlarmsCheckBox.Text = "Alarms ON";
            }
            else
            {
                SwitchesAlarmsCheckBox.Text = "Alarms OFF";
            }
        }

        private void switchesCloseButton_Click(object sender, EventArgs e)
        {
  
        }

        private void SwitchesForm_Load(object sender, EventArgs e)
        {

        }
        private void SwitchesFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    

  
    }
}
