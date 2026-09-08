//Skriv en funktion som beräknar och skriver ut kvadraterna för talen 1 till 9.

static void TalIKvadrat()
{
    int nummer = 0;
    int kvadrat = 0;
    do
    {
        nummer += 1;
        kvadrat = nummer * nummer;
        Console.WriteLine(kvadrat);
    } while (nummer < 9);
}
TalIKvadrat();