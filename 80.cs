/*
Skriv en funktion som läser in siffrorna i ett bråk till en array med två platser. funktionen ska se till att bråket förkortas så långt som möjligt.
Ex: Om siffrorna i bråket är 6 och 12 ska det lagras i arrayen som 1 och 2.
Tips: Ta reda på SGD (största gemensamma divisor). I exemplet är SGD 6.
*/

static void Uppgift()
{
    int[] division = new int[2];
    int SGD = 0;

    Console.WriteLine("Ange täljaren: ");
    division[0] = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Ange nämnaren: ");
    division[1] = int.Parse(Console.ReadLine()!);

    for (int i = Math.Min(division[0], division[1]); i >= 1; i--)
    {
        if (division[0] % i == 0 && division[1] % i == 0)
        {
            SGD = i;
            break;
        }
    }

    division[0] = division[0] / SGD;
    division[1] = division[1] / SGD;

    Console.Write($"Täljare: {division[0]}\nNämnare: {division[1]}");
}
Uppgift();