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
            List<String[]> result = Connection.Test();
            foreach (String[] row in result)
            {
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
