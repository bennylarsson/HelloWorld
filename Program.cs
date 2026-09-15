using System;

class Program
{
    static void Main()
    {
        // Ber användaren om ett nummer
        Console.Write("Nummer: ");

        // Läser in svaret som en sträng och omvandlar (parsar) det till ett heltal
        int nummer = int.Parse(Console.ReadLine());

        // Kontrollerar om tal2et är jämnt eller ojämnt med hjälp av modulo (%)
        if (nummer % 2 == 0)
        {
            Console.WriteLine($"{nummer} är jämnt");
        }
        else
        {
            Console.WriteLine($"{nummer} är ojämnt");
        }
    }
}