using System;

namespace Conditionals {
    class Program 
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if(isMale && isTall){
                Console.WriteLine("You are a tall male");
            }
            else if(isMale && !isTall){
                Console.WriteLine("You are a short male");
            }
            else if(!isMale && isTall){
                Console.WriteLine("You are not male and you are tall");
            }
            else{
                Console.WriteLine("You are not a tall male");
            }

            switch(isMale){
                case true:
                Console.WriteLine("You are a tall male");
                break;
                default:
                Console.WriteLine("You are not a tall male");
                break;

                     
            }
        }
    }
}