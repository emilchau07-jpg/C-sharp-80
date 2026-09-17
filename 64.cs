//64. Skriv en funktion som läser in 10 positiva tal och bestämmer vilket tal som är störst och vilket som är näst störst. Utnyttja två variabler big och nextbig där de största och det näst största av de hittills lästa talen finns.

static void Uppgift()
{
    List<int> numbers = [];
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Ange ett posetivt heltal: ");
        int tal = int.Parse(Console.ReadLine()!);
        numbers.Add(tal);
    }
    numbers.Sort();
    int big = numbers[9];
    int nextbig = numbers[8];

    Console.WriteLine($"Största talet är {big} och näst störst är {nextbig}");
}
Uppgift();