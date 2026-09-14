// 50. Skriv en funktion som skriver ut multiplikationstabellen för ettans till nians tabell.

static void BeraknaFunktion()
{
    int summa = 0;

    for (int i = 0; i < 10; i++)
    {
        for (int x = 0; x < 11; x++)
        {
            summa = i * x;
            Console.WriteLine($"{summa}");
        }
    }
}
BeraknaFunktion();