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
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();

            acceptedDataGridView.AutoGenerateColumns = false;
            notAcceptedDataGridView.AutoGenerateColumns = false;

            button1.Text = tabControl1.SelectedIndex == 0 ? "Відхилити" : "Прийняти";

            init();
        }

        void init()
        {
            acceptedDataGridView.DataSource = DatabaseManager.getAcceptedRequests();
            notAcceptedDataGridView.DataSource = DatabaseManager.getNotAcceptedRequests();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form form = new AddRequest();
            form.ShowDialog(this);
            init();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            button1.Text = tabControl1.SelectedIndex == 0 ? "Відхилити" : "Прийняти";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                var rows = acceptedDataGridView.SelectedRows;
                if (rows.Count == 0 || rows.Count > 1)
                    return;

                DataTable dt = (DataTable)acceptedDataGridView.DataSource;
                var row = dt.Rows[rows[0].Index];
                DatabaseManager.rejectRequest(Convert.ToInt16(row["id_request"]));
            }
            else
            {
                var rows = notAcceptedDataGridView.SelectedRows;
                if (rows.Count == 0 || rows.Count > 1)
                    return;

                DataTable dt = (DataTable)notAcceptedDataGridView.DataSource;
                var row = dt.Rows[rows[0].Index];
                DatabaseManager.acceptRequest(Convert.ToInt16(row["id_request"]));
            }

            init();
        }
    }
}
