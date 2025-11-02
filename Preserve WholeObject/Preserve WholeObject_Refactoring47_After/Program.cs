using System;

namespace Solution_PreserveWholeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var plan = new HeatingPlan(new TempRange(18, 25));
            var roomTempRange = new TempRange(20, 23);

            bool withinPlan = plan.IsWithinRange(roomTempRange);

            Console.WriteLine("Within plan: " + withinPlan);
        }
    }

    class TempRange { public int Low { get; private set; } public int High { get; private set; } public TempRange(int l, int h) { Low = l; High = h; } }
    class HeatingPlan { private TempRange _range; public HeatingPlan(TempRange r) { _range = r; } public bool IsWithinRange(TempRange range) { return range.Low >= _range.Low && range.High <= _range.High; } }
}