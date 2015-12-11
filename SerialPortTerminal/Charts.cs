using System;
using System.Data;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UltraSys
{
    class Charts
    {
        public DataTable dataTable = new DataTable();
        public void SetupDataTable()
        {
            DataRow myDataRow = dataTable.NewRow();
            DataColumn dtColumn;



            dtColumn = new DataColumn();
            dtColumn.DataType = System.Type.GetType("System.DateTime");
            dtColumn.ColumnName = "DateTime";
            dtColumn.Caption = "Date/Time";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;
            // Add id column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = System.Type.GetType("System.Double");
            dtColumn.ColumnName = "DigitalGravity";
            dtColumn.Caption = "Digital Gravity";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add id column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = System.Type.GetType("System.Double");
            dtColumn.ColumnName = "springTension";
            dtColumn.Caption = "Spring Tension";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add id column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = System.Type.GetType("System.Double");
            dtColumn.ColumnName = "CrossCoupling";
            dtColumn.Caption = "Cross Coupling";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add id column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = System.Type.GetType("System.Double");
            dtColumn.ColumnName = "RawBeam";
            dtColumn.Caption = "Raw Beam";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add id column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = System.Type.GetType("System.Double");
            dtColumn.ColumnName = "TotalCorrection";
            dtColumn.Caption = "Total Correction";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            // Add id column to the DataColumnCollection.
            dataTable.Columns.Add(dtColumn);



            // Make the ID column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = dataTable.Columns["DateTime"];
            dataTable.PrimaryKey = PrimaryKeyColumns;
            // Instantiate the  DataSet variable.

            DataSet dtSet = new DataSet("meterData");

            // Add the custTable to the DataSet.
            dtSet.Tables.Add(dataTable);
        }
    }
}
