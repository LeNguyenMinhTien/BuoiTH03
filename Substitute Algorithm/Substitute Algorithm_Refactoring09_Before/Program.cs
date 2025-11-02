using System;

namespace Problem_SubstituteAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "An", "Bình", "Nguyễn Văn A", "Cường" };
            PersonFinder finder = new PersonFinder();
            Console.WriteLine("Found: " + finder.FindPerson(people));
        }
    }

    class PersonFinder
    {
        public string FindPerson(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("An"))
                {
                    return "An";
                }
                if (people[i].Equals("Bình"))
                {
                    return "Bình";
                }
            }
            return "";
        }
    }
}