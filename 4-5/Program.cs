namespace _4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Volkswagen","groen");
            auto.Maxsnelheid = 150;
            auto.Huidigesnelheid = 78;
            //auto.Merk = "Audi";
            //auto.Kleur = "Grijs";

            Console.WriteLine(auto);

            auto.Kleur = "rood";

            Console.WriteLine(auto);
        }
    }
}
