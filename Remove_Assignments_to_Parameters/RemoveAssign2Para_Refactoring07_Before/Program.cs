using System;

namespace Problem_RemoveAssignmentsToParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceCalculator calculator = new PriceCalculator();
            int finalPrice = calculator.Discount(100);
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }

    class PriceCalculator
    {
        public int Discount(int inputValue)
        {
            if (inputValue > 50)
            {
                inputValue = inputValue - 10;
            }
            return inputValue;
        }
    }
}