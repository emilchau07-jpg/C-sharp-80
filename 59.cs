//59. Skriv en funktion som låter användaren bestämma hur många tal han vill läsa in. Det största och minsta värdet av talen ska beräknas och skrivas ut.

static void Uppgift()
{
    List<int> numbers = [];

    Console.WriteLine("Hur många antal tal vill du mata in? ");
    int antal = int.Parse(Console.ReadLine());

    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine("\nAnge ett tal till listan: ");
        int tal = int.Parse(Console.ReadLine());
        numbers.Add(tal);
    }

    numbers.Sort();
    Console.WriteLine($"Minsta talet i listan är {numbers[0]} och största talet är {numbers[antal - 1]}");
}
Uppgift();