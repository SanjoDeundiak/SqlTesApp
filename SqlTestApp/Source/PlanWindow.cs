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
    public partial class PlanWindow : Form
    {
        public PlanWindow()
        {
            InitializeComponent();

            periodicDataGridView.Columns["lessonTimes"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            periodicDataGridView.AutoGenerateColumns = false;

            singleDataGridView.AutoGenerateColumns = false;

            checkBox1.Visible = false;

            init();
        }

        private bool canEdit = false;

        private void init()
        {
            canEdit = Connection.CanEdit;
            editButton.Enabled = canEdit;

            periodicDataGridView.DataSource = DatabaseManager.getPeriodicEvents();
            singleDataGridView.DataSource = DatabaseManager.getSingleEvents(!checkBox1.Checked);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (eventTabControl.SelectedTab == periodicTab)
            {
                Form form = new AddOrEditEvent();
                form.ShowDialog(this);
            }
            else
            {
                Form form = new AddOrEditSingleEvent();
                form.ShowDialog(this);
            }
            init();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (eventTabControl.SelectedTab == periodicTab)
            {
                var sel = periodicDataGridView.SelectedRows;
                if (sel.Count == 0 || sel.Count > 1)
                    return;

                var index = sel[0].Index;
                DataTable dt = (DataTable)periodicDataGridView.DataSource;
                AddOrEditEvent form = new AddOrEditEvent(Convert.ToInt16(dt.Rows[index]["id_event"]));
                form.ShowDialog(this);
            }
            else
            {
                var sel = singleDataGridView.SelectedRows;
                if (sel.Count == 0 || sel.Count > 1)
                    return;

                var index = sel[0].Index;
                DataTable dt = (DataTable)singleDataGridView.DataSource;
                AddOrEditSingleEvent form = new AddOrEditSingleEvent(Convert.ToInt16(dt.Rows[index]["id_event"]));
                form.ShowDialog(this);
            }

            init();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            init();
        }

        private void eventTabControl_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTextBox.Text = search[eventTabControl.SelectedIndex];

            if (eventTabControl.SelectedIndex == 0)
            {
                checkBox1.Visible = false;
            }
            else
            {
                checkBox1.Visible = true;
            }
        }


        private String[] search = new String[2];
        private void reportButton_Click(object sender, EventArgs e)
        {
            Form form = new ReportView();
            form.ShowDialog(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search[eventTabControl.SelectedIndex] = searchTextBox.Text;
            if (eventTabControl.SelectedIndex == 0)
            {
                search[0] = searchTextBox.Text;
                DataTable dt = (DataTable)periodicDataGridView.DataSource;
                String filter = String.Format("name LIKE '%{0}%'", searchTextBox.Text);
                dt.DefaultView.RowFilter = filter;
            }
            else
            {
                DataTable dt = (DataTable)singleDataGridView.DataSource;
                String filter = String.Format("name LIKE '%{0}%'", searchTextBox.Text);
                dt.DefaultView.RowFilter = filter;
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                searchButton_Click(sender, e);
            }
        }

        private void singleDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (!canEdit || singleDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataTable dt = (DataTable)singleDataGridView.DataSource;
            DateTime endTime = DateTime.Parse(dt.Rows[singleDataGridView.SelectedRows[0].Index]["end_time"].ToString());

            if (endTime < DateTime.Now)
            {
                editButton.Enabled = false;
            }
            else
            {
                editButton.Enabled = true;
            }
        }
    }
}
