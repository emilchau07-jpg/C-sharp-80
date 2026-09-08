//Skriv en funktion som läser in tre tal och avgör vilket tal som är minst. Resultatet ska skrivas ut.

List<double> numbers = [];

Console.WriteLine("Ange första talet: ");
double number1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ange andra talet: ");
double number2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ange tredje talet: ");
double number3 = double.Parse(Console.ReadLine()!);

numbers.Insert(0, number1);
numbers.Insert(1, number2);
numbers.Insert(2, number3);

numbers.Sort();

Console.WriteLine($"{numbers[0]} är minst");

// Exempel på hur en funktion är uppbyggd:
//
// returtyp Namn(parametertyp parameternamn)
// {
//     // kod som gör något
//     return värde; // om returtyp inte är void
// }

