//Om den näst sista siffran är jämn i personnumret är det en kvinna, om den är ojämn är det en man. Avgör om personen i föregående uppgift är man eller kvinna.

static void Uppgift()
{
    Console.WriteLine("Ange ditt personnummer: ");
    string input = Console.ReadLine()!;

    char[] ssc = input.ToCharArray();

    int number = ssc[10] - '0';

    if (number % 2 == 0)
    {
        Console.WriteLine("Du är en kvinna");
    }
    else
    {
        Console.WriteLine("Du är en man");
    }
}
Uppgift();