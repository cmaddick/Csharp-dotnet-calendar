using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calendar
{
    public class RecurringCalendarEntry : ICalendarEntry
    {
        DateTime _start;
        int _length;
        string _displayText;
        string _savedData;
        RecurringFrequency _frequency;
        int _repeats;
        List<DateTime> _datesEntryOccurs;

        public RecurringCalendarEntry(string entryString)
        {
            _savedData = entryString;

            // Parse the tab delimited string and load into instance properties
            string[] properties = _savedData.Split('\t');
            _start = DateTime.ParseExact(properties[0], "yyyy-MM-dd HH:mm", null);
            _length = int.Parse(properties[1]);
            _displayText = properties[2];
            int intFreq = int.Parse(properties[3]);
            if (Enum.IsDefined(typeof(RecurringFrequency), intFreq))
            {
                _frequency = (RecurringFrequency)intFreq;
            }
            _repeats = int.Parse(properties[4]);
            _datesEntryOccurs = GetDatesEntryOccurs();
        }

        public RecurringCalendarEntry(DateTime start, int length, string displayText, int intFreq, int repeats)
        {
            _start = start;
            _length = length;
            _displayText = displayText;
            if (Enum.IsDefined(typeof(RecurringFrequency), intFreq))
            {
                _frequency = (RecurringFrequency)intFreq;
            }
            _repeats = repeats;
            _datesEntryOccurs = GetDatesEntryOccurs();
            UpdateSavedData();
        }

        private void UpdateSavedData()
        {
            _savedData = _start.ToString("yyyy-MM-dd HH:mm") + '\t' + _length.ToString() + '\t' + _displayText + '\t' + (int)_frequency
                + '\t' + _repeats.ToString();
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
            set
            {
                _savedData = value;
                UpdateSavedData();
            }
        }

        public RecurringFrequency Frequency
        {
            get { return _frequency; }
            set
            {
                _frequency = value;
                UpdateSavedData();
                _datesEntryOccurs = GetDatesEntryOccurs();
            }
        }

        public int Repeats
        {
            get { return _repeats; }
            set
            {
                _repeats = value;
                UpdateSavedData();
                _datesEntryOccurs = GetDatesEntryOccurs();
            }
        }

        public bool OccursOnDate(DateTime date)
        {
            foreach (DateTime entry in _datesEntryOccurs)
            {
                if (DateTime.Compare(date.Date, entry.Date) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private List<DateTime> GetDatesEntryOccurs()
        {
            List<DateTime> dates = new List<DateTime>();

            dates.Add(_start);

            switch (_frequency)
            {
                case RecurringFrequency.Daily:
                    for (int i = 1; i <= _repeats; i++)
                    {
                        dates.Add(_start.AddDays(i));
                    }
                    break;

                case RecurringFrequency.Weekly:
                    for (int i = 1; i <= _repeats; i++)
                    {
                        dates.Add(_start.AddDays(i * 7));
                    }
                    break;

                case RecurringFrequency.Fortnightly:
                    for (int i = 1; i <= _repeats; i++)
                    {
                        dates.Add(_start.AddDays(i * 14));
                    }
                    break;

                case RecurringFrequency.Monthly:
                    for (int i = 1; i <= _repeats; i++)
                    {
                        dates.Add(_start.AddMonths(i));
                    }
                    break;

                case RecurringFrequency.Yearly:
                    for (int i = 1; i <= _repeats; i++)
                    {
                        dates.Add(_start.AddYears(i));
                    }
                    break;
            }

            return dates;
        }
    }
}
