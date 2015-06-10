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
    public partial class ChooseTime : Form
    {
        List<Int16> fk_times;
        static public void ShowChooseTime(Form parent, List<Int16> fk_times)
        {
            ChooseTime chooseSport = new ChooseTime(fk_times);
            chooseSport.ShowDialog(parent);
        }
        private ChooseTime(List<Int16> fk_times)
        {
            InitializeComponent();

            timeDataGridView.AutoGenerateColumns = false;
            this.fk_times = fk_times;

            init();
        }
        private void init()
        {
            DataTable times = DatabaseManager.getTimes();
            DataColumn column = new DataColumn("check", typeof(System.Boolean));
            column.DefaultValue = false;
            times.Columns.Add(column);

            foreach (DataRow row in times.Rows)
            {
                row["check"] = fk_times.Contains(Convert.ToInt16(row["id_lesson"]));
            }

            timeDataGridView.DataSource = times;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            fk_times.Clear();
            foreach (DataRow row in ((DataTable)timeDataGridView.DataSource).Rows)
            {
                if (Convert.ToBoolean(row["check"]))
                {
                    fk_times.Add(Convert.ToInt16(row["id_lesson"]));
                }
            }

            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form form = new AddTime();
            form.ShowDialog(this);
        }
    }
}