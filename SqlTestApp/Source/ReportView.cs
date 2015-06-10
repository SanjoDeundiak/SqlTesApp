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
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDDataSet.SportPopularity' table. You can move, or remove it, as needed.
            this.SportPopularityTableAdapter.Fill(this.BDDataSet.SportPopularity);

            this.reportViewer1.RefreshReport();
        }
    }
}
