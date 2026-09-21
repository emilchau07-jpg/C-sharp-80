//En array med 50 inlästa tal finns. Beräkna och skriv ut summan av alla positiva tal och summan av alla negativa tal i arrayen.

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
    int negativaTal = 0;

    foreach (int tal in numbers)
    {
        if (tal > 0)
        {
            positivaTal += tal;
        }
        else
        {
            negativaTal += tal;
        }
    }

    Console.WriteLine($"Summan av de positiva talen är: {positivaTal} och summan av de negativa tal är: {negativaTal}");
}
Uppgift();