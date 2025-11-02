using System;

namespace Problem_ReplaceArrayWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] row = new string[2];
            row[0] = "Liverpool";
            row[1] = "15";

            string name = row[0];
            int wins = int.Parse(row[1]);

            Console.WriteLine(name + " won " + wins + " games.");
        }
    }
}