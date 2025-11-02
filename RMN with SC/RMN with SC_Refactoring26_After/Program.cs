using System;

namespace Solution_SymbolicConstant
{
    class Program
    {
        private const double GRAVITATIONAL_CONSTANT = 9.81;

        static void Main(string[] args)
        {
            Console.WriteLine("Energy: " + CalculateEnergy(10));
        }

        static double CalculateEnergy(double mass)
        {
            return mass * GRAVITATIONAL_CONSTANT;
        }
    }
}