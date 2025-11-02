using System;

namespace Problem_PullUpConstructorBody
{
    class Program { static void Main(string[] args) { } }

    class Employee
    {
        public string Name { get; protected set; }
        public string Id { get; protected set; }
    }

    class Manager : Employee
    {
        public int Grade { get; private set; }
        public Manager(string name, string id, int grade)
        {
            this.Name = name; // Trùng lặp
            this.Id = id;     // Trùng lặp
            this.Grade = grade;
        }
    }

    class Salesperson : Employee
    {
        public string Department { get; private set; }
        public Salesperson(string name, string id, string department)
        {
            this.Name = name; // Trùng lặp
            this.Id = id;     // Trùng lặp
            this.Department = department;
        }
    }
}