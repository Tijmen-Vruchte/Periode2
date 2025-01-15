namespace _8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon person = new Persoon("Johan");

            person.Woonplaats = "Arnhem";
            

            Bankrekening rekening = new Bankrekening();
            rekening.Rekeningnummer = "KPN04812947A3D";
            rekening.Saldo = 170.8;
            rekening.Eigenaar = person;

            Console.WriteLine(rekening);


        }
    }
}
