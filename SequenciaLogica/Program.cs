int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    int y = i * i;
    int y2 = y * i;
    int soma = y + 1;
    int soma2 = y2 + 1;

    Console.WriteLine($"{i} {y} {y2}");
    Console.WriteLine($"{i} {soma} {soma2}");
}