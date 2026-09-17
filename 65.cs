//65. Indata består av 100 positiva tal. Skriv en funktion för beräkning av skillnaden mellan det största talet och det näst största talet.

static void Uppgift()
{
    List<int> numbers = [];

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);
        numbers.Add(tal);
    }

    numbers.Sort();
    int biggest = numbers[9];
    int nextbiggest = numbers[8];

    int difference = biggest - nextbiggest;

    Console.WriteLine($"Skillnaden mellan största och näststörsta talen är {difference}");
}
Uppgift();