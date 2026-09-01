//Skriv en funktion där två tal läses in och det första talet skrivs ut om det är störst.

using System.Security.Cryptography;

Console.Write("Ange tal 1: ");
double Tal1 = double.Parse(Console.ReadLine()!);
Console.Write("Ange tal 2: ");
double Tal2 = double.Parse(Console.ReadLine()!);

if (Tal1 >= Tal2)
{
    Console.Write($"Första talet är större än {Tal2}");
}
else
{
    Console.Write($"Andra talet är större än första talet");
}
