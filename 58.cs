//58. Skriv en funktion som läser in 10 tal, bestämmer och skriver ut det största av talen.
static void Uppgift()
{
    List<int> numbers = [];
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("\nAnge ett tal: ");
        int tal = int.Parse(Console.ReadLine());
        numbers.Add(tal);
    }
    numbers.Sort();
    Console.WriteLine($"\nStörsta talet är: {numbers[9]}");
}
Uppgift();