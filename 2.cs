Console.Write("Hur mycket sålde du för: ");

int tal = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Du kommer att tjäna {tal * 0.09 + 8000}");
