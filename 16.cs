//En firma erbjuder sina kunder 10 procents rabatt om man vid ett inköpstillfälle handlar för minst 1000 kr. Antag för enkelhetens skull att man bara handlar varor av ett visst slag. Skriv en funktion som beräknar vad en kund ska betala. Indata till funktionen ska vara antalet köpta enheter och priset per enhet.
Console.WriteLine("Köp en typ av produkt för mer än 1000kr och få 10% rabatt");

Console.Write("Hur många antal produkter vill du köpa? ");
double Antal = double.Parse(Console.ReadLine()!);

Console.Write("Hur mycket kostar varje produkt? ");
double Pris = double.Parse(Console.ReadLine()!);

double Total = Antal * Pris;

if (Total > 1000)
{
    double Total1 = Antal * Pris * 0.9; ;
    Console.Write($"Ditt slutpris med 10% rabatt är {Total1}");
}
else
{
    double Total2 = Antal * Pris;
    Console.Write($"Ditt slutpris blir {Total2}");
}