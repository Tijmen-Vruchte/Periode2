using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    public class Raceauto
    {
        private string motormerk;
        private string topsnelheid;
        private double racenummer;
    
        public Raceauto(double racenummer)
        {
          this.racenummer = racenummer;
        }   
        public string Motormerk
        {
            get { return motormerk; }
            set { motormerk = value; }
        }
        public string Topsnelheid
        {
            get { return topsnelheid; }
            set { topsnelheid = value; }
        }
        public double Racenummer
        {
            get { return racenummer; }
            set { racenummer = value; }
        }
    }
}
