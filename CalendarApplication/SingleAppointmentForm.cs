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
    public partial class SingleAppointmentForm : Form
    {
        SingleCalendarEntry _entry;
        bool _editing = false;

        public SingleAppointmentForm()
        {
            InitializeComponent();
        }

        public SingleAppointmentForm(DateTime selectedTime)
        {
            InitializeComponent();

            if (selectedTime != null)
            {
                cboDay.SelectedIndex = selectedTime.Day - 1;
                cboMonth.SelectedIndex = selectedTime.Month - 1;
                numYear.Value = selectedTime.Year;
            }
        }

        public SingleAppointmentForm(SingleCalendarEntry entry)
        {
            // Constructor for editing mode
            InitializeComponent();

            _editing = true;
            _entry = entry;

            // Set field values ready for editing
            string[] message = _entry.DisplayText.Split('@');
            txtSubject.Text = message[0].Trim();
            txtLocation.Text = message[1].Trim();

            cboDay.SelectedIndex = _entry.Start.Day - 1;
            cboMonth.SelectedIndex = _entry.Start.Month - 1;

            numYear.Value = _entry.Start.Year;

            cboStartTime.SelectedIndex = cboStartTime.FindString(_entry.Start.ToString("HH:mm"));
            cboLength.SelectedIndex = (_entry.Length / 30) - 1;
        }

        public SingleCalendarEntry Entry
        {
            get { return _entry; }
            set { _entry = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime startTime;
            string stringStartTime;
            int length;
            string displayText;

            stringStartTime = numYear.Value.ToString() + "-" + cboMonth.SelectedItem.ToString() + "-" + cboDay.SelectedItem.ToString()
                + " " + cboStartTime.SelectedItem.ToString();
            length = (cboLength.SelectedIndex + 1) * 30;
            displayText = txtSubject.Text + " @ " + txtLocation.Text;

            DataValidator validator = new DataValidator(stringStartTime, length);

            if (validator.RunSingleEntryTests())
            {
                startTime = DateTime.ParseExact(stringStartTime, "yyyy-MM-dd HH:mm", null);

                if (!_editing)
                {
                    _entry = new SingleCalendarEntry(startTime, length, displayText);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    _entry.Start = startTime;
                    _entry.Length = length;
                    _entry.DisplayText = displayText;
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
    }
}
