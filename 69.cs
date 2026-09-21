//En array med 50 inlästa tal finns. Addera talet 2 till talen på indexplats 0, 2, 4,… i arrayen.

static void Uppgift()
{
    int[] tal = new int[50];

    for (int i = 0; i < tal.Length; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int siffra = int.Parse(Console.ReadLine()!);
        tal[i] = siffra;
    }

    for (int x = 0; x < tal.Length; x += 2)
    {
        tal[x] = tal[x] += 2;
    }
    foreach (int number in tal)
    {
        Console.WriteLine(number + " ");
    }
}
Uppgift();