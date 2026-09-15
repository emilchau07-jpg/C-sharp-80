//51. Skriv en funktion som läser in 100 tal och räknar och skriver ut hur många gånger talet 7 har lästs in.

static void Uppgift()
{
    int x = 0;
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine("Ange ett heltal: ");
        int tal = int.Parse(Console.ReadLine());
        if (tal == 7)
        {
            x += 1;
        }
        else
        {
            continue;
        }
    }
    Console.WriteLine($"7 angavs {x} gånger");
}
Uppgift();
