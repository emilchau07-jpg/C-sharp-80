//Skriv en funktion som läser in ett tal och skriver ut om det är udda eller jämnt.

Console.Write("Ange ett tal: ");
int Tal = int.Parse(Console.ReadLine()!);

if ((Tal / 2) * 2 == Tal)
{
    Console.Write("Talet är jämnt");
}
else
{
    Console.Write("Talet är udda");
}