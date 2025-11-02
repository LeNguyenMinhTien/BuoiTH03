using System;

namespace Problem_SeparateQueryFromModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "An", "Bình", "Kẻ xấu", "Nguyễn Văn A" };
            string found = FindAndAlertSuspect(people);
            Console.WriteLine("Found: " + found);
        }

        static string FindAndAlertSuspect(string[] people)
        {
            foreach (var person in people)
            {
                if (person.Equals("Kẻ xấu"))
                {
                    SendAlert();
                    return "Kẻ xấu";
                }
            }
            return "";
        }
        static void SendAlert() { Console.WriteLine("Alert sent!"); }
    }
}