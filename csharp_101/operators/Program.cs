using System;

namespace operators
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

            // Fiziksel operatörler
            // <, >, >=, <=, ==, !=
            Console.WriteLine("\n--> Relational Operators");
            int f1 = 5;
            int f2 = 8;
            bool sonuc=f1<f2;

            Console.WriteLine(sonuc);
            sonuc=f1>f2;
            Console.WriteLine(sonuc);
            sonuc=f1>=f2;
            Console.WriteLine(sonuc);
            sonuc=f1<=f2;
            Console.WriteLine(sonuc);
            sonuc=f1==f2;
            Console.WriteLine(sonuc);
            sonuc=f1!=f2;
            Console.WriteLine(sonuc);
            


            //Aritmetik O.
            // +,-,*,/
            Console.WriteLine("--> Arithmatics Operators");

            int sayi1= 10;
            int sayi2= 20;
            int sSonuc= sayi1/sayi2;
            Console.WriteLine(sSonuc);

            sSonuc= sayi1+sayi2;
            Console.WriteLine(sSonuc);
            sSonuc= sayi1*sayi2;
            Console.WriteLine(sSonuc);
            sSonuc= sayi1++;
            Console.WriteLine(sayi1);

            // Mod alır
            int sSonuc1 = 20%3;
            
            Console.WriteLine(sSonuc1);
            Console.ReadLine();


            


             
             
        }
    }
}
