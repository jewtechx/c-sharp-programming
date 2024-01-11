using System;

namespace Arrays {
    class Program 
    {
        static void Main(string[] args)
        {
            int [] arrayNumbers = {1,2,3,4,5};
            Console.WriteLine(arrayNumbers[0]);

            string[] nameArryay = new string[5];
            nameArryay[0] = "Jew";
            nameArryay[1] = "Larbi";
            nameArryay[2] = "Danquah";

            Console.WriteLine(nameArryay[0]);
        }
    }
}