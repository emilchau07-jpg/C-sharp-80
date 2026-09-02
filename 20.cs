//Skriv en funktion som läser in ett tal. Om talet är mellan 0 och 9 ska kvadraten på talet skrivas ut. Annars ska lämpligt felmeddelande ges.

Console.Write("Ange ett nummer mellan 0-9: ");
double nummer = double.Parse(Console.ReadLine()!);

if (nummer >= 0 && nummer <= 9)
{
    Console.Write($"{nummer} i kvadrat blir {nummer * nummer}");
}
else
{
    Console.Write("Välj ett nummer mellan 0-9!");
}