/*
62. Skriv en funktion som läser in 10 heltal. Kontrollera att talen ligger i området 5000 till 10000. Om alla talen är inom intervallet ska “RÄTT“ skrivas ut.
OBS! 10 tal ska läsas in, även om något tal är utanför det tillåtna intervallet.
*/

static void Uppgift()
{
    List<int> numbers = [];

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Ange ett 'rätt' tal: ");
        int tal = int.Parse(Console.ReadLine()!);
        numbers.Add(tal);
    }

    bool allaRatt = true;

    foreach (int tal in numbers)
    {
        if (tal < 5000 || tal > 10000)
        {
            allaRatt = false;
        }
    }

    if (allaRatt == true)
    {
        Console.WriteLine("RÄTT");
    }
    else
    {
        Console.WriteLine("FEL");
    }
}
Uppgift();