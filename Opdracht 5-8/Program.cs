using System.Numerics;

namespace Opdracht_5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> people = new List<Persoon>();
            
            var totalCount = 0;
            double totaleLeeftijd = 0;

            Console.WriteLine("Voer een naam in");
            string inputt = (Console.ReadLine());

            Console.WriteLine("Voer een leeftijd in");
            int inputt2 = Convert.ToInt32(Console.ReadLine());
            people.Add(new Persoon(inputt, inputt2));
            Console.WriteLine("Wil je iemand toevoegen?");
            string antwoord = Console.ReadLine();
            totaleLeeftijd += inputt2;
            while (antwoord.ToLower() == "j")
            {

                Console.WriteLine("Voer een naam in");
                string input = (Console.ReadLine());

                Console.WriteLine("Voer een leeftijd in");
                int input2 = Convert.ToInt32(Console.ReadLine());
                people.Add(new Persoon(input, input2));

                Console.WriteLine("Wil je iemand toevoegen?");
                antwoord = Console.ReadLine();
                totaleLeeftijd += input2;
            }
            
            totalCount = people.Count();
            double averaga = totaleLeeftijd / totalCount;

            Console.WriteLine("Er zitten "+ totalCount +" mensen in de lijst dit zijn: ");
            Console.WriteLine("De gemiddelde leeftijd is:  " + averaga);
            foreach (var item in people)
            {
                Console.WriteLine(item);
                
                
            }

                

        }

    }
}