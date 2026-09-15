//54. Skriv en funktion som läser in 100 heltal. Skriv ut hur många tal som är positiva och hur många som är negativa av de inlästa talen.

static void Uppgift()
{
    int negativatal = 0;
    int positivatal = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Ange ett heltal: ");
        int tal = int.Parse(Console.ReadLine());
        if (tal < 0)
        {
            negativatal++;
        }
        else
        {
            positivatal++;
        }
    }
    Console.WriteLine($"Antal posetiva tal: {positivatal}\nAntal negativa tal: {negativatal}");
}
Uppgift();