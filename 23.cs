//Skriv en funktion som testar om ett inläst tal är jämnt delbart med 3 men inte med 30. I så fall ska talet divideras med 3.

Console.WriteLine("Ange ett tal: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 3 == 0 && number % 30 != 0)
{
    Console.WriteLine($"{number} / 3 är jämt delbart");
}
else
{
    Console.WriteLine("Talet är inte jämt delbart med 3");
}