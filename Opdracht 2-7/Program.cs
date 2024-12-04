using Opdracht_2_4;

namespace Opdracht_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon naamVanPersoon = new Persoon();
            naamVanPersoon.SetNaam("Tijmen");
            naamVanPersoon.SetGeboorteJaar(2007);

            Console.WriteLine("Naam van persoon: " + naamVanPersoon.GetNaam() + ".");
            Console.WriteLine("Geboortejaar van persoon: " + naamVanPersoon.GetGeboorteJaar() + ".");
            Console.WriteLine("Het leeftijd van deze persoon is: "+ naamVanPersoon.AftrekLeeftijd()+".");
    






        }
    }
}
