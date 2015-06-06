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
    public partial class AddEquipmentRequest : Form
    {
        public AddEquipmentRequest()
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

            eventComboBox.DataSource = DatabaseManager.getSingleEvents(true);
            eventComboBox.ValueMember = "id_event";
            eventComboBox.DisplayMember = "name";
            eventComboBox.SelectedIndex = 0;

            equipmentComboBox.DataSource = DatabaseManager.getEquipment();
            equipmentComboBox.ValueMember = "id_equipment";
            equipmentComboBox.DisplayMember = "name";
            equipmentComboBox.SelectedIndex = 0;
        }

        void reinit()
        {
            if (buyCheckBox.Checked)
            {
                eventComboBox.Enabled = false;
            }
            else
            {
                eventComboBox.Enabled = true;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DatabaseManager.addEquipmentRequest(Convert.ToInt16(clientComboBox.SelectedValue), Convert.ToInt16(buyCheckBox.Checked ? 0 : eventComboBox.SelectedValue),
                Convert.ToInt16(equipmentComboBox.SelectedValue), Convert.ToInt16(quantityUpAndDown.Value));
            this.Close();
        }

        private void buyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            reinit();
        }
    }
}
