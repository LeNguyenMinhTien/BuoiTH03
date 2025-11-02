using System;
using System.Collections.Generic;

namespace Problem_EncapsulateCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Courses.Add(new Course("Math"));
            person.Courses.Add(new Course("Science"));

            person.Courses.Clear(); // Client tự ý xóa dữ liệu
            Console.WriteLine("Course count: " + person.Courses.Count);
        }
    }

    class Course { public Course(string name) { } }
    class Person
    {
        public List<Course> Courses { get; set; }
        public Person() { Courses = new List<Course>(); }
    }
}