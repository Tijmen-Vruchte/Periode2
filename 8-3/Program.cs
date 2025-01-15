namespace _8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorfiets motorfiets1 = new Motorfiets("Dokatrekka");
            motorfiets1.Model = "BliksemQueen 2007";
            motorfiets1.Koffersetmerk = "Dorcas";
            motorfiets1.Inhoud = 45;


            Console.WriteLine(motorfiets1);

            Motorfiets motorfiets2 = new Motorfiets("BlikaDakka");
            motorfiets2.Model = "Jarneprojo 330";
            motorfiets2.Koffersetmerk = "Volka";
            motorfiets2.Inhoud = 55;
            Console.WriteLine(motorfiets2);
        }
    }
}
