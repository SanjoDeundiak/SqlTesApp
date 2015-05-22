using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlTestApp
{
    public partial class ConnectionWindow : Form
    {
        public ConnectionWindow()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            try
            {
                Connection.Connect(serverNameTextBox.Text, loginTextBox.Text, passwordTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Form form = new MainWindow();
            form.Closed += (_a, _b) => this.Close();
            this.Hide();
            form.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
