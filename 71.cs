//En array med 50 inlästa tal finns. Ta reda på och skriv ut hur många tal som är större än det första talet.

static void Uppgift()
{
    int[] numbers = new int[50];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);

        numbers[i] = tal;
    }

    int ForstaTal = numbers[0];
    int biggernumber = 0;

    for (int x = 1; x < numbers.Length; x++)
    {
        if (numbers[x] > ForstaTal)
        {
            biggernumber++;
        }
    }
    Console.WriteLine($"Första talet är {ForstaTal} och {biggernumber} tal är större än första talet.");
}
Uppgift();