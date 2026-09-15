Console.Write("Siffra : ");
int siffra = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} * {siffra} = {i * siffra}");
}