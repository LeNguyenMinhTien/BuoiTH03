using System;
using System.Diagnostics;

namespace Solution_IntroduceAssertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Nguyễn Văn A");
            employee.SetExpense(-50); // Sẽ gây lỗi Assert khi chạy ở chế độ Debug
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
            Debug.Assert(expense >= 0);
            Expense = expense;
        }
    }
}