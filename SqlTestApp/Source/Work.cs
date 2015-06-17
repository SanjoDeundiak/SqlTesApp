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
    public partial class Work : Form
    {
        public Work()
        {
            InitializeComponent();

            workDataGridView.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            workDataGridView.DataSource = DatabaseManager.getWork();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addWork = new AddWork();
            addWork.ShowDialog(this);
            init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (workDataGridView.SelectedRows.Count == 0)
                return;

            DataTable dt = (DataTable)workDataGridView.DataSource;
            Form addWorkPlace = new AddWorkPlace(Convert.ToInt16(dt.Rows[workDataGridView.SelectedRows[0].Index]["id_work"]));
            addWorkPlace.ShowDialog(this);
            init();
        }
    }
}
