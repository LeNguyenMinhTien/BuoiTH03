using System;
using System.Linq;

namespace Solution_SubstituteAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "An", "Bình", "Nguyễn Văn A", "Cường" };
            PersonFinder finder = new PersonFinder();
            Console.WriteLine("Found: ".PadRight(12) + finder.FindPerson(people));
        }
    }

    class PersonFinder
    {
        public string FindPerson(string[] people)
        {
            string[] candidates = { "An", "Bình", "Dũng" };
            foreach (var person in people)
            {
                if (candidates.Contains(person))
                {
                    return person;
                }
            }
            return "";
        }
    }
}