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
            clientsDataGridView.DataSource = DatabaseManager.getIndividualClients();

            this.toolStripStatusLabel1.Text = "Total: " + (clientsDataGridView.RowCount - 1);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog(this);
        }
    }
}
