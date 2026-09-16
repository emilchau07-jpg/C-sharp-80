//63. Skriv en funktion som läser in en följd av positiva tal som ska vara sorterade i växande ordning. Talföljdens slut anges med en nolla. Om det finns fel i sorterings-ordningen ska meddelandet “Fel sorteringsordning“ skrivas ut.

static void Uppgift()
{
    List<int> numbers = [];

    while (true)
    {
        Console.WriteLine("(0 avslutar programmet)\nAnge ett tal: ");
        int tal = int.Parse(Console.ReadLine()!);

        if (tal == 0)
        {
            break;
        }
        numbers.Add(tal);
    }

    foreach (int tal in numbers)
    {
        Console.Write(tal + " ");
    }

    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] < numbers[i - 1])
        {
            Console.WriteLine($"Fel sorteringsordning");
        }
    }
}
Uppgift();