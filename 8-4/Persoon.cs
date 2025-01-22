using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    public class Persoon
    {
        private string naam;
        private int leeftijd;
        private string functie;


        public Persoon(string Naam)
        {
            this.naam = Naam;
        }
        public string Naam
        {
            get { return naam; }
        }
        public int Leeftijd
        {
            get { return leeftijd; }
            set { leeftijd = value; }
        }
        public string Functie
        {
            get { return functie; }
            set { functie = value; }
        }



    }
}
