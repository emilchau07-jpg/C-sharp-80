//Konstruera en funktion där ett tal läses in och det skrivs ut om talet är positivt eller negativt.

Console.WriteLine("Ange ett tal: ");
double number = double.Parse(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Ditt nummer är 0, varken positivt eller negativt.");
}
else if (number < 0)
{
    Console.WriteLine("Ditt tal är negativt.");
}
else
{
    Console.WriteLine("Ditt tal är positivt.");
}