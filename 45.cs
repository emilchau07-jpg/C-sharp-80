//45. Skriv en funktion där det undersöks hur många termer som behövs för att summan ska bli större än 100 000. Termen ska läsas in.
//Ex: Om indata är 7 ska beräkningen vara 7 + 7 + 7 + …7 = 100 000. Utdata = 14286

static void BeraknaFunktion()
{
    Console.WriteLine("Ange en term: ");
    double term = double.Parse(Console.ReadLine());

    double summa = 0;
    int antal = 0;
    while (summa < 100000)
    {
        summa += term;
        antal++;
    }
    Console.WriteLine($"{antal} många {term} behövs för att överstiga 100 000");
}
BeraknaFunktion();