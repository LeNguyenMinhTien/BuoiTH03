using System;

namespace Problem_ExtractVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order("Windows", "Chrome", true, 10);
            order.PrintOrderDetails();
        }
    }

    class Order
    {
        private string _platform;
        private string _browser;
        private bool _isInitialized;
        private int _resize;

        public Order(string platform, string browser, bool isInitialized, int resize)
        {
            _platform = platform;
            _browser = browser;
            _isInitialized = isInitialized;
            _resize = resize;
        }

        public void PrintOrderDetails()
        {
            if (_platform.ToUpper().Contains("MAC") &&
                _browser.ToUpper().Contains("IE") &&
                _isInitialized &&
                _resize > 0)
            {
                Console.WriteLine("Đây là đơn hàng đặc biệt.");
            }
            else
            {
                Console.WriteLine("Đây là đơn hàng thông thường.");
            }
        }
    }
}