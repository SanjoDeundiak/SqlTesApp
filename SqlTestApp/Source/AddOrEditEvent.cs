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
    public partial class AddOrEditEvent : Form
    {
        Int16 eventId;
        List<Int16> fk_sports = new List<Int16>();
        List<Int16> fk_times = new List<Int16>();
        Int16 workPlace = 0;
        public AddOrEditEvent(Int16 eventId = 0)
        {
            InitializeComponent();

            this.eventId = eventId;

            init();
        }

        private void init()
        {
            typeComboBox.DataSource = DatabaseManager.getEventTypes();
            typeComboBox.ValueMember = "type";
            typeComboBox.DisplayMember = "name";

            typeComboBox.SelectedIndex = 0;

            PeriodicEvent ev = null;
            if (eventId != 0)
            {
                DataTable dt = DatabaseManager.getSportForEvent(eventId);
                foreach (DataRow row in dt.Rows)
                {
                    fk_sports.Add(Convert.ToInt16(row["fk_sport"]));
                }

                DataTable dt1 = DatabaseManager.getTimesForEvent(eventId);
                foreach (DataRow row in dt1.Rows)
                {
                    fk_times.Add(Convert.ToInt16(row["fk_lesson"]));
                }

                ev = DatabaseManager.getPeriodicEvent(eventId);
                workPlace = ev.workPlaceId;
                nameTextBox.Text = ev.Name;
                timeTextBox.Text = ev.LessonTimes;
                typeComboBox.SelectedIndex = ev.type - 1;
            }
            updateHead();
            updateSports();
            //updateTimes();
        }

        private void updateSports()
        {
            DataTable dt = DatabaseManager.getSportNamesForKeys(fk_sports);

            sportTextBox.Text = "";
            foreach (DataRow row in dt.Rows)
            {
                sportTextBox.Text += ((sportTextBox.Text == "") ? "" : ", ") + Convert.ToString(row["name"]);
            } 
        }

        private void updateTimes()
        {
            DataTable dt = DatabaseManager.getTimesForKeys(fk_times);

            timeTextBox.Text = "";
            foreach (DataRow row in dt.Rows)
            {
                timeTextBox.Text += ((timeTextBox.Text == "") ? "" : ", ") + Convert.ToString(row["time"]);
            }
        }

        private void updateHead()
        {
            if (workPlace != 0)
            {
                DataTable dt = DatabaseManager.getWorkPlace(workPlace);
                textBox1.Text = dt.Rows[0]["name"].ToString();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Int16 type = Convert.ToInt16(typeComboBox.SelectedValue);
            String name = nameTextBox.Text;

            if (name == "")
                return;

            if (eventId == 0)
            {
                DataTable dt = DatabaseManager.addPeriodicEvent(name, type, workPlace);
                eventId = Convert.ToInt16(dt.Rows[0]["id_event"]);
            }
            else
            {
                DatabaseManager.updatePeriodicEvent(eventId, type, name, workPlace);
            }

            DatabaseManager.setEventSports(eventId, fk_sports);
            DatabaseManager.setEventTimes(eventId, fk_times);

            this.Close();
        }

        private void addSportButton_Click(object sender, EventArgs e)
        {
            ChooseSport.ShowChooseSport(this, fk_sports);
            updateSports();
        }

        private void addTimeButton_Click(object sender, EventArgs e)
        {
            ChooseTime.ShowChooseTime(this, fk_times);
            updateTimes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workPlace = ChooseHead.ShowChooseHead(this, fk_sports);
            updateHead();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workPlace = 0;
            updateHead();
        }
    }
}
