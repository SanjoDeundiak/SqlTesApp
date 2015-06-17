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
    public partial class AddWork : Form
    {
        public AddWork()
        {
            InitializeComponent();

            sportComboBox.DataSource = DatabaseManager.getSportNames();
            sportComboBox.ValueMember = "id_sport";
            sportComboBox.DisplayMember = "name";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float a;
            if (!float.TryParse(textBox2.Text, out a))
            {
                textBox2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a;
            if (!float.TryParse(textBox2.Text, out a))
            {
                textBox2.Clear();
                return;
            }
            DatabaseManager.addWork(Convert.ToInt16(sportComboBox.SelectedValue), textBox1.Text, a);
            Close();
        }
    }
}
