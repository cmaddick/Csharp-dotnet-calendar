using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public class SingleCalendarEntry : ICalendarEntry
    {
        DateTime _start;
        int _length;
        string _displayText;
        string _savedData;


        public SingleCalendarEntry(string entryString)
        {
            _savedData = entryString;

            // Parse the tab delimited string and load into instance properties
            string[] properties = _savedData.Split('\t');
            _start = DateTime.ParseExact(properties[0], "yyyy-MM-dd HH:mm", null);
            if (!int.TryParse(properties[1], out _length))
            {
                MessageBox.Show("Failed to convert length string to int", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                   
            _displayText = properties[2];           
        }

        public SingleCalendarEntry(DateTime start, int length, string displayText)
        {
            _start = start;
            _length = length;
            _displayText = displayText;
            UpdateSavedData();
        }

        private void UpdateSavedData()
        {
            _savedData = _start.ToString("yyyy-MM-dd HH:mm") + '\t' + _length.ToString() + '\t' + _displayText;
        }

        public DateTime Start
        {
            get { return _start; }
            set
            {
                _start = value;
                UpdateSavedData();
            }
        }
        public int Length
        {
            get { return _length; }
            set
            {
                _length = value;
                UpdateSavedData();
            }
        }

        public string DisplayText
        {
            get { return _displayText; }
            set
            {
                _displayText = value;
                UpdateSavedData();
            }
        }

        public string SavedData
        {
            get { return _savedData; }
        }

        public bool OccursOnDate(DateTime date)
        {
            return DateTime.Compare(date.Date, _start.Date) == 0;
        }
    }
}
