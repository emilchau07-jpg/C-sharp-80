//Skriv en funktion som läser in och skriver ut ett tecken i taget tills en * skrivs in.


static void tecken()
{
    string gubbe;
    do
    {
        Console.WriteLine("Ange ett tecken(* avslutar): ");
        gubbe = Console.ReadLine()!;
        Console.WriteLine(gubbe);
    } while (gubbe != "*");
}
tecken();