namespace _8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adres adres = new Adres("Johan");
            adres.Straat = "Kerkstraat";
            adres.Huisnummer = "12";
            adres.Postcode = "1234AB";
            adres.Woonplaats = "Arnhem";

            Console.WriteLine(adres);
        }
    }
}
