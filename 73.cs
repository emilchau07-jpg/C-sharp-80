//En array med 50 inlästa tal finns. Beräkna och skriv ut summan och medelvärdet av de 50 talen.

static void Uppgift()
{
    int[] numbers = new int[50];

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);

        numbers[i] = tal;
    }

    int summa = 0;
    double medelvärdet = 0;

    foreach (int tal in numbers)
    {
        summa += tal;
    }

    medelvärdet = (double)summa / numbers.Length;

    Console.WriteLine($"Summan av alla tal i arrayen är: {summa}, Medelvärdet är: {medelvärdet}");
}
Uppgift();