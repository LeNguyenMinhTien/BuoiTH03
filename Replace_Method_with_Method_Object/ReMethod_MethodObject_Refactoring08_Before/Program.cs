using System;

namespace Problem_ReplaceMethodWithMethodObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            Console.WriteLine("Total Price: " + order.CalculatePrice().ToString("C"));
        }
    }

    class Order
    {
        // Giả sử có nhiều thuộc tính phức tạp khác ở đây
        public double PrimaryValue { get { return 100; } }
        public double SecondaryValue { get { return 20; } }
        public int Level { get { return 3; } }

        public double CalculatePrice()
        {
            double primaryBasePrice;
            double secondaryBasePrice;
            double tertiaryBasePrice;

            primaryBasePrice = this.PrimaryValue * 0.8;
            secondaryBasePrice = this.SecondaryValue * 0.7;
            if (this.Level > 2)
            {
                tertiaryBasePrice = primaryBasePrice * 0.5;
            }
            else
            {
                tertiaryBasePrice = secondaryBasePrice * 0.9;
            }

            return primaryBasePrice + secondaryBasePrice + tertiaryBasePrice;
        }
    }
}