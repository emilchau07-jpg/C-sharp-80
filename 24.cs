//Skriv en funktion som läser in kroppstemperaturen och skriver ut ett lämpligt meddelande om temperaturen är mindre än 35 grader eller större än 42 grader.

Console.WriteLine("Vad har du för kroppstemperatur? ");
double bodytemp = double.Parse(Console.ReadLine());

if (bodytemp <= 35 && bodytemp >= 42)
{
    Console.WriteLine("Sök hjälp av en läkare!");
}
else
{
    Console.WriteLine("Din kroppstemperatur är normal.");
}