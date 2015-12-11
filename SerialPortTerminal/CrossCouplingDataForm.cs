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
    public partial class CrossCouplingDataForm : Form
    {
        private static Boolean setupDone = false;

        public CrossCouplingDataForm()
        {
            InitializeComponent();
            SetupDataGrids();

        }
        public void SetupDataGrids()
        {
            
             crossCouplingDataGridView.ColumnCount = 8;
             crossCouplingDataGridView.Columns[0].Name = "Raw Gravity";
             crossCouplingDataGridView.Columns[1].Name = "VCC";
             crossCouplingDataGridView.Columns[2].Name = "AL";
             crossCouplingDataGridView.Columns[3].Name = "AX";
             crossCouplingDataGridView.Columns[4].Name = "VE";
             crossCouplingDataGridView.Columns[5].Name = "AX2";
             crossCouplingDataGridView.Columns[6].Name = "XACC";
             crossCouplingDataGridView.Columns[7].Name = "LACC";

             setupDone = true;
        }
        private void CrossCouplingDataForm_Load(object sender, EventArgs e)
        {

        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
