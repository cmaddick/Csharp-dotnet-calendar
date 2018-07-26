using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class RecurringAppointmentForm : Form
    {
        RecurringCalendarEntry _entry;
        bool _editing = false;

        public RecurringAppointmentForm()
        {
            InitializeComponent();
        }

        public RecurringAppointmentForm(DateTime selectedTime)
        {
            InitializeComponent();

            if (selectedTime != null)
            {
                cboDay.SelectedIndex = selectedTime.Day - 1;
                cboMonth.SelectedIndex = selectedTime.Month - 1;
                numYear.Value = selectedTime.Year;
            }
        }

        public RecurringAppointmentForm(RecurringCalendarEntry entry)
        {
            // Constructor for editing mode
            InitializeComponent();

            _editing = true;
            _entry = entry;

            // Set field values ready for editing
            string[] message = _entry.DisplayText.Split('@');
            txtSubject.Text = message[0].Trim();
            txtLocation.Text = message[1].Trim();

            // Get rid of the frequency substring from the location part
            txtLocation.Text = txtLocation.Text.Replace(" (Daily entry)", "");
            txtLocation.Text = txtLocation.Text.Replace(" (Weekly entry)", "");
            txtLocation.Text = txtLocation.Text.Replace(" (Fortnightly entry)", "");
            txtLocation.Text = txtLocation.Text.Replace(" (Monthly entry)", "");
            txtLocation.Text = txtLocation.Text.Replace(" (Yearly entry)", "");

            cboDay.SelectedIndex = _entry.Start.Day - 1;
            cboMonth.SelectedIndex = _entry.Start.Month - 1;

            numYear.Value = _entry.Start.Year;

            cboStartTime.SelectedIndex = cboStartTime.FindString(_entry.Start.ToString("HH:mm"));
            cboLength.SelectedIndex = (_entry.Length / 30) - 1;
            cboFrequency.SelectedIndex = (int)_entry.Frequency;

            numRepeats.Value = _entry.Repeats;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime startTime;
            string stringStartTime;
            int length;
            int intFreq;
            int repeats;
            string displayText;

            stringStartTime = numYear.Value.ToString() + "-" + cboMonth.SelectedItem.ToString() + "-" + cboDay.SelectedItem.ToString()
                + " " + cboStartTime.SelectedItem.ToString();
            length = (cboLength.SelectedIndex + 1) * 30;
            intFreq = cboFrequency.SelectedIndex;
            displayText = txtSubject.Text + " @ " + txtLocation.Text + " (" + cboFrequency.SelectedItem.ToString() + " entry)";
            repeats = (int)numRepeats.Value;

            DataValidator validator = new DataValidator(stringStartTime, length, intFreq, repeats);

            if (validator.RunRecurringEntryTests())
            {
                startTime = DateTime.ParseExact(stringStartTime, "yyyy-MM-dd HH:mm", null);

                if (!_editing)
                {
                    _entry = new RecurringCalendarEntry(startTime, length, displayText, intFreq, repeats);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    _entry.Start = startTime;
                    _entry.Length = length;
                    _entry.DisplayText = displayText;
                    _entry.Frequency = (RecurringFrequency)intFreq;
                    _entry.Repeats = repeats;
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                // Show errors and prevent from being saved

                StringBuilder message = new StringBuilder();

                foreach (string error in validator.ErrorMessages)
                {
                    message.Append(error).Append('\n');
                }

                MessageBox.Show(message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public RecurringCalendarEntry Entry
        {
            get { return _entry; }
            set { _entry = value; }
        }
    }
}
