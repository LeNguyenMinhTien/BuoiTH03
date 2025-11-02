using System;
using System.Linq;

namespace Problem_IntroduceParameterObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2025, 1, 31);
            Console.WriteLine("Entries found: " + GetEntriesBetween(startDate, endDate));
        }

        static int GetEntriesBetween(DateTime startDate, DateTime endDate)
        {
            // Logic để đếm entries
            return 5;
        }
    }
}