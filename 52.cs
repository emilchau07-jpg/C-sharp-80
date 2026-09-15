//52. Skriv en funktion som läser in 100 tal och beräknar och skriver ut summan av de positiva talen.

static void Uppgift()
{
    double summa = 0;
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        double tal = double.Parse(Console.ReadLine());
        if (tal > 0)
        {
            summa += tal;
        }
    }
    Console.WriteLine($"Summan av alla tal blir {summa}");
}
Uppgift();