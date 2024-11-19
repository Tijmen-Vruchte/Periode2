namespace Opdracht_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voorwerp Monitor = new Voorwerp();
            Monitor.prijs = 199;
            Monitor.kleur = "zwart";

            Voorwerp Oplaadpaal = new Voorwerp();
            Oplaadpaal.prijs = 299;
            Oplaadpaal.kleur = "wit";

            Console.WriteLine("Monitor");
            Console.WriteLine("Deze monitor is "+ Monitor.prijs +" euro waard.");
            Console.WriteLine("Deze monitor heeft een "+ Monitor.kleur +"e kleur.");
            Console.WriteLine("Oplaadpaal");
            Console.WriteLine("Deze oplaadpaal is " + Oplaadpaal.prijs + " euro waard.");
            Console.WriteLine("Deze oplaadpaal heeft een " + Oplaadpaal.kleur + "te kleur.");





        }
    }
}
