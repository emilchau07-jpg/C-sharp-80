//Skriv en funktion som läser in ett antal tal och skriver ut dem. Talföljdens slut markeras med 0.
static void numbers()
{
    List<int> numbersInLine = [];

    int tal;
    do
    {
        Console.WriteLine("Ange ett par tal (0 avlsutar): ");
        tal = int.Parse(Console.ReadLine()!);
        if (tal != 0)
        {
            numbersInLine.Add(tal);
        }
    } while (tal != 0);

    foreach (int n in numbersInLine)
    {
        Console.WriteLine(n);
    }
}

numbers();