//53. Skriv en funktion som läser in 10 korrekta tal. Korrekta tal är tal som ligger i området 5000 < n < 10000. Skriv ut summan samt medelvärdet för de korrekta talen.

static void Uppgift()
{
    double summa = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Ange ett korrekt tal: ");
        double tal = double.Parse(Console.ReadLine());
        if (tal > 5000 && tal < 10_000)
        {
            summa += tal;
        }
        else
        {
            Console.WriteLine("Ange ett korrekt tal! (Mellan 5000 och 10000)");
        }
    }
    Console.WriteLine($"Summan av talen är {summa}");
}
Uppgift();