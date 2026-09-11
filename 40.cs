/*
Konstruera en funktion som beräknar och skriver ut svaret för funktionen:
f(x) = 3x³ - 5x² + 2x - 20
Funktionen ska skriva ut alla värden när x är ett heltal mellan -10 och 10. Dvs x antar värdet -10 och ökar med ett till värdet blir 10.
*/

static double BeraknaFunktion(double x)
{
    return (3 * Math.Pow(x, 3)) - (5 * Math.Pow(x, 2)) + (2 * x) - 20;
}
int x = -10;
while (x <= 10)
{
    Console.WriteLine($"f({x}) = {BeraknaFunktion(x)}");
    x++;
}