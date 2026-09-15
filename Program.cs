using System;

class Program
{
    static void Main()
    {
        Console.Write("Modulus: ");
        int modulus = int.Parse(Console.ReadLine());

        Console.Write("Från: ");
        int franTal = int.Parse(Console.ReadLine());

        Console.Write("Till: ");
        int tillTal = int.Parse(Console.ReadLine());

        for (int i = franTal; i <= tillTal; i++)
        {
            int resultat = i % modulus;
            Console.WriteLine($"{i} % {modulus} = {resultat}");
        }
    }
}