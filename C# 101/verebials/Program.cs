using System;

namespace C__101
{
    class Program
    {
        static void Main(string[] args)
        {
            string tarih = DateTime.Now.ToString("dd.MM.yyyy");
            string saat = DateTime.Now.ToString("HH:mm");

            Console.WriteLine("-> Selam! Ben Oti! Bana ismini söyler misin?");
            string name = Console.ReadLine();
            Console.WriteLine("--------");
            Console.WriteLine("-> Hoşgeldin, " + name + "!");
            Console.WriteLine("- Tarih: " + tarih + "\n- Saat: "+ saat);
            Console.WriteLine("--------");
        }
    }
}
