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
    public partial class PlanWindow : Form
    {
        public PlanWindow()
        {
            InitializeComponent();

            periodicDataGridView.Columns["lessonTimes"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            periodicDataGridView.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            periodicDataGridView.DataSource = DatabaseManager.getPeriodicEvents();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form form = new AddOrEditEvent();
            form.ShowDialog(this);
            init();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (eventTabControl.SelectedTab == periodicTab)
            {
                var sel = periodicDataGridView.SelectedRows;
                if (sel.Count == 0 || sel.Count > 1)
                    return;

                var index = sel[0].Index;
                DataTable dt = (DataTable)periodicDataGridView.DataSource;
                AddOrEditEvent form = new AddOrEditEvent(Convert.ToInt16(dt.Rows[index]["id_event"]));
                form.ShowDialog(this);
                init();
            }
        }
    }
}
