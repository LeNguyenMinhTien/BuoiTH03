using System;

namespace Solution_IntroduceNullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var siteWithCustomer = new Site(new RealCustomer("Nguyễn Văn A"));
            var siteWithoutCustomer = new Site(null);

            string name1 = siteWithCustomer.Customer.Name;
            string name2 = siteWithoutCustomer.Customer.Name;

            Console.WriteLine("Name 1: " + name1);
            Console.WriteLine("Name 2: " + name2);
        }
    }

    class Site { public AbstractCustomer Customer { get; private set; } public Site(AbstractCustomer customer) { Customer = customer ?? new NullCustomer(); } }
    abstract class AbstractCustomer { public abstract string Name { get; } }
    class RealCustomer : AbstractCustomer { private string _name; public RealCustomer(string name) { _name = name; } public override string Name { get { return _name; } } }
    class NullCustomer : AbstractCustomer { public override string Name { get { return "occupant"; } } }
}