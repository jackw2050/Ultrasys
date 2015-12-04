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
    public partial class FileConfigurationForm : Form
    {
        public FileConfigurationForm()
        {
            InitializeComponent();
        }
        
        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
          

            fileNameLabel.Text = fileNameTextBox.Text + " " + currentDate.ToString("MMMM dd  yyyy h-mm-ss tt") + ".txt";
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = fileNameLabel.Text;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Filter = "comma delimited (*.csv)|*.csv |tab delimited (*.tsv)|*.tsv| text files (*.txt)|*.txt|all files (*.*)|*.*";

 
            saveFileDialog.Title = "Save a data File";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = "c:\\Ultrasys\\data";

           


            if (fileExtensionComboBox.Text == "Comma")
            {
                saveFileDialog.DefaultExt = "comma delimited";
                saveFileDialog.FilterIndex = 1;
            }
            else if (fileExtensionComboBox.Text == "Tab")
            {
                saveFileDialog.DefaultExt = "txv";
                saveFileDialog.FilterIndex = 2;
            }
            else if (fileExtensionComboBox.Text == "Space")
            {
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FilterIndex = 3;
            }

            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.


                fs.Close();
            }
        }





      


 

       
    }
}