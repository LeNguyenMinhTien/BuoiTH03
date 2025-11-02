using System;

namespace Solution_SplitTemp
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
            double perimeter = 2 * (_height + _width);
            Console.WriteLine("Perimeter: " + perimeter);

            double area = _height * _width;
            Console.WriteLine("Area: " + area);
        }
    }
}