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
    public partial class EquipmentRequests : Form
    {
        public EquipmentRequests()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            init();
        }

        void init()
        {
            if (checkBox1.Checked)
                dataGridView1.DataSource = DatabaseManager.getEquipmentAllRequests();
            else
                dataGridView1.DataSource = DatabaseManager.getEquipmentAcceptedRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEquipmentRequest form = new AddEquipmentRequest();
            form.ShowDialog(this);
            init();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0 || rows.Count > 1)
                return;

            DataTable dt = (DataTable)dataGridView1.DataSource;
            var row = dt.Rows[rows[0].Index];
            DatabaseManager.acceptRequest(Convert.ToInt16(row["id_request"]));

            init();
        }
    }
}
