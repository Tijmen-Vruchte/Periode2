using System.ComponentModel.DataAnnotations.Schema;

namespace opdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> landen = new List<string>();
            landen.Add("Nigeria");
            landen.Add("Bombaland");
            landen.Add("Kakaland");
            landen.Add("babaland");
            landen.Add("kakaland");
            foreach (string i in landen)
            {
                Console.WriteLine(i);
            }




        }
    }
}
