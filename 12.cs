//Läs in två tal. Testa om det första talet är mer än dubbelt så stort som det andra talet. I så fall ska meddelandet “För stort“ skrivas ut.

Console.Write("Agne tal 1: ");
double Tal1 = double.Parse(Console.ReadLine()!);
Console.Write("Ange tal 2: ");
double Tal2 = double.Parse(Console.ReadLine()!);

if (Tal1 > (Tal2 * 2))
{
    Console.Write("För stort");
}
else
{
    Console.Write("Inget händer");
}