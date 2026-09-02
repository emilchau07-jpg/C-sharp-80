//Skriv en funktion som läser in två tal och dividerar det första talet med det andra talet. Om det andra talet (nämnaren) är 0 ska ett felmeddelande ges, annars ska kvoten skrivas ut.

Console.Write("Ange ett tal: ");
double Tal1 = double.Parse(Console.ReadLine()!);

Console.Write("Ange tal 2: ");
double Tal2 = double.Parse(Console.ReadLine()!);

if (Tal2 == 0)
{
    Console.Write("Det går inte att dividera med 0");
}
else
{
    double Kvot = Tal1 / Tal2;
    Console.Write($"Kvoten blir {Kvot}");
}