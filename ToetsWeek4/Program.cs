using System.Threading.Channels;

namespace ToetsWeek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bootgegevens Dezeilboot = new bootgegevens("Valk");
            Dezeilboot.Lengte = 6.5;
            Dezeilboot.Breedte = 2.1;
            Dezeilboot.Hoogte = 8.2;
            Dezeilboot.Diepgang = 0.85;
            Dezeilboot.Maximalesnelheid = 5;

            Console.WriteLine(Dezeilboot.BootInfo());

            bootgegevens Despeedboot = new bootgegevens("Zodiac");
            Despeedboot.Maximalesnelheid = 20;
            Console.WriteLine(Despeedboot);

            double tijd = 2.5;
            Console.WriteLine("Na " + tijd + " uur varen met de " + Despeedboot.HetMerk + " zijn " +
                "we "+ Despeedboot.BerekenAfstand(tijd) + " mijlen uit de kust"); ;
        }
        
    }
}
