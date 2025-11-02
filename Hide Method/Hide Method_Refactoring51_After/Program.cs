using System;

namespace Solution_HideMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new Report();
            // string header = report.GetHeader(); // Dòng này sẽ gây lỗi biên dịch!
            Console.WriteLine(report.CreateReport());
        }
    }

    class Report
    {
        public string CreateReport()
        {
            string header = GetHeader();
            return header + "\nReport Body...";
        }

        private string GetHeader()
        {
            return "--- REPORT HEADER ---";
        }
    }
}