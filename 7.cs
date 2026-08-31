//Skriv en funktion som beräknar vad du ska betala för en tank bensin. Indata är antal liter, pris per liter och eventuell rabatt i procent. Utdata är priset som du ska betala
Console.Write("Hur många liter bensin vill du tanka?: ");
int Liter = int.Parse(Console.ReadLine()!);

Console.Write("Vad är priset per liter?: ");
double Pris = double.Parse(Console.ReadLine()!);

Console.Write("Har du någon procentuell rabatt? ");
double Rabatt = double.Parse(Console.ReadLine()!);

double LiterP = Liter * Pris;
double Rea = Rabatt / 100 * LiterP;
double Total = LiterP - Rea;

Console.WriteLine($"Det kommer att kosta {Total} att tanka bilen");