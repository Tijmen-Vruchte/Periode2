using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
   public class Adres
    {
        private string naam;
        private string straat;
        private string huisnummer;
        private string postcode;
        private string woonplaats;

        public Adres (string deNaam)
        {
            this.naam = deNaam;
        }
        public string Naam
        {
            get
            {
                return naam;
            }
        }
        public string Straat
        {
            get
            {
                return straat;
            }
            set
            {
                straat = value;
            }
        }
        public string Woonplaats
        {
            get
            {
                return woonplaats;
            }
            set
            {
                woonplaats = value;
            }
        }
        public string Postcode
        {
            get
            {
                return postcode;
            }
            set
            {
                postcode = value;
            }
        }
        public string Huisnummer
        {
            get
            {
                return huisnummer;
            }
            set
            {
                huisnummer = value;
            }
        }
        public override string ToString()
        {
            return "Naam= " + naam + " Woonplaats= " + woonplaats + "\n";
        }
    }
}
