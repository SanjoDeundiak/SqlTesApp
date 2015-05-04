using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlTestApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            SqlDataReader reader = Connection.Test();

            DataTable dt = new DataTable("");

            DataColumn number = new DataColumn();
            number.DataType = typeof(UInt64);
            number.AutoIncrementSeed = 1;
            number.AutoIncrementStep = 1;
            number.AutoIncrement = true;
            number.ColumnName = "number";
            dt.Columns.Add(number);

            dt.Load(reader);

            clientsDataGridView.AutoGenerateColumns = false;
            clientsDataGridView.DataSource = dt;

            this.toolStripStatusLabel1.Text = "Total: " + (clientsDataGridView.RowCount - 1);
        }
    }
}
