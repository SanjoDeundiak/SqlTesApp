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
    public partial class AddOrEditClient : Form
    {
        private Int32 id = 0;
        public AddOrEditClient()
        {
            InitializeComponent();
        }

        private Individual fillIndividual()
        {
            Individual individual = new Individual();
            individual.id = id;
            individual.Name = nameTextBox.Text;
            individual.MiddleName = middleNameTextBox.Text;
            individual.Surname = surnameTextBox.Text;
            individual.DateOfBirth = dateOfBirthTextBox.Text;
            individual.Address = addressTextBox.Text;

            return individual;
        }

        private void fillTextBoxes(Individual individual)
        {
            nameTextBox.Text = individual.Name;
            middleNameTextBox.Text = individual.MiddleName;
            surnameTextBox.Text = individual.Surname;
            dateOfBirthTextBox.Text = individual.DateOfBirth;
            addressTextBox.Text = individual.Address;
        }

        public AddOrEditClient(Individual individual)
        {
            InitializeComponent();

            id = individual.id;

            fillTextBoxes(individual);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (id == 0) // Creating
            {
                DatabaseManager.addIndividual(fillIndividual());
            }
            else // Updating
            {
                DatabaseManager.updateIndividual(fillIndividual());
            }
            Close();
        }
    }
}
