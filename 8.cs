//Skriv en funktion som beräknar och skriver ut arean och omkretsen av en rektangel. Rektangelns sidor ska läsas in.

Console.Write("Hur lång är basen på rektangeln? ");
double Bas = double.Parse(Console.ReadLine()!);

Console.Write("Hur hög är höjden på rektangeln? ");
double Hog = double.Parse(Console.ReadLine()!);

double Area = Bas * Hog;
Console.Write($"Arean på rektangeln är {Area}");