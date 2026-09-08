//Skriv en funktion som läser in ett pris exkl moms och skriver ut priset inkl 25 % moms. Inläsningen ska pågå tills 0 anges.

WholePrice();

static double AskPriceNoMoms()
{
    Console.WriteLine("Ange priset utan moms (0 för att avsluta): ");
    return double.Parse(Console.ReadLine());
}

static void WholePrice()
{
    double utanmoms = AskPriceNoMoms();

    while (utanmoms != 0)
    {
        double WithMoms = utanmoms + (utanmoms * 0.25);
        Console.WriteLine($"Priset med moms är {WithMoms}");

        utanmoms = AskPriceNoMoms();
    }
}
