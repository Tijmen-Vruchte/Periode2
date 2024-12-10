using System.ComponentModel.DataAnnotations.Schema;

namespace opdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(20);
            list.Add(40);
            list.Add(60);
            list.Add(80);
            list.Add(100);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }




        }
    }
}
