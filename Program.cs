using System;

class Program
{
    static void Main()
    {
        Console.Write("Modulus: ");
        int modulus = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 20; i++)
        {
            int result = i % modulus;
            Console.WriteLine($"{i} % {modulus} = {result}");
        }
    }
}   