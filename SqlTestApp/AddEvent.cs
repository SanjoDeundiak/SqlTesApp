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
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();

            init();
        }

        private void init()
        {
            typeComboBox.DataSource = DatabaseManager.getEventTypes();
            typeComboBox.ValueMember = "type";
            typeComboBox.DisplayMember = "name";
            typeComboBox.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Int16 type = Convert.ToInt16(typeComboBox.SelectedValue);
            String name = nameTextBox.Text;

            if (name == "")
                return;

            DatabaseManager.addPeriodicEvent(name, type);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new ChooseSport();
            form.ShowDialog(this);
        }
    }
}
