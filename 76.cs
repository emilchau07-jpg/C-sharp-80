//En array med 10 inlästa tal finns. Lägg över dessa tal i en annan array så att talen kommer i omvänd ordning.

static void Uppgift()
{
    int[] numbers = new int[10];
    int[] omvand = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);

        numbers[i] = tal;
    }

    for (int i = 0; i < numbers.Length; i++)
    {
        omvand[i] = numbers[numbers.Length - 1 - i];
    }

    foreach (int tal in numbers)
    {
        Console.Write(tal + " ");

    }

    Console.WriteLine(" ");

    foreach (int tal in omvand)
    {
        Console.Write(tal + " ");
    }
}
Uppgift();