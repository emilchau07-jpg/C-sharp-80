Console.Write("Ange tiden i timmar: ");

int tal = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{tal * 60} minuter eller {tal * 3600} sekunder");