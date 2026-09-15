//56. Läs in ett antal tal. 9999 ska vara stoppvärde. Beräkna och skriv ut medelvärdet av de inlästa talen. Tänk på vad som händer om det första inlästa talet är stoppvärdet.


static void Uppgift()
{
    double summa = 0;
    double i = 0;

    while (true)
    {
        Console.WriteLine("Ange ett tal: ");
        int tal = int.Parse(Console.ReadLine());

        if (tal == 9999)
        {
            if (i == 0)
            {
                Console.WriteLine("Inga tal matades in");
                return;
            }
            break;
        }

        i++;
        summa += tal;
    }
    double medelvärde = summa / i;
    Console.WriteLine($"Programmet stoppas med stoppvärde 9999. Summan är {summa}, och medelvärdet är {medelvärde:F2}");

}
Uppgift();