using System;

namespace Problem_RemoveControlFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "An", "Bình", "Kẻ xấu", "Cường" };
            CheckSecurity(people);
        }

        static void CheckSecurity(string[] people)
        {
            bool found = false;
            foreach (var person in people)
            {
                if (!found)
                {
                    if (person.Equals("Kẻ xấu"))
                    {
                        SendAlert();
                        found = true;
                    }
                }
            }
        }
        static void SendAlert() { Console.WriteLine("Alert sent!"); }
    }
}