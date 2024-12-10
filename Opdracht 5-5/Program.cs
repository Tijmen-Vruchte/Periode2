using System.ComponentModel.DataAnnotations.Schema;

namespace opdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> landen = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Voer een land in");
                string input = (Console.ReadLine());
                landen.Add(input);
            }

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");

            foreach (string i in landen)
            {
                Console.WriteLine(i);
            }




        }
    }
}
