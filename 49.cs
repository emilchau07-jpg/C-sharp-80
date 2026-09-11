/*
49. Skriv en funktion som beräknar
f(x) = xⁿ
x och n ska läsas in.
*/

static void BeraknaFunktion()
{
    Console.WriteLine("Ange x: ");
    double x = double.Parse(Console.ReadLine());

    Console.WriteLine("Ange n: ");
    double n = double.Parse(Console.ReadLine());

    double sum = 1;

    for (int i = 0; i < n; i++)
    {
        sum = sum *= x;
    }
    Console.WriteLine($"Summan blir {sum}");
}
BeraknaFunktion();