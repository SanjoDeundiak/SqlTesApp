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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DatabaseManager.addIndividual(Utils.ValidateString(nameTextBox.Text), Utils.ValidateString(middleNameTextBox.Text), Utils.ValidateString(surnameTextBox.Text),
                dateOfBirthTextBox.Text, Utils.ValidateString(addressTextBox.Text));
            Close();
        }
    }
}
