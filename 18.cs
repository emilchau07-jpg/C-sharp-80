//Konstruera en funktion där värden på variablerna X och Y läses in. Tilldela variabel A värdet 2 om X är större än 5 + Y, annars tilldela A värdet 5. Skriv ut variabeln A.

Console.Write("Ange värdet för x: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write("Ange värdet för y: ");
int Y = int.Parse(Console.ReadLine()!);

int a;

a = 2; if (X > 5 + Y)
{
    Console.Write($"A = {a}");
}
else
{
    a = 5;
    Console.Write($"A = {a}");
}