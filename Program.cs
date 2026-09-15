Console.WriteLine("Storlek: ");
int storlek = int.Parse(Console.ReadLine());

for (int nuvarandestorlek = 1; nuvarandestorlek <= storlek; nuvarandestorlek++)
{
    for (int i = 0; i < nuvarandestorlek; i++)
    {
        for (int j = 0; j < nuvarandestorlek; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}