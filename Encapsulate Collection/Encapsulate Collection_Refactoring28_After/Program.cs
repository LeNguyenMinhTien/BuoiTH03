using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Solution_EncapsulateCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.AddCourse(new Course("Math"));
            person.AddCourse(new Course("Science"));

            // person.GetCourses().Clear(); // Dòng này sẽ gây lỗi!
            Console.WriteLine("Course count: " + person.GetCourses().Count);
        }
    }

    class Course { public Course(string name) { } }
    class Person
    {
        private List<Course> _courses = new List<Course>();
        public ReadOnlyCollection<Course> GetCourses()
        {
            return _courses.AsReadOnly();
        }
        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }
        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }
    }
}