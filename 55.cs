//55. Skriv en funktion där indata består av 101 tal. Bestäm och skriv ut summan av de tal som är större än första talet samt summan av de tal som är mindre än första talet.

static void Uppgift()
{
    int litensumma = 0;
    int storsumma = 0;

    Console.WriteLine("Ange ett tal: ");
    int forstatal = int.Parse(Console.ReadLine());

    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine());
        if (tal < forstatal)
        {
            litensumma += tal;
        }
        else
        {
            storsumma += tal;
        }
    }
    Console.WriteLine($"Första talet är {forstatal}");
    Console.WriteLine($"Summan av talen under {forstatal} är {litensumma}");
    Console.WriteLine($"Summan av talen över {forstatal} är {storsumma}");


}
Uppgift();