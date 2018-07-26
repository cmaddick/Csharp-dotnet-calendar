using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    // Testing class

    public class DataValidator
    {
        List<string> _errorMessages = new List<string>();
        DateTime _startDateTime;
        string _startTime;
        int _length;
        int _intFreq;
        int _repeats;

        public DataValidator(string startTime, int length)
        {
            _startTime = startTime;
            _length = length;
        }

        public DataValidator(string startTime, int length, int intFreq, int repeats)
        {
            _startTime = startTime;
            _length = length;
            _intFreq = intFreq;
            _repeats = repeats;
        }

        public bool RunSingleEntryTests()
        {
            _errorMessages.Clear();
            bool result = CheckStartTime() && CheckLength();
            return result;
        }

        public bool RunRecurringEntryTests()
        {
            _errorMessages.Clear();
            bool result = CheckStartTime() && CheckLength() && CheckFreq() && CheckRepeats();
            return result;
        }

        private bool CheckStartTime()
        {
            try
            {
                _startDateTime = DateTime.ParseExact(_startTime, "yyyy-MM-dd HH:mm", null);
            }
            catch (FormatException e)
            {
                _errorMessages.Add("FormatException: Datetime is invalid.");
                return false;
            }

            return true;
        }

        private bool CheckLength()
        {
            if (!(_length % 30 == 0))
            {
                _errorMessages.Add("Length is not a multiple of 30.");
                return false;
            }

            if (_length >= (1440 - (_startDateTime.Hour * 60 + _startDateTime.Minute)))
            {
                _errorMessages.Add("Length must be short enough to end on the same day it starts");
                return false;
            }

            return true;
        }

        private bool CheckFreq()
        {
            if (!Enum.IsDefined(typeof(RecurringFrequency), _intFreq))
            {
                _errorMessages.Add("Tried to load invalid recurring frequency");
                return false;
            }

            return true;
        }

        private bool CheckRepeats()
        {
            if (!(_repeats >= 1 && _repeats <= 999))
            {
                _errorMessages.Add("Number of repeats has to be between 1 and 999 inclusive");
                return false;
            }

            return true;
        }

        public List<string> ErrorMessages
        {
            get { return _errorMessages; }
            set { _errorMessages = value; }
        }
    }
}
