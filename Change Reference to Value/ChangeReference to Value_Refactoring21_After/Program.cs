using System;

namespace Solution_ChangeReferenceToValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var currency1 = new Currency("VND");
            var currency2 = new Currency("VND");

            bool areSameObject = currency1 == currency2;
            bool areEqualValue = currency1.Equals(currency2);

            Console.WriteLine("Currency objects are the same instance: " + areSameObject);
            Console.WriteLine("Currency objects are equal by value: " + areEqualValue);
        }
    }

    class Currency
    {
        public string Code { get; private set; }
        public Currency(string code) { Code = code; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var other = (Currency)obj;
            return Code == other.Code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }
    }
}