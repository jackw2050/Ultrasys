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
    public partial class GravityChartForm : Form
    {
        
        public DataTable dataTable = new DataTable();
        public GravityChartForm()
        {
            InitializeComponent();
            SetupChart();

        }

        private void GravityChartForm_Load(object sender, EventArgs e)
        {
 //            GravityChart1.Series.Add("Series1");
 //            GravityChart1.Series.Add("Series2");
 //            GravityChart1.Series.Add("Series3");
            
        }

     


        private void SetupChart()
        {
            BindingSource SBind = new BindingSource();
            SBind.DataSource = dataTable;


/*


            GravityChart.Series["Digital Gravity"].XValueMember = "dateTime";
            GravityChart.Series["Digital Gravity"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            GravityChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
            GravityChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Angle = -90;
            GravityChart.Series["Digital Gravity"].YValueMembers = "gravity";
            GravityChart.Series["Digital Gravity"].BorderWidth = 4;
            GravityChart.DataSource = dataTable;
            GravityChart.DataBind();
            GravityChart.Series["Spring Tension"].XValueMember = "dateTime";
            GravityChart.Series["Spring Tension"].YValueMembers = "springTension";
            GravityChart.Series["Spring Tension"].BorderWidth = 4;
            GravityChart.DataSource = dataTable;
            GravityChart.DataBind();
            GravityChart.Series["Cross Coupling"].XValueMember = "dateTime";
            GravityChart.Series["Cross Coupling"].YValueMembers = "crossCoupling";
            GravityChart.Series["Cross Coupling"].BorderWidth = 4;
            GravityChart.DataSource = dataTable;
            GravityChart.DataBind();


            GravityChart.Series["Raw Beam"].XValueMember = "dateTime";
            GravityChart.Series["Raw Beam"].YValueMembers = "RawBeam";
            GravityChart.Series["Raw Beam"].BorderWidth = 4;
            GravityChart.DataSource = dataTable;
            GravityChart.DataBind();


            GravityChart.Series["Total Correction"].XValueMember = "dateTime";
            GravityChart.Series["Total Correction"].YValueMembers = "TotalCorrection";
            GravityChart.Series["Total Correction"].BorderWidth = 4;
            GravityChart.DataSource = dataTable;
            GravityChart.DataBind();

            this.GravityChart.Titles.Add("Digital Gravity");

            GravityChart.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(2, 3);
            GravityChart.ChartAreas[0].AxisX.ScaleView.ZoomReset(1);
            GravityChart.ChartAreas[0].AxisY.ScaleView.ZoomReset(1);

            //Enable range selection and zooming end user interface

            GravityChart.ChartAreas["ChartArea1"].CursorX.IsUserEnabled = true;
            GravityChart.ChartAreas["ChartArea1"].CursorY.IsUserEnabled = true;
            GravityChart.ChartAreas["ChartArea1"].CursorX.IsUserSelectionEnabled = true;
            GravityChart.ChartAreas["ChartArea1"].CursorY.IsUserSelectionEnabled = true;
            GravityChart.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoomable = true;
            GravityChart.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoomable = true;
            GravityChart.ChartAreas["ChartArea1"].AxisX.ScrollBar.IsPositionedInside = true;
            GravityChart.ChartAreas["ChartArea1"].AxisY.ScrollBar.IsPositionedInside = true;

*/

        }

        private void GravityChart_Click(object sender, EventArgs e)
        {
          
            /*
            // Set chart data source
            GravityChart.DataSource = dataTable;

            // Set series members names for the X and Y values
            GravityChart.Series["Series 1"].XValueMember = "dateTime";
            GravityChart.Series["Series 1"].YValueMembers = "Gravity";

            // Data bind to the selected data source
            GravityChart.DataBind(); 
             * */
        }

        private void chartCloseButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }



    }
}
