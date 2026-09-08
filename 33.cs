//Skriv ut talen 100 till 0, dvs 100, 99, 98, …, 0.

using System.Diagnostics;

static void numbers()
{
    int tal = 102;
    do
    {
        tal -= 2;
        Console.WriteLine(tal);
    } while (tal > 0);
}
numbers();