//43. Beräkna och skriv ut summan av de jämna heltalen från 2 till 30.

static void BeraknaFunktion()
{
    int summa = 0;
    for (int i = 2; i < 31; i += 2)
    {
        summa = summa + i;
    }
    Console.WriteLine($"Summan av alla jämna heltal bilr: {summa}");
}
BeraknaFunktion();