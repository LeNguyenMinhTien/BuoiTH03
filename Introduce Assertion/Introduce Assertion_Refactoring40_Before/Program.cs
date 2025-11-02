using System;

namespace Problem_IntroduceAssertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Nguyễn Văn A");
            employee.SetExpense(-50); // Lỗi logic không được phát hiện
            Console.WriteLine("Expense set to: " + employee.Expense);
        }
    }

    class Employee
    {
        public string Name { get; private set; }
        public double Expense { get; private set; }
        public Employee(string name) { Name = name; }
        public void SetExpense(double expense)
        {
            // Có một giả định ngầm rằng expense >= 0
            Expense = expense;
        }
    }
}