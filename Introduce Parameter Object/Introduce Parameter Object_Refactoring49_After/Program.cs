using System;
using System.Linq;

namespace Solution_IntroduceParameterObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateRange = new DateRange(new DateTime(2025, 1, 1), new DateTime(2025, 1, 31));
            Console.WriteLine("Entries found: " + GetEntriesBetween(dateRange));
        }

        static int GetEntriesBetween(DateRange range)
        {
            // Logic để đếm entries, sử dụng range.Start và range.End
            return 5;
        }
    }

    class DateRange
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public DateRange(DateTime start, DateTime end) { Start = start; End = end; }
    }
}