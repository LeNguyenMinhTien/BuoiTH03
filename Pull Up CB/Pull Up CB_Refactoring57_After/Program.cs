using System;

namespace Solution_PullUpConstructorBody
{
    class Program { static void Main(string[] args) { } }

    class Employee
    {
        public string Name { get; protected set; }
        public string Id { get; protected set; }

        public Employee(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }
    }

    class Manager : Employee
    {
        public int Grade { get; private set; }
        public Manager(string name, string id, int grade) : base(name, id)
        {
            this.Grade = grade;
        }
    }

    class Salesperson : Employee
    {
        public string Department { get; private set; }
        public Salesperson(string name, string id, string department) : base(name, id)
        {
            this.Department = department;
        }
    }
}