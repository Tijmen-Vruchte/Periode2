namespace Opdracht_5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> people = new List<Persoon>();

            Console.WriteLine("Voer een naam in");
            string inputt = (Console.ReadLine());

            Console.WriteLine("Voer een leeftijd in");
            int inputt2 = Convert.ToInt32(Console.ReadLine());
            people.Add(new Persoon(inputt, inputt2));
            Console.WriteLine("Wil je iemand toevoegen?");
            string antwoord = Console.ReadLine();

            while (antwoord.ToLower() == "j")
            {

                Console.WriteLine("Voer een naam in");
                string input = (Console.ReadLine());

                Console.WriteLine("Voer een leeftijd in");
                int input2 = Convert.ToInt32(Console.ReadLine());
                people.Add(new Persoon(input, input2));

                Console.WriteLine("Wil je iemand toevoegen?");
                antwoord = Console.ReadLine();
            }

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

        }

    }
}