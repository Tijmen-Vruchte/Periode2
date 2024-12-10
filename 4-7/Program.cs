namespace _4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person Data");
            Person Persoon = new Person("Jan Hendriksen");
            Persoon.Birthdate = "22-06-2007";
            Persoon.Address = "Amerikalaan 39";
            Persoon.Telephone = "Samsung Galaxy S24";
            Persoon.Email = "Mootjevandeblok@gmail.com";

            Console.WriteLine(Persoon);

            
        }
    }
}
