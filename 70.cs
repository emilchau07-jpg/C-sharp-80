//En array med 50 inlästa tal finns. Ta reda på och skriv ut hur många tal som är positiva.

static void Uppgift()
{
    int[] numbers = new int[50];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);
        numbers[i] = tal;
    }

    int positivaTal = 0;

    for (int x = 0; x < numbers.Length; x++)
    {
        if (numbers[x] > 0)
        {
            positivaTal++;
        }
    }
    Console.WriteLine($"Du angav {positivaTal} positiva tal");
}
Uppgift();