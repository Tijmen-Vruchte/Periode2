using System.Reflection.Emit;

namespace Opdracht2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tafel Salontafel = new Tafel();
            Salontafel.lengte = 1;
            Salontafel.breedte = 1;

            Tafel Eettafel = new Tafel();
            Eettafel.lengte = 1.2;
            Eettafel.breedte = 1.8;

            Console.WriteLine("Salontafel");
            Console.WriteLine("Deze heeft een lengte van " + Salontafel.lengte + " meter.");
            Console.WriteLine("Deze heeft een breedte van " + Salontafel.breedte + " meter.");
            Console.WriteLine("Deze heeft een oppervlakte van: " + Salontafel.BerekenOppervlakte() + " m2.");
            Console.WriteLine("Eettafel");
            Console.WriteLine("Deze heeft een lengte van " + Eettafel.lengte + " meter.");
            Console.WriteLine("Deze heeft een breedte van " + Eettafel.breedte + "meter.");
            Console.WriteLine("Deze heeft een oppervlakte van: "+ Eettafel.BerekenOppervlakte() + " m2.");

        }
    }
}
