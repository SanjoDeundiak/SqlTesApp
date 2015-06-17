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
    public partial class AddWorkPlace : Form
    {
        private Int16 idWork;
        public AddWorkPlace(Int16 idWork)
        {
            this.idWork = idWork;

            InitializeComponent();

            dateTimePicker1.MaxDate = DateTime.Now;

            comboBox1.DataSource = DatabaseManager.getIndividualClientsShort();
            comboBox1.ValueMember = "id_client";
            comboBox1.DisplayMember = "clientName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseManager.addWorkPlace(idWork, Convert.ToInt16(comboBox1.SelectedValue), Utils.ParseTime(dateTimePicker1));
            Close();
        }
    }
}
