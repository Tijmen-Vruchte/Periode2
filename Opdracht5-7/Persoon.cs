using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_7
{
    public class Persoon
    {
        private string naam;
        private int leeftijd;

        public string Naam
        {
            get; set;
        }
        public int Leeftijd
        {
            get; set;

        }

        public Persoon(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }
        public Persoon()
        {

        }
        public override string ToString()
        {
            string tekst = Naam + " is  " + Leeftijd + " jaar oud.";
            return tekst;
        }











    }
}