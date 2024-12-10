using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace opdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Voer een getal in");
                int input = Convert.ToInt32(Console.ReadLine());
                list.Add(input);
            }


            int count = 0;
            foreach (int i in list)
            {
                Console.WriteLine(i);
                
                
                
            }
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(list.Sum());
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine(list.Average());

            



        }
    }
}
