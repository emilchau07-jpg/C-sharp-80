//Skriv en funktion som läser in två tal och skriver ut det största talet följt av orden “är störst “. Om talen är lika ska “Talen är lika“ skrivas ut.

Console.WriteLine("Ange första talet: ");
double number1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ange andra talet: ");
double number2 = double.Parse(Console.ReadLine()!);

if (number1 > number2)
{
    Console.WriteLine($"{number1} är störst");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number2} är störst");
}
else
{
    Console.WriteLine("Talen är lika stora");
}