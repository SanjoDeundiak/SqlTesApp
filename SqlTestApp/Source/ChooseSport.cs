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
        List<Int16> fk_sports;
        static public void ShowChooseSport(Form parent, List<Int16> fk_sports)
        {
            ChooseSport chooseSport = new ChooseSport(fk_sports);
            chooseSport.ShowDialog(parent);
        }
        private ChooseSport(List<Int16> fk_sports)
        {
            InitializeComponent();

            sportDataGridView.AutoGenerateColumns = false;
            this.fk_sports = fk_sports;

            init();
        }

        private void init()
        {
            DataTable sportNames = DatabaseManager.getSportNames();
            DataColumn column = new DataColumn("check", typeof(System.Boolean));
            column.DefaultValue = false;
            sportNames.Columns.Add(column);

            foreach (DataRow row in sportNames.Rows)
            {
                row["check"] = fk_sports.Contains(Convert.ToInt16(row["id_sport"]));
            }
            
            sportDataGridView.DataSource = sportNames;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            fk_sports.Clear();
            foreach (DataRow row in ((DataTable)sportDataGridView.DataSource).Rows)
            {
                if (Convert.ToBoolean(row["check"]))
                {
                    fk_sports.Add(Convert.ToInt16(row["id_sport"]));
                }
            }

            this.Close();
        }
    }
}
