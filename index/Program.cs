using System;
// using System;
// using System;
// using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            // variables

            string characterName = "Jew";
            int characterAge;
            characterAge = 18;

            Console.WriteLine("There was a man named " + characterName);
            Console.WriteLine("He is " + characterAge + " old");

            characterName = "Larbi";
            Console.WriteLine("He loves his name " + characterName);

            // data types
            string name = "Jew";
            int age = 18;
            char grade = 'A';
            bool dating = true;
            decimal networth = 9999999999999;
            Console.WriteLine("My name is " + name + ". I am an " + age + " years old grade " + grade + " student. My net worth is " + networth);

            // strings
            string test = "I am coding";
            Console.WriteLine(test.Length);
            Console.WriteLine(test.ToUpper());
            Console.WriteLine(test.Contains("am"));
            Console.WriteLine(test[0]);
            Console.WriteLine(test.IndexOf("c"));
            Console.WriteLine(test.Substring(3,3));
        }
    }
}
