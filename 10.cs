//Sambandet mellan Fahrenheit och Celsius grader ges av formeln F=9C / 5 + 32. Konstruera en funktion där en temperatur i Fahrenheit läses in och motsvarande temperatur i Celsius skrivs ut. Formeln enligt google är C = (F -32) / 1,8

Console.Write("Hur många Fahrenheit? ");
double F = double.Parse(Console.ReadLine()!);

double C = (F - 32) / 1.8;
Console.Write($"{F:F2} grader i Fahrenheit blir {C:F2} grader i Celcius");