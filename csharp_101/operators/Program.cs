using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int b = 5;
            b +=5;
            Console.WriteLine(b);
            b /=2;
            Console.WriteLine(b);

            // || (veya), && (ve), ! (değilse) Mantıksal oparetörler

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

            // Fiziksel operatörler
            // <, >, >=, <=, ==, !=

            int f1 = 5;
            int f2 = 8;

             
             
        }
    }
}
