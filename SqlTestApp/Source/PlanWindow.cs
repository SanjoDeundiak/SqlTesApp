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
            Form form = new AddEvent();
            form.ShowDialog(this);
            init();
        }
    }
}
