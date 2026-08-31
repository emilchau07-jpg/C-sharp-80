//Skriv en funktion där en cirkels radie läses in. Cirkelns diameter, omkrets och area skall beräknas och skrivas ut. (pi = 3.14).
// Omkrets = 2 * pi * r, Area = pi * r^2 och Diameter = r * 2

using System.Net.NetworkInformation;

Console.Write("Vad är circelns radie? ");
double Radie = double.Parse(Console.ReadLine()!);

double pi = 3.14;

double Diameter = Radie * 2;
double Omkrets = 2 * pi * Radie;
double Area = pi * (Radie * Radie);

Console.Write($"Diametern på cirkeln är {Diameter:F2}, omkretsen är {Omkrets:F2} och arean är {Area:F2}");