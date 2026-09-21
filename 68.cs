//En array med 50 inlästa tal finns. Fördubbla värdet på talen på varje plats i arrayen.

static void Uppgift()
{
    int[] tal = new int[50];

    for (int i = 0; i < tal.Length; i++)
    {
        Console.WriteLine("Ange ett tal:  ");
        int number = int.Parse(Console.ReadLine()!);

        tal[i] = number;
    }
    for (int x = 0; x < tal.Length; x++)
    {
        tal[x] = tal[x] * 2;
    }
    foreach (int tecken in tal)
    {
        Console.Write(tecken + " ");
    }
}
Uppgift();