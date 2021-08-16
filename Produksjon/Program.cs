using System;

namespace Produksjon
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine($"{person.Navn()}");
            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}