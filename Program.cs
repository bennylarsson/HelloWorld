using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("storlek: ");
        int storlek = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= storlek; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}