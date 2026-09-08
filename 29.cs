//Skriv en funktion som beräknar ankomsttiden för ett tåg. I inmatningsrutan finns följande:
//tidpunkt i timma och minut för avgången (t ex 12 41) körtid i timma och minut (t ex 3 47)
//I utmatningsrutan ska klockslaget för ankomsttiden skrivas. Om midnatt passeras ska det även skrivas “NÄSTA DAG“ i utmatningsrutan. 

using System.ComponentModel.DataAnnotations;

public static class TrainArrivals
{
    public static void Main()
    {
        var depature = AskDepatureTime();
        var length = AskLength();

        int arrivalHour = TrainArrivalsHour(depature.hour, length.hour);
        int arrivalMinute = TrainArrivalsMinute(depature.minute, length.minute);

        if (arrivalMinute >= 60)
        {
            arrivalMinute = arrivalMinute - 60;
            arrivalHour = arrivalHour + 1;
        }

        bool nastaDag = false;
        if (arrivalHour >= 24)
        {
            arrivalHour = arrivalHour - 24;
            nastaDag = true;
        }

        Console.WriteLine($"Ditt tåg kommer fram {arrivalHour}:{arrivalMinute:D2}");
        if (nastaDag)
        {
            Console.WriteLine("Nästa dag");
        }

    }

    static (int hour, int minute) AskDepatureTime()
    {
        Console.WriteLine("Avgångstiden på ditt tåg timme? ");
        int depaturehour = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Avgångstiden på ditt tåg minut? ");
        int depatureminute = int.Parse(Console.ReadLine()!);

        return (depaturehour, depatureminute);
    }

    static (int hour, int minute) AskLength()
    {
        Console.WriteLine("Hur lång är tågresan i timmar? ");
        int lengthhour = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Hur lång är tågresan i minuter? ");
        int lengthminute = int.Parse(Console.ReadLine()!);

        return (lengthhour, lengthminute);
    }

    static int TrainArrivalsHour(int depaturehour, int lengthhour)
    {
        return depaturehour + lengthhour;
    }

    static int TrainArrivalsMinute(int depatureminute, int lengthminute)
    {
        return depatureminute + lengthminute;
    }
}