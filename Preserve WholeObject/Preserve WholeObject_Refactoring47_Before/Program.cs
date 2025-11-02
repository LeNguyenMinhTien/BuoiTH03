using System;

namespace Problem_PreserveWholeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var plan = new HeatingPlan(new TempRange(18, 25));
            var roomTempRange = new TempRange(20, 23);

            int low = roomTempRange.Low;
            int high = roomTempRange.High;
            bool withinPlan = plan.IsWithinRange(low, high);

            Console.WriteLine("Within plan: " + withinPlan);
        }
    }

    class TempRange { public int Low { get; private set; } public int High { get; private set; } public TempRange(int l, int h) { Low = l; High = h; } }
    class HeatingPlan { private TempRange _range; public HeatingPlan(TempRange r) { _range = r; } public bool IsWithinRange(int low, int high) { return low >= _range.Low && high <= _range.High; } }
}