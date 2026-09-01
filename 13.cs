//Skriv en funktion som läser in ett tal och skriver ut om det är jämnt. (Använd modulooperatorn)

Console.Write("Ange ett tal: ");
int Tal = int.Parse(Console.ReadLine()!);

if (Tal % 2 == 0)
{
    Console.Write("Talet är jämt");
}
else
{
    Console.Write("Talet är udda");
}