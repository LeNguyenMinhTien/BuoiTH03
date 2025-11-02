using System;

namespace Solution_ExtractSubclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var labor = new LaborItem(10, 50);
            var part = new PartsItem(10, 5);
            Console.WriteLine("Labor Total: " + labor.GetTotalPrice());
            Console.WriteLine("Part Total: " + part.GetTotalPrice());
        }
    }

    abstract class JobItem
    {
        protected int _quantity;
        public JobItem(int quantity) { _quantity = quantity; }
        public abstract int GetTotalPrice();
    }
    class LaborItem : JobItem
    {
        private int _employeeRate;
        public LaborItem(int qty, int empRate) : base(qty) { _employeeRate = empRate; }
        public override int GetTotalPrice() { return _quantity * _employeeRate; }
    }
    class PartsItem : JobItem
    {
        private int _unitPrice;
        public PartsItem(int qty, int unitPrice) : base(qty) { _unitPrice = unitPrice; }
        public override int GetTotalPrice() { return _quantity * _unitPrice; }
    }
}