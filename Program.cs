using System;

namespace Oving1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Läser in förnamnet
            Console.Write("Vad är ditt förnamn: ");
            string fornamn = Console.ReadLine();
            //Läser in efternamn
            Console.Write("Vad är ditt efternamn: ");
            string efternamn = Console.ReadLine();
            //Hälsar
            Console.WriteLine("Hej " + fornamn + " " + efternamn + "!");
            //Frågar hur man mår
            Console.Write("Hur mår du idag ? ");
            string mår = Console.ReadLine();
            //Frågar efter ålder
            Console.Write("Hur gammal är du ? ");
            string inputAlder = Console.ReadLine();
            int alder = int.Parse(inputAlder);
            // Kollar på ett cirka hur gammal du är..
            int dagar = alder * 365;
            Console.WriteLine("Du har levt i cirka " + dagar + " dagar.");
            Console.ReadLine();
        }
    }
}
