Console.Write("Ange ett antal svenska kronor: ");

int tal = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{tal * 6} dollar eller {tal * 10} pund");