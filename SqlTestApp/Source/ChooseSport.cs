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
    public partial class ChooseSport : Form
    {
        public ChooseSport()
        {
            InitializeComponent();

            sportDataGridView.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            sportDataGridView.DataSource = DatabaseManager.getSportNames();


        }
    }
}
