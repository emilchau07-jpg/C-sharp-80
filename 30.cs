//Läs in ett tal. Skriv ut om talet är mindre än 10, mindre än 100 eller större än 100.

Console.WriteLine("Ange ett tal: ");
double number = double.Parse(Console.ReadLine());

if (number < 10)
{
    Console.WriteLine("Talet är mindre än 10");
}
else if (number >= 10 && number <= 100)
{
    Console.WriteLine("Talet är större än 10, men mindre än 100");
}
else
{
    Console.WriteLine("Talet är större än 100");
}
