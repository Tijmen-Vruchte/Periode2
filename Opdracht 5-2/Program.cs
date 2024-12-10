using System.ComponentModel.DataAnnotations.Schema;

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


        
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }




        }
    }
}
