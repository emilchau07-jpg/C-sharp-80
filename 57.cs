//57. En bilägare har för ett antal tankningar skrivit upp antal tankade liter bensin och antal körda mil. Skriv en funktion som läser in hur många liter som har tankats samt antal körda mil för varje tankningstillfälle. Inmatningen ska avslutas med 0. funktionen ska beräkna och visa bensinförbrukning per mil för varje tankning. När data för samtliga tanktillfällen är inlästa ska genomsnittlig bensinförbrukning per mil skrivas ut.

static void Uppgift()
{
    double totalLiter = 0;
    double totalMil = 0;

    while (true)
    {
        Console.WriteLine("Hur många Liter tankade du? ");
        double Liter = double.Parse(Console.ReadLine());

        if (Liter == 0)
        {
            Console.WriteLine("Programmet avslutas");
            break;
        }

        Console.WriteLine("Hur många mil körde du? ");
        double Mil = double.Parse(Console.ReadLine());

        totalLiter += Liter;
        totalMil += Mil;

        double summa = 0;

        summa = Liter / Mil;
        Console.WriteLine($"Bensinförbrukning per mil är: {summa:F2}");
    }
    double genomsnitt = totalLiter / totalMil;
    Console.WriteLine($"Genomsnittliga Liter/Mil är: {genomsnitt:F2}");
}
Uppgift();
