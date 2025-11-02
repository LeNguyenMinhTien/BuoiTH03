using System;
using System.Collections.Generic;

namespace Solution_ReplaceInheritanceWithDelegation
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack();
            stack.Push("A");
            stack.Push("B");

            // stack.Insert(0, "phá vỡ logic"); // Dòng này sẽ gây lỗi biên dịch!
        }
    }
    class MyStack
    {
        private List<string> _list = new List<string>();

        public void Push(string item)
        {
            _list.Add(item);
        }

        public string Pop()
        {
            var last = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return last;
        }
    }
}