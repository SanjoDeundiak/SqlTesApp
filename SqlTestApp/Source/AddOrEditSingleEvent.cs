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
            startDateTimePicker.CustomFormat = "dd MM yyyy hh mm";

            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "dd MM yyyy hh mm";

            init();
        }

        void init()
        {
            if (eventId != 0)
            {
                SingleEvent ev = DatabaseManager.getSingleEvent(eventId);
                
                nameTextBox.Text = ev.Name;
                this.startDateTimePicker.Value = ev.start;
                this.endDateTimePicker.Value = ev.end;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            String name = nameTextBox.Text;

            if (name == "")
                return;

            if (eventId == 0)
            {
                DataTable dt = DatabaseManager.addSingleEvent(name, startDateTimePicker.Value, endDateTimePicker.Value);
                eventId = Convert.ToInt16(dt.Rows[0]["id_event"]);
            }
            else
            {
                DatabaseManager.updateSingleEvent(eventId, name, startDateTimePicker.Value, endDateTimePicker.Value);
            }

            this.Close();
        }
    }
}
