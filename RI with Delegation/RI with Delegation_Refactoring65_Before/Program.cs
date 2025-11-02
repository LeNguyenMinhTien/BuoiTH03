using System;
using System.Collections.Generic;

namespace Problem_ReplaceInheritanceWithDelegation
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack();
            stack.Push("A");
            stack.Push("B");

            // Client có thể phá vỡ logic của Stack bằng cách gọi phương thức của List
            stack.Insert(0, "phá vỡ logic");
        }
    }
    class MyStack : List<string>
    {
        public void Push(string item)
        {
            this.Add(item);
        }
        public string Pop()
        {
            var last = this[this.Count - 1];
            this.RemoveAt(this.Count - 1);
            return last;
        }
    }
}