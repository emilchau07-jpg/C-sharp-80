/*
48. Skriv en funktion som skriver ut n! (fakulteten). n ska läsas in. Ex:
3! = 1 * 2 * 3
5! = 1 * 2 * 3 * 4 * 5
*/

static void BeraknaFunktion()
{
    Console.WriteLine("Ange falkuteten(n!) i siffra: ");
    int n = int.Parse(Console.ReadLine());
    int fakultet = 1;

    for (int i = 1; i <= n; i++)
    {
        fakultet = fakultet * i;
    }
    Console.WriteLine($"{n}!={fakultet}");

}
BeraknaFunktion();