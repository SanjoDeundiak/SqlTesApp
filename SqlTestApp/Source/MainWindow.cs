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
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            Form form = new MainClientWindow();
            form.Closed += (_a, _b) => this.Show();
            this.Hide();
            form.Show();
        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ConnectionWindow();
            form.Closed += (_a, _b) => this.Show();
            this.Hide();
            form.Show();
        }

        private void planButton_Click(object sender, EventArgs e)
        {
            Form form = new PlanWindow();
            form.Closed += (_a, _b) => this.Show();
            this.Hide();
            form.Show();
        }

        private void sportButton_Click(object sender, EventArgs e)
        {
            Form form = new SportWindow();
            form.Closed += (_a, _b) => this.Show();
            this.Hide();
            form.Show();
        }

        private void timeButton_Click(object sender, EventArgs e)
        {
            Form form = new Time();
            form.Closed += (_a, _b) => this.Show();
            this.Hide();
            form.Show();
        }

        private void buttonEquipment_Click(object sender, EventArgs e)
        {
            Form form = new Equipment();
            form.Closed += (_a, _b) => this.Show();
            this.Hide();
            form.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void requestsButton_Click(object sender, EventArgs e)
        {
            Form form = new Requests();
            form.Closed += (_a, _b) => this.Show();
            this.Hide();
            form.Show();
        }

        private void equipmentRequestsButton_Click(object sender, EventArgs e)
        {
            Form form = new EquipmentRequests();
            form.Closed += (_a, _b) => this.Show();
            this.Hide();
            form.Show();
        }
    }
}
