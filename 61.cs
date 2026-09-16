/*
61. Skriv en funktion som läser en följd av positiva tal sorterade i växande ordning. Talföljdens slut anges med en nolla. Om det finns fel i sorteringsordningen ska utskrift ske enligt följande exempel:
1 1 2 7 4 6 12 16 13 8 12 24
Talföljden ger utskriften:
Tal nr 5 är fel, dess värde är 4
Tal nr 9 är fel, dess värde är 13
Tal nr 10 är fel, dess värde är 8
*/

static void Uppgift()
{
    List<int> numbers = [];

    while (true)
    {
        Console.WriteLine("Tänk på att sortera talen!(0 avslutar programmet)\nAnge ett tal: ");
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
            Console.WriteLine($"\nTal nr {i + 1} är fel, dess värde är {numbers[i]}");
        }
    }
}
Uppgift();