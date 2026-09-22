//Skriv en funktion som läser in siffrorna i ett bråk (täljare och nämnare) till en array med två platser. Eftersom det är otillåtet att ha 0 i nämnaren ska ett felmeddelande skrivas ut om så är fallet.

static void Uppgift()
{
    int[] division = new int[2];
    int kvot = 0;

    Console.WriteLine("Ange täljaren: ");
    division[0] = int.Parse(Console.ReadLine()!);

    while (true)
    {
        Console.WriteLine("Ange nämnaren: ");
        division[1] = int.Parse(Console.ReadLine()!);

        if (division[1] != 0)
        {
            break;
        }
        Console.WriteLine("0 är inte tillåtet som nämnare.");
    }


    kvot = division[0] / division[1];

    Console.WriteLine($"Kvoten av divisionen är: {kvot}");
}
Uppgift();