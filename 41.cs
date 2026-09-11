//41. Skriv en funktion som skriver ut summan av talen 1 till 50

static void SkrivUtSumma()
{
    int Total = 0;
    for (int i = -1; i < 50; i++)
    {
        Total = Total + i;
    }
    Console.WriteLine($"{Total}");
}
SkrivUtSumma();