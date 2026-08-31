//Skriv en funktion som beräknar funktionen ax3 + 7 och skriver ut resultatet. Variablerna a och x ska läsas in.
Console.Write("Vad är värdet på a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Vad är värdet på x: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Resultatet av funktionen {a} *{x} * 3 + 7 är: {a * x * 3 + 7}");