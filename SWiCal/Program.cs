using Ical.Net;
using Ical.Net.DataTypes;
using System;

namespace SWiCal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            var now = DateTime.Now;
            var later = now.AddDays(1);

            //repeat for 3 days
            var rrule = new RecurrencePattern(FrequencyType.Daily, 1) { Count = 3 };
        }
    }
}
