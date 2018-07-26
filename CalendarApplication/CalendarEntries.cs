using System;
using System.Collections.Generic;
using System.IO;

namespace Calendar
{
    public class CalendarEntries : List<ICalendarEntry>
     {

        public bool Load(string calendarEntriesFile)
        {
            // Load caldendar entrires from persistent storage
            bool status = false;

            try
            {
                using (StreamReader reader = new StreamReader(calendarEntriesFile))
                {
                    string entry;
                    int numParameters;
                    while ((entry = reader.ReadLine()) != null)
                    {
                        if ((numParameters = entry.Split('\t').Length) == 3)
                        {
                            this.Add(new SingleCalendarEntry(entry));
                            status = true;
                        }
                        else if (numParameters == 5)
                        {
                            this.Add(new RecurringCalendarEntry(entry));
                            status = true;
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                status = false;
            }

            return status;
        }

        public bool Save(string calendarEntriesFile)
        {
            // Save entry to persistent storage
            bool status = false;

            using (StreamWriter writer = new StreamWriter(calendarEntriesFile))
            {
                foreach (ICalendarEntry entry in this)
                {
                    writer.WriteLine(entry.SavedData);
                }
                status = true;
            }

            return status;
        }

        public IEnumerable<ICalendarEntry> GetCalendarEntriesOnDate(DateTime date)
        // Iterate through the collection, returning the calendar entries that
        // occur on the specified date
        {
            for (int i = 0; i < this.Count; i++ )
            {
                if (this[i].OccursOnDate(date))
                {
                    yield return this[i];                
                }
            }
        }
    }
}