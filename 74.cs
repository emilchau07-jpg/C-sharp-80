//En array med 50 inlästa tal finns. Leta upp det största och det minsta talet i arrayen och skriv ut dem.

static void Uppgift()
{
    int[] numbers = new int[50];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);
        numbers[i] = tal;
    }

    Array.Sort(numbers);

    Console.WriteLine($"Minsta talet i arrayen är: {numbers[0]} och det största talet är : {numbers[numbers.Length - 1]}");
}
Uppgift();