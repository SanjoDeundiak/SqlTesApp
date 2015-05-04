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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            clientsDataGridView.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            clientsDataGridView.DataSource = DatabaseManager.getIndividualClients();

            toolStripStatusLabel1.Text = "Total: " + clientsDataGridView.RowCount;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEditClient form = new AddOrEditClient();
            form.ShowDialog(this);

            init();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            HashSet<Int32> idsToDelete = new HashSet<int>();
            foreach (DataGridViewCell cell in clientsDataGridView.SelectedCells)
            {
                idsToDelete.Add((Int32)clientsDataGridView.Rows[cell.RowIndex].Cells["id_client"].Value);
            }

            foreach (Int32 id in idsToDelete)
            {
                DatabaseManager.deleteIndividual(id);
            }

            init();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Individual individual = new Individual();
            DataGridViewCell cell = clientsDataGridView.SelectedCells[0];

            DataGridViewCellCollection rowCells = clientsDataGridView.Rows[cell.RowIndex].Cells;
            individual.id = (Int32)rowCells["id_client"].Value;
            individual.Name = rowCells["name"].Value.ToString();
            individual.MiddleName = rowCells["middle_name"].Value.ToString();
            individual.Surname = rowCells["surname"].Value.ToString();
            System.Console.WriteLine(rowCells["date_of_birth"].ValueType);
            DateTime dateOfBirth = (DateTime)rowCells["date_of_birth"].Value;
            individual.DateOfBirth = dateOfBirth.ToShortDateString();
            individual.Address = rowCells["address"].Value.ToString();

            AddOrEditClient form = new AddOrEditClient(individual);
            form.ShowDialog(this);

            init();
        }
    }
}
