//Skriv en funktion som testar om ett tal är mindre än -10 eller större än +10. I så fall ska ett lämpligt meddelande ges.

Console.Write("Ange ett tal mellan -10 och 10: ");
int tal = int.Parse(Console.ReadLine()!);

if (tal >= -10 && tal <= 10)
{
    Console.Write("BRA!!");
}
else
{
    Console.Write("Ange ett tal MELLAN -10 och 10!");
}