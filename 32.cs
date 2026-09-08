//Skriv en funktion där talen 2, 4, 6, …, 100 skrivs ut.

static void number()
{
    int tal = 0;
    do
    {
        tal += 2;
        Console.WriteLine(tal);
    } while (tal < 100);
}
number();