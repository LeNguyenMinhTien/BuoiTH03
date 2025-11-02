using System;

namespace Solution_DuplicateObservedData
{
    class Program
    {
        static void Main(string[] args)
        {
            var interval = new Interval();
            var form = new IntervalForm(interval); // Form "quan sát" interval

            interval.SetStart(10);
            interval.SetEnd(25);
            interval.CalculateLength();

            Console.WriteLine("Length: " + form.LengthField);
        }
    }

    class Interval
    {
        private int _start, _end, _length;
        private IntervalForm _observer;
        public void AddObserver(IntervalForm observer) { _observer = observer; }
        public void SetStart(int val) { _start = val; _observer.Update(); }
        public void SetEnd(int val) { _end = val; _observer.Update(); }
        public int GetStart() { return _start; }
        public int GetEnd() { return _end; }
        public int GetLength() { return _length; }
        public void CalculateLength() { _length = _end - _start; _observer.Update(); }
    }

    class IntervalForm
    {
        private Interval _subject;
        public string StartField { get; set; }
        public string EndField { get; set; }
        public string LengthField { get; set; }
        public IntervalForm(Interval subject) { _subject = subject; _subject.AddObserver(this); }
        public void Update()
        {
            StartField = _subject.GetStart().ToString();
            EndField = _subject.GetEnd().ToString();
            LengthField = _subject.GetLength().ToString();
        }
    }
}