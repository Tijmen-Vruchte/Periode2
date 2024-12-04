using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_6
{
    internal class Telefoon
    {
        private string merk;
        private string type;
        private double prijs;
        public void SetMerk(string Merk)
        {
            this.merk = Merk;
        }
        public string GetMerk()
        {
            return this.merk;
        }
        public void SetTelefoonType(string Type)
        {
            this.type = Type;
        }
        public string GetTelefoonType()
        {
            return this.type;
        }
        public void SetPrijs(double Prijs)
        {
            this.prijs = Prijs;
        }
        public double GetPrijs() {
            return this.prijs;
        }
        public void Tooninfo()
        {
            Console.WriteLine("Het merk van de telefoon is " + this.GetMerk() +
           " en het type " +this.GetTelefoonType() + "e n de prijs is " +this.GetPrijs() + " euro.");
        }
    }
}