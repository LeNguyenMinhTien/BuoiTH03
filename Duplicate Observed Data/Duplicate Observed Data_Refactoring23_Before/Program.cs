using System;

namespace Problem_DuplicateObservedData
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new IntervalForm();
            form.StartField = "10";
            form.EndField = "25";
            form.CalculateLength();
            Console.WriteLine("Length: " + form.LengthField);
        }
    }

    class IntervalForm
    {
        public string StartField { get; set; }
        public string EndField { get; set; }
        public string LengthField { get; set; }

        public void CalculateLength()
        {
            int start = int.Parse(StartField);
            int end = int.Parse(EndField);
            int length = end - start;
            LengthField = length.ToString();
        }
    }
}