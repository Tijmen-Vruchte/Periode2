using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_4
{
    public class Persoon
    {
        private string Naam;
        private int geboortejaar;

        public void SetNaam(string naam)
        {
            this.Naam = naam;
        }
        public string GetNaam()
        {
            return this.Naam;
        }
        public void SetGeboorteJaar(int geboortejaar)
        {
            this.geboortejaar = geboortejaar;
        }
        public int GetGeboorteJaar()
        {
            return this.geboortejaar;

        }
    }
}
