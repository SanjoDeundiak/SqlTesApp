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
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();

            timeDataGridView.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            timeDataGridView.DataSource = DatabaseManager.getTimes();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form addTime = new AddTime();
            addTime.ShowDialog(this);
            init();
        }
    }
}
