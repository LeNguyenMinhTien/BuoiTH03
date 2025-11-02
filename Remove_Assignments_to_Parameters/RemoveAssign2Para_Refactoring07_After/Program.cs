using System;

namespace Solution_RemoveAssignmentsToParameters
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
            int result = inputValue;
            if (result > 50)
            {
                result = result - 10;
            }
            return result;
        }
    }
}