using System.Security.Cryptography.X509Certificates;

namespace Opdracht_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefoon Telefoon = new Telefoon();
            Telefoon.SetMerk("Samsung");
            Telefoon.SetTelefoonType("S24");
            Telefoon.SetPrijs(376);

            Telefoon Telefoon2 = new Telefoon();
            Telefoon2.SetMerk("Apple");
            Telefoon2.SetTelefoonType("12");          
            Telefoon2.SetPrijs(259);

            Telefoon.Tooninfo();
            Telefoon2.Tooninfo();

           
        }
    }
}
