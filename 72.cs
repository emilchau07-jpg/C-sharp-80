//En array med 50 inlästa tal finns. Bestäm och skriv ut index för det sista negativa talet i arrayen. (Tips: Börja bakifrån i arrayen).

static void Uppgift()
{
    int[] numbers = new int[50];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);

        numbers[i] = tal;
    }

    bool sistatal = false;
    int index = 0;

    for (int x = numbers.Length - 1; x >= 0; x--)
    {
        if (numbers[x] < 0)
        {
            sistatal = true;
            index = x;
            break;
        }
    }
    if (sistatal == false)
    {
        Console.WriteLine("Hittade inga negativa tal");
    }
    if (sistatal == true)
    {
        Console.WriteLine($"Sista negativa talet har index: {index}");
    }
}
Uppgift();