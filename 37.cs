//Skriv en funktion som läser in hur många tal användaren vill ange. funktionen ska sedan läsa in detta antal tal och skriva ut dem.

MakeTheList();

static int HowManyNumbers()
{
    Console.WriteLine("Hur många antal nummer vill du ange? ");
    return int.Parse(Console.ReadLine());
}

static List<double> WhichNumbers(int antal)
{
    List<double> numbers = new List<double>();

    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine("Ange ett nummer: ");
        numbers.Add(double.Parse(Console.ReadLine()!));
    }

    return numbers;
}

static void MakeTheList()
{
    int antal = HowManyNumbers();
    List<double> numbers = WhichNumbers(antal);

    foreach (double number in numbers)
    {
        Console.WriteLine(number);
    }
}
