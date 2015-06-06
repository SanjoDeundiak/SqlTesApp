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
    public partial class AddRequest : Form
    {
        public AddRequest()
        {
            InitializeComponent();

            init();
        }

        void init()
        {
            DataTable dt = DatabaseManager.getIndividualClients();
            dt.Columns.Add("ClientInfo", typeof(String), "name + ' ' + surname");

            clientComboBox.DataSource = dt;
            clientComboBox.ValueMember = "id_client";
            clientComboBox.DisplayMember = "ClientInfo";

            clientComboBox.SelectedIndex = 0;

            eventComboBox.DataSource = DatabaseManager.getPeriodicEvents();
            eventComboBox.ValueMember = "id_event";
            eventComboBox.DisplayMember = "name";
            eventComboBox.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DatabaseManager.addRequest(Convert.ToInt16(clientComboBox.SelectedValue), Convert.ToInt16(eventComboBox.SelectedValue));
            this.Close();
        }
    }
}
