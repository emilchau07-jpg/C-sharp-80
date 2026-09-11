//47. Beräkna och skriv ut produkten av de ojämna heltalen från 1 till 15. (D v s 135…15)

static void BeraknaFunktion()
{
    int produkt = 1;
    int i;
    for (i = 1; i < 16; i += 2)
    {
        produkt = produkt * i;
    }
    Console.WriteLine($"Produkten av alla ojämna tal från 1-15 är {produkt}");
}
BeraknaFunktion();