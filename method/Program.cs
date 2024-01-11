using System;

namespace Methods {
    class Program 
    {
        static void Main(string[] args)
        {
            string message = SayHi("Jew",18);
            Console.WriteLine(message);
        }

        static string SayHi(string name, int age)
        {
            return "Hello " + name + ". You are " + age + " years";
        }
    }
}