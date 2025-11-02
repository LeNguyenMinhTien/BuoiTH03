using System;

namespace Problem_ExtractSubclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var labor = new JobItem(10, 0, 50, true);
            var part = new JobItem(10, 5, 0, false);
            Console.WriteLine("Labor Total: " + labor.GetTotalPrice());
            Console.WriteLine("Part Total: " + part.GetTotalPrice());
        }
    }
    class JobItem
    {
        private int _quantity;
        private int _unitPrice;
        private int _employeeRate;
        private bool _isLabor;
        public JobItem(int qty, int unitPrice, int empRate, bool isLabor)
        {
            _quantity = qty; _unitPrice = unitPrice; _employeeRate = empRate; _isLabor = isLabor;
        }
        public int GetTotalPrice()
        {
            if (_isLabor)
                return _quantity * _employeeRate;
            else
                return _quantity * _unitPrice;
        }
    }
}