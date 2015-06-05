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
            form.Closed += (_a, _b) => this.Close();
            this.Hide();
            form.Show();
        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new ConnectionWindow();
            form.Closed += (_a, _b) => this.Close();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new PlanWindow();
            form.Closed += (_a, _b) => this.Close();
            this.Hide();
            form.Show();
        }
    }
}
