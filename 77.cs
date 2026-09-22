//Skriv en funktion som läser in 10 heltal till en array och sedan skriver ut talen baklänges. Endast en array ska användas.

static void Uppgift()
{
    int[] numbers = new int[10];

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);

        numbers[i] = tal;
    }

    foreach (int tal in numbers)
    {
        Console.Write(tal + " ");
    }
}
Uppgift();