//44. Skriv en funktion som låter användaren bestämma hur många tal han vill summera. Läs in detta antal tal och summera dem Skriv ut summan.

static void BeraknaSumma()
{
    Console.WriteLine("Hur många tal vill du läsa in (heltal)? ");
    string? antal = Console.ReadLine();

    int antal2;
    while (!int.TryParse(antal, out antal2))
    {
        Console.WriteLine("Det där är inget heltal...\n Testa igen: ");
        antal = Console.ReadLine();
    }

    double summa = 0;
    for (int i = 0; i < antal2; i++)
    {
        Console.WriteLine("Ange ett vill du addera: ");
        double tal = int.Parse(Console.ReadLine());
        summa += tal;
    }
    Console.WriteLine($"Summan av alla tal är : {summa}");
}
BeraknaSumma();