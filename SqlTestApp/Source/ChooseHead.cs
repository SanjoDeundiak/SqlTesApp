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
    public partial class ChooseHead : Form
    {
        static List<Int16> fk_sports;
        static Int16 work_place = 0;
        public static Int16 ShowChooseHead(Form form, List<Int16> fk_sports)
        {
            ChooseHead.fk_sports = fk_sports;
            Form newForm = new ChooseHead();
            newForm.ShowDialog(form);
            return ChooseHead.work_place;
        }
        private ChooseHead()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            DataTable dt = DatabaseManager.getWorkPlaces(ChooseHead.fk_sports);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                ChooseHead.work_place = 0;
                Close();
                return;
            }

            DataTable dt = (DataTable)dataGridView1.DataSource;
            ChooseHead.work_place = Convert.ToInt16(dt.Rows[dataGridView1.SelectedRows[0].Index]["id"]);
            Close();
        }

        private void ChooseHead_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
