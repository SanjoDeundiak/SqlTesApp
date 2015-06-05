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
    public partial class SportWindow : Form
    {
        public SportWindow()
        {
            InitializeComponent();

            sportDataGridView.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            sportDataGridView.DataSource = DatabaseManager.getSportNames();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form addSport = new AddSport();
            addSport.ShowDialog(this);
            init();
        }
    }
}
