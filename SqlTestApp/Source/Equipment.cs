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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            init();
        }

        void init()
        {
            dataGridView1.DataSource = DatabaseManager.getEquipment();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form form = new AddEquipment();
            form.ShowDialog(this);
            init();
        }
    }
}
