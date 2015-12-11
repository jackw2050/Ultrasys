using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialPortTerminal
{
    public partial class SystemAuxForm : Form
    {
        public SystemAuxForm()
        {
            InitializeComponent();
        }

        private void AuxDisplayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AuxDisplayCheckBox.Checked == true)
            {
                aux1Label.Visible = true;
                aux2Label.Visible = true;
                aux3Label.Visible = true;
                aux4Label.Visible = true;
                aux1TextBox.Visible = true;
                aux2TextBox.Visible = true;
                aux3TextBox.Visible = true;
                aux4TextBox.Visible = true;
                analogLabel.Visible = true;
                digitalLabel.Visible = true;
                digitalTextBox.Visible = true;
            }
            else
            {
                aux1Label.Visible = false;
                aux2Label.Visible = false;
                aux3Label.Visible = false;
                aux4Label.Visible = false;
                aux1TextBox.Visible = false;
                aux2TextBox.Visible = false;
                aux3TextBox.Visible = false;
                aux4TextBox.Visible = false;
                analogLabel.Visible = false;
                digitalLabel.Visible = false;
                digitalTextBox.Visible = false;
            }
        }

        private void systemVoltageDisplayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (systemVoltageDisplayCheckBox.Checked == true)
            {
                plus15vLabel.Visible = true;
                plus15vTextBox.Visible = true;
                plus24vLabel.Visible = true;
                plus24vTextBox.Visible = true;
                plus28vTextBox.Visible = true;
                plus28vLabel.Visible = true;
                minus15vLabel.Visible = true;
                minus15vTextBox.Visible = true;
                minus28vLabel.Visible = true;
                minus28vTextBox.Visible = true;
                plus5vLabel.Visible = true;
                plus5vTextBox.Visible = true;
            }
            else
            {
                plus15vLabel.Visible = false;
                plus15vTextBox.Visible = false;
                plus24vLabel.Visible = false;
                plus24vTextBox.Visible = false;
                plus28vTextBox.Visible = false;
                plus28vLabel.Visible = false;
                minus15vLabel.Visible = false;
                minus15vTextBox.Visible = false;
                minus28vLabel.Visible = false;
                minus28vTextBox.Visible = false;
                plus5vLabel.Visible = false;
                plus5vTextBox.Visible = false;
            }
        }
        private void SystemAuxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
