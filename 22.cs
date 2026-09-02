//Skriv en funktion som testar om ett tal är 0-9 men inte 5. Skriv ut lämplig text.


string KontrolleraTal(int nummer)
{
    if (nummer == 5)
    {
        return "5 funkar inte...";
    }
    else if (nummer >= 0 && nummer <= 9)
    {
        return "BRA!!!";
    }
    else
    {
        return "Välj ett nummer mellan 0-9!";
    }
}

Console.Write("Ange ett tal mellan 0-9: ");
int nummer = int.Parse(Console.ReadLine()!);
string meddelande = KontrolleraTal(nummer);
Console.Write(meddelande);