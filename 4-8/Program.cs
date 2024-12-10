using _4_8;

namespace _4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person Data");
            Person Persoon = new Person("Jan Hendriksen");
            Persoon.Birthdate = "22-06-2007";
            Persoon.Address = "Amerikalaan 39";
            Persoon.Telephone = "06-488091074";
            Persoon.Email = "Mootjevandeblok@gmail.com";

            Console.WriteLine(Persoon);


        }
    }
}
