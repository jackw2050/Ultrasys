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
    public partial class GravityDataForm : Form
    {
        private static Boolean setupDone = false;
        public GravityDataForm()
        {
            InitializeComponent();
            SetupDataGrid();
        }


        private void SetupDataGrid()
        {

            if (setupDone == false)
            {
                gravityDataGridView.ColumnCount = 6;

                gravityDataGridView.Columns[0].Name = "Date/ Time";
                gravityDataGridView.Columns[1].Name = "Digital Gravity";
                gravityDataGridView.Columns[2].Name = "Spring Tension";
                gravityDataGridView.Columns[3].Name = "Cross Coupling";
                gravityDataGridView.Columns[4].Name = "Raw Beam";
                gravityDataGridView.Columns[5].Name = "Total Correction";
                setupDone = true;
            }
           

        }


        private void GravityDataForm_Load(object sender, EventArgs e)
        {
            // GravityDataForm GravityDataForm = new  GravityDataForm();



         




        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
      
        }

    }
}
