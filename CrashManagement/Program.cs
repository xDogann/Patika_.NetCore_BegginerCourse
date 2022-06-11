using System;

namespace CrashManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n--> Assignment and Operational Assignment Operators");

            int b = 5;
            b +=5;
            Console.WriteLine(b);
            b /=2;
            Console.WriteLine(b);


            // || (veya), && (ve), ! (değilse) Mantıksal oparetörler
            Console.WriteLine("\n--> Logical Operators");

            bool isSuccess = true;
            bool isComplated = false;

            if(isSuccess && isComplated)
            {
                Console.WriteLine("Nice!");
            } 
            if(isSuccess && !isComplated)
            {
                Console.WriteLine("Perfect!");
            } 
            if(isSuccess || isComplated)
            {
                Console.WriteLine("Amazing!");
            } 

             
        }
    }
}
