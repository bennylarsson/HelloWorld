using System;
class Program
{

    static void Main()
    {
        Console.Write("Storlek:");
        int storlek = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= storlek; i++)
        {
            for (int j = 1; j <= storlek - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
}
