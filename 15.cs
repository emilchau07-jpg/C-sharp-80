//Skriv en funktion som läser in två tal och avgör och skriver ut om det första talet är jämnt delbart med det andra talet.

Console.Write("Ange ett tal: ");
double Tal1 = double.Parse(Console.ReadLine()!);
Console.Write("Ange andra talet: ");
double Tal2 = double.Parse(Console.ReadLine()!);

double Tal = Tal1 / Tal2;
if (Tal % 2 == 0)
{
    Console.Write("Första talet kan delas jämt ut med det andra talet");
}
else
{
    Console.Write("Talen kan inte delas jämt");
}