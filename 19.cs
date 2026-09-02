//En anställd som har timlön får, när arbetstiden överstiger 40 tim en vecka, övertidsbetalning för tiden utöver 40 tim med 1½ tim. Skriv en funktion som läser in en anställds timlön och en veckas arbetstid. Den totala veckolönen ska beräknas och skrivas ut.

using System.Numerics;

Console.Write("Vad är din timlön: ");
double lön = double.Parse(Console.ReadLine()!);
Console.Write("Hur många timmar jobbar du denna vecka? ");
int tim = int.Parse(Console.ReadLine()!);

if (tim > 40)
{
    double lön1 = lön * 1.5;
    int tim1 = tim - 40;
    double tot1 = lön1 * tim1;
    double Tot = (lön * tim) + tot1;
    Console.Write($"Din lön med övertidsbetalning är {Tot}");
}
else
{
    Console.Write($"Din lön är {lön * tim}");
}