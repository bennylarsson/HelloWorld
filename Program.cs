Console.Write("Storlek: ");
int storlek = int.Parse(Console.ReadLine());
for (int i = 0; i < storlek; i++)
{
    for (int j = 0; j < storlek; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}