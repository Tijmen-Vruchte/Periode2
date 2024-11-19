namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 10;
            Persoon Tijmen = new Persoon();
            Tijmen.naam = "Tijmen";
            Tijmen.leeftijd = 17;
            Tijmen.lengtInCentimeters = 1.25;


            Console.WriteLine(Tijmen.naam);
            Console.WriteLine(Tijmen.leeftijd);
            Console.WriteLine(Tijmen.lengtInCentimeters);
 
            Console.WriteLine("Mijn naam is " + Tijmen.naam +" en ik ben " + Tijmen.leeftijd + 
                " jaar oud en ben " + Tijmen.lengtInCentimeters + " lang.");



        }
    }
}
