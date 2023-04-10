using System;

namespace Homework
{
    internal class Program
    {
        static void Task4() //Задание 4
        {
            Console.WriteLine("Class Website");
            Website site = new Website("Campster", "https://www.thecampster.com/", "Interactive platform for online learning", "104.26.11.102");
            Console.WriteLine(site);
            Console.WriteLine("\n");
        }
        static void Task5() //Задание 5
        { 
            Console.WriteLine("Class Journal");
            Journal journal = new Journal("Local History", 2020, "Online journal about the past and the future of Ukraine", "096-126-87-26", "lochist.mag@gmail.com");
            Console.WriteLine(journal);
            Console.WriteLine("\n");
        }
        static void Task6() //Задание 6
        {
            Console.WriteLine("Class Store");
            Store store = new Store("Silpo", "Liustdorfska doroha, 54", "Food store", "0-800-301-707", "program@silpo.ua");
            Console.WriteLine(store);
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Task4();
            Task5();
            Task6();
        }
    }
}
