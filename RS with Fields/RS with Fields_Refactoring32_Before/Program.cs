using System;

namespace Problem_ReplaceSubclassWithFields
{
    class Program
    {
        static void Main(string[] args)
        {
            var male = new Male();
            var female = new Female();
            Console.WriteLine("Male code: " + male.GetCode());
            Console.WriteLine("Female code: " + female.GetCode());
        }
    }

    abstract class Person
    {
        public abstract string GetCode();
    }

    class Male : Person
    {
        public override string GetCode() { return "M"; }
    }

    class Female : Person
    {
        public override string GetCode() { return "F"; }
    }
}