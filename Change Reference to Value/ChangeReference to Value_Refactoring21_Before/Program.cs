using System;
using System.Collections.Generic;

namespace Problem_ChangeReferenceToValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var currency1 = Currency.Get("VND");
            var currency2 = Currency.Get("VND");

            bool areSameObject = currency1 == currency2;
            Console.WriteLine("Currency objects are the same instance: " + areSameObject);
        }
    }

    class Currency
    {
        private static Dictionary<string, Currency> _instances = new Dictionary<string, Currency>();
        public string Code { get; private set; }
        private Currency(string code) { Code = code; }

        public static Currency Get(string code)
        {
            if (!_instances.ContainsKey(code))
            {
                _instances[code] = new Currency(code);
            }
            return _instances[code];
        }
    }
}