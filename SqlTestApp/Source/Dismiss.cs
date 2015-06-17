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
    public partial class Dismiss : Form
    {
        private Int16 idWorkPlace;
        public Dismiss(Int16 idWorkPlace)
        {
            this.idWorkPlace = idWorkPlace;

            InitializeComponent();

            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseManager.dismiss(idWorkPlace, Utils.ParseTime(dateTimePicker1));
            Close();
        }
    }
}
