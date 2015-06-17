using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlTestApp
{
    public partial class WorkPlaces : Form
    {
        public WorkPlaces()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            DataTable dt = DatabaseManager.getWorkPlaces();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DataTable dt = (DataTable)dataGridView1.DataSource;
            Form dismiss = new Dismiss(Convert.ToInt16(dt.Rows[dataGridView1.SelectedRows[0].Index]["id"]));
            dismiss.ShowDialog(this);
            init();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DataTable dt = (DataTable)dataGridView1.DataSource;

            button1.Enabled = Convert.ToBoolean(dt.Rows[dataGridView1.SelectedRows[0].Index]["valid"]);
        }
    }
}
