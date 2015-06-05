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
    public partial class LogWindow : Form
    {
        public LogWindow()
        {
            InitializeComponent();
            logDataGridView.AutoGenerateColumns = false;

            init();
        }

        private void init()
        {
            logDataGridView.DataSource = DatabaseManager.getLog();
        }
    }
}
