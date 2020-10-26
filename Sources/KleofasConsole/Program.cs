using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ja jestem Kleofas, Twoj osobisty robot. Jak sie nazywasz?");
            var imie = Console.ReadLine();
            Console.WriteLine("Czesc " + imie + " , czy dzisiaj jest wtorek?");
            var odp1 = Console.ReadKey();
            Console.WriteLine("");

            if (odp1.KeyChar.Equals('n') || odp1.KeyChar.Equals('N'))
            {
                Console.WriteLine(imie + " zgadza sie!");
            }
            else
            {
                Console.WriteLine(" nie zgadza sie");
            }
            Console.ReadLine();
            Console.WriteLine("pa pa");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
