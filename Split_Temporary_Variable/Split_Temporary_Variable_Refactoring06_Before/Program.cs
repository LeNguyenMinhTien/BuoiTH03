using System;

namespace Problem_SplitTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 5);
            rect.DisplayInfo();
        }
    }

    class Rectangle
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public void DisplayInfo()
        {
            double temp = 2 * (_height + _width);
            Console.WriteLine("Perimeter: " + temp);

            temp = _height * _width;
            Console.WriteLine("Area: " + temp);
        }
    }
}