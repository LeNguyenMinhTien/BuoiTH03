using System;
using System.Collections.Generic;

namespace Solution_ReplaceDelegationWithInheritance
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

    class Vector : List<int>
    {
        // Lớp này giờ đây trống rỗng vì nó thừa hưởng mọi thứ từ List<int>
    }
}