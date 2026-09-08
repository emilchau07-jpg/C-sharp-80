//Skriv en funktion som läser in en temperatur. Om temperaturen är mellan 18 och 25 grader ska meddelandet “Lagom temp“ skrivas ut. Om det är varmare än 25 grader ska “För varmt“ skrivas ut och om det är kallare än 18 grader ska “För kallt“ skrivas ut.



public static class temperatur
{
    public static void Main()
    {
        double temp = Ask();

        if (Normal(temp))
        {
            Console.WriteLine("Lagom temp");
        }
        else if (Hot(temp))
        {
            Console.WriteLine("För varmt");
        }
        else if (Cold(temp))
        {
            Console.WriteLine("För kallt");
        }



    }

    static double Ask()
    {
        Console.WriteLine("Vad är temperaturen? ");
        double temp = double.Parse(Console.ReadLine());
        return temp;
    }

    static bool Normal(double temp)
    {
        return temp >= 18 && temp <= 25;
    }

    static bool Hot(double temp)
    {
        return temp > 25;
    }

    static bool Cold(double temp)
    {
        return temp < 18;
    }
}
