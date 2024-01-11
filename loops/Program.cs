using System;

namespace Loops {
    class Program 
    {
        static void Main(string[] args)
        {
            int index = 0;

            while(index < 7){
                Console.WriteLine(index);
                index++;
            }

            do{
                Console.WriteLine("do while " + index);
            }while(index > 10);

            for(int i = 1; i < 9; i++){
                Console.WriteLine("for loop " + i);
            }

            int [] luckynumbers = {2,4,2,1,4,6,7};
            for(int i = 0; i < luckynumbers.Length; i++){
                Console.WriteLine("lucky numbers " + luckynumbers[i]);
            }

            int [,] myarray = {
                {1,2},
                {3,4},
                {5,6}
            };
                Console.WriteLine("lucky numbers " + myarray[1,0]);

        }
    }
}