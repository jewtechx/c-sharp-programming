using System;

namespace Calculator {
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.WriteLine("Enter a decimal number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another decimal number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num3 + num4);
        }
    }
}