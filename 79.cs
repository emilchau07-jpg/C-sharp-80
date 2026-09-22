//Skriv en funktion som läser in siffrorna i ett bråk till en array med två platser. Det är inte vanligt att man låter nämnaren vara negativ. Om så är fallet ska bråket ändras så att nämnaren blir positiv.

static void Uppgift()
{
    int[] division = new int[2];
    int kvot = 0;

    Console.WriteLine("Ange täljaren: ");
    division[0] = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Ange nämnaren: ");
    division[1] = int.Parse(Console.ReadLine()!);

    if (division[1] < 0)
    {
        division[1] = division[1] * -1;
    }

    kvot = division[0] / division[1];

    Console.WriteLine($"Kvoten av denna division är: {kvot}");
}
Uppgift();