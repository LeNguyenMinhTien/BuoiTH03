using System;

namespace Solution_ExtractVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order("Windows", "Chrome", true, 10);
            order.PrintOrderDetails();

            // Khách hàng mới
            Customer customer = new Customer("Nguyễn Văn A");
            customer.DoSomething();
        }
    }

    // Class mới sử dụng tên theo yêu cầu
    class Customer
    {
        private string _name;
        public Customer(string name)
        {
            _name = name;
        }
        public void DoSomething()
        {
            Console.WriteLine("Khách hàng: " + _name);
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
            bool isMac = _platform.ToUpper().Contains("MAC");
            bool isIE = _browser.ToUpper().Contains("IE");
            bool wasResized = _resize > 0;

            if (isMac && isIE && _isInitialized && wasResized)
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