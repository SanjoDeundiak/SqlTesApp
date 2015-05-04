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
            AddClient form = new AddClient();
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
    }
}
