namespace PersoonRegistraties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoonsgegevens persoonsgegevens = new Persoonsgegevens("Petra", "Dijkstra");
            
            persoonsgegevens.Leeftijd = 22;
            persoonsgegevens.Lengte = 183;
            persoonsgegevens.Gewicht = 83.3;
            Console.WriteLine(persoonsgegevens.ToonInfo());
            Persoonsgegevens persoon2 = new Persoonsgegevens("Jan","Dijkstra");
            persoon2.Lengte = 0;
            Console.WriteLine(persoon2);

            Console.WriteLine(persoonsgegevens.BerekenBMI());
            Persoonsgegevens Papa = new Persoonsgegevens("Papa", "Pascal");
            Papa.Lengte = 193;
            Papa.Gewicht = 126;
            Papa.Leeftijd = 47;
            Console.WriteLine(Papa.ToonInfo());
            Console.WriteLine(Papa.BerekenBMI());

            
        }
    }
}
