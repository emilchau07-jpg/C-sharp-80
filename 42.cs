//42. Skriv en funktion som läser in och adderar tjugo heltal. Summan ska skrivas ut.

static void BeraknaSumma()
{
    int summa = 0;
    int number;
    for (int i = 0; i < 20; i++)
    {
        Console.Write("Ange ett heltal: ");
        string? input = Console.ReadLine();

        while (!int.TryParse(input, out number))
        {
            Console.Write("Det där var inget heltal — försök igen: ");
            input = Console.ReadLine();
        }
        summa = summa + number;
    }
    Console.WriteLine($"Totala summan blir {summa}");
}
BeraknaSumma();