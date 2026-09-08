/* En kommun har gjort följande prognos för befolkningsutvecklingen de närmaste åren:
Vid början av 2016 hade kommunen 26000 invånare.
Antalet födda och avlidna under ett år uppskattas var 0.7% resp 0.6% av befolkningen vid årets början.
Antalet inflyttade och antalet utflyttade uppskattas till 300 resp 325 varje år.
Skriv en funktion som beräknar kommunens uppskattade invånarantal i början av ett visst år. Vilket år det gäller ska läsas in som indata till funktionen.*/

static int Begining()
{
    int residents = 26000;
    return residents;
}

static (double, double) BornAndDeaths()
{
    double born = 1 + 0.007;
    double death = 1 - 0.006;
    return (born, death);
}

static (int, int) Moving()
{
    int movingTo = 300;
    int movingAway = 325;
    return (movingTo, movingAway);
}

static int WhichYear()
{
    Console.WriteLine("Vilket år ska du kolla(mellan år 2016-2026)? ");
    return int.Parse(Console.ReadLine());
}

static void Funktion()
{
    double residents = Begining();
    var (born, death) = BornAndDeaths();
    var (movingTo, movingAway) = Moving();
    int targetyear = WhichYear();
    int years = targetyear - 2016;

    for (int i = 0; i < years; i++)
    {
        residents = residents * (born * death);
        residents = residents + movingTo;
        residents = residents - movingAway;
    }
    Console.WriteLine($"År {targetyear} är det {residents:N0} st invånare");
}
Funktion();