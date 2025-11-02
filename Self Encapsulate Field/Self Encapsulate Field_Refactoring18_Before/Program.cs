using System;

namespace Problem_SelfEncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = new IntRange(10, 20);
            Console.WriteLine("Includes 15: " + range.Includes(15));
            Console.WriteLine("Includes 25: " + range.Includes(25));
        }
    }

    class IntRange
    {
        private int _low, _high;

        public IntRange(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public bool Includes(int arg)
        {
            return arg >= _low && arg <= _high;
        }
    }
}