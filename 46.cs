//46. En man erbjuds ett ovanligt riskfyllt arbete. Lönesättningen är också ovanlig. För första dagen erbjuds han 1 öre, för andra dagen 2 öre, för tredje dagen 4 öre osv. Lönen fördubblas alltså varje dag. Skriv en funktion som beräknar hur många dagar mannen måste arbeta för att tjäna en miljon kronor.

static void BeraknaFunktion()
{
    double dagslon = 1;
    double total = 0;
    int dagar = 0;
    while (total <= 100_000_000)
    {
        total += dagslon;
        dagslon *= 2;
        dagar++;
    }
    Console.WriteLine($"{dagar} antal dagar krävs för att mannen ska tjäna 1 miljon");
}
BeraknaFunktion();