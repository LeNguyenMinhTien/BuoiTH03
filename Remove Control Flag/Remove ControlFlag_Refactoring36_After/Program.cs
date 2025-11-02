using System;

namespace Solution_RemoveControlFlag
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
            foreach (var person in people)
            {
                if (person.Equals("Kẻ xấu"))
                {
                    SendAlert();
                    break;
                }
            }
        }
        static void SendAlert() { Console.WriteLine("Alert sent!"); }
    }
}