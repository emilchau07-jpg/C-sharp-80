//I en array finns ett personnummer. Skriv en funktion som kontrollerar att födelsedatum och de fyra sista siffrorna åtskiljs av ett bindestreck. Skriv ut ett felmeddelande om så ej är fallet.

static void Uppgift()
{
    Console.WriteLine("Ange ditt personer, glöm inte bindestrecket");
    string input = Console.ReadLine();

    char[] ssc = input.ToCharArray();

    if (ssc[6] != '-')
    {
        Console.WriteLine("Du glömde bindestrecket...");
    }

    foreach (char tecken in ssc)
    {
        Console.Write(tecken + " ");
    }
}
Uppgift();