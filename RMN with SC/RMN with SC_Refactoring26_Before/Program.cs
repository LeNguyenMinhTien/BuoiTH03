using System;

namespace Problem_MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Energy: " + CalculateEnergy(10));
        }

        static double CalculateEnergy(double mass)
        {
            return mass * 9.81;
        }
    }
}