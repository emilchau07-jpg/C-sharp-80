//60. Skriv en funktion där indata består av en följd av positiva heltal. Avbryt inläsningen med 0. Beräkna antalet gånger två intilliggande tal är lika.

static void Uppgift()
{
    List<int> numbers = [];

    while (true)
    {
        Console.WriteLine("(0 stoppar programmet)\nAnge ett heltal: ");
        int tal = int.Parse(Console.ReadLine());

        if (tal == 0)
        {
            break;
        }

        numbers.Add(tal);

    }

    int lika = 0;

    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] == numbers[i - 1])
        {
            lika++;
        }
    }
    Console.WriteLine($"Dessa talen som är bredvid varandra är lika: {lika}");
}
Uppgift();