//Skriv en funktion som räknar ut hur mycket man har på banken under vart och ett av de följande 10 åren om man sätter in 1000 kr. Räntan ska läsas in och är densamma för alla åren.

static double AskInterest()
{
    Console.WriteLine("Ange räntan i %: ");
    return double.Parse(Console.ReadLine()!);
}

static void MoneyWithRent()
{
    double saldo = 1000;
    double ranta = AskInterest();

    for (int ar = 1; ar <= 10; ar++)
    {
        saldo = saldo * (1 + ranta / 100);
        Console.WriteLine($"År {ar}: {saldo:F2} kr");
    }
}
MoneyWithRent();