using System;
using System.Collections.Generic;

namespace Problem_ReplaceDelegationWithInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var vector = new Vector();
            vector.Add(1);
            vector.Add(2);
            Console.WriteLine("Count: " + vector.Count);
        }
    }

    class Vector
    {
        private List<int> _list = new List<int>();
        public void Add(int item) { _list.Add(item); }
        public bool Remove(int item) { return _list.Remove(item); }
        public int Count { get { return _list.Count; } }
    }
}