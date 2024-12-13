namespace Opdracht_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> people = new List<Persoon>();
            people.Add(new Persoon("Cassandra", 17));
            people.Add(new Persoon("RyanDikstra", 432));
            people.Add(new Persoon("jamal oezoekwambwe", 12));

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

          
          
        }   
    }
}
