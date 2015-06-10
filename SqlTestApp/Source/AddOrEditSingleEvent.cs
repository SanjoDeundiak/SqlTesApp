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
    public partial class AddOrEditSingleEvent : Form
    {
        Int16 eventId;
        public AddOrEditSingleEvent(Int16 eventId = 0)
        {
            InitializeComponent();

            this.eventId = eventId;

            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";

            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";

            init();
        }

        void init()
        {
            if (eventId != 0)
            {
                SingleEvent ev = DatabaseManager.getSingleEvent(eventId);
                
                nameTextBox.Text = ev.Name;
                startDateTimePicker.Value = ev.start;
                endDateTimePicker.Value = ev.end;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;

            if (name == "")
                return;

            if (name.Length >= 40)
            {
                name = name.Substring(0, 40);
            }

            if (eventId == 0)
            {
                DataTable dt = DatabaseManager.addSingleEvent(name, Utils.ParseTime(startDateTimePicker), Utils.ParseTime(endDateTimePicker));
                eventId = Convert.ToInt16(dt.Rows[0]["id_event"]);
            }
            else
            {
                DatabaseManager.updateSingleEvent(eventId, name, Utils.ParseTime(startDateTimePicker), Utils.ParseTime(endDateTimePicker));
            }

            this.Close();
        }
    }
}
