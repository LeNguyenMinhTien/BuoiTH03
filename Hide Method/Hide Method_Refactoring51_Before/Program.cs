using System;

namespace Problem_HideMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new Report();
            // Client có thể gọi một phương thức không dành cho họ
            string header = report.GetHeader();
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

        public string GetHeader()
        {
            return "--- REPORT HEADER ---";
        }
    }
}