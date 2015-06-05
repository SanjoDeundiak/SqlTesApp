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
    public partial class AddTime : Form
    {
        public AddTime()
        {
            InitializeComponent();

            weekDayComboBox.DataSource = DatabaseManager.getWeekDayNames();
            weekDayComboBox.DisplayMember = "name_of_day";
            weekDayComboBox.ValueMember = "day_of_week";
            weekDayComboBox.SelectedValue = 0;

            startHoursComboBox.DataSource = Utils.Hours;
            startHoursComboBox.DisplayMember = "hour";
            startHoursComboBox.ValueMember = "hour";
            startHoursComboBox.SelectedValue = 0;

            startMinComboBox.DataSource = Utils.Minutes;
            startMinComboBox.DisplayMember = "minute";
            startMinComboBox.ValueMember = "minute";
            startMinComboBox.SelectedValue = 0;

            durationHoursComboBox.DataSource = Utils.Hours;
            durationHoursComboBox.DisplayMember = "hour";
            durationHoursComboBox.ValueMember = "hour";
            durationHoursComboBox.SelectedValue = 0;

            durationMinComboBox.DataSource = Utils.Minutes;
            durationMinComboBox.DisplayMember = "minute";
            durationMinComboBox.ValueMember = "minute";
            durationMinComboBox.SelectedValue = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            TimeEntity time = new TimeEntity();
            time.dayOfWeek = Convert.ToInt16(weekDayComboBox.SelectedIndex);
            time.start = new TimeSpan(startHoursComboBox.SelectedIndex, startMinComboBox.SelectedIndex * 5, 0);
            time.duration = new TimeSpan(durationHoursComboBox.SelectedIndex, durationMinComboBox.SelectedIndex * 5, 0);

            DatabaseManager.addTime(time);
            this.Close();
        }
    }
}
