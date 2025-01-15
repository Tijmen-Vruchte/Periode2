using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    public class Bankrekening
    {
        private string rekeningnummer;
        private double saldo;
        private Persoon eigenaar;

        public string Rekeningnummer
        {
            get
            {
                return rekeningnummer;
            }
            set
            {
                rekeningnummer = value;
            }
        }
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        public Persoon Eigenaar
        {
            get
            {
                return eigenaar;
            }
            set
            {
                eigenaar = value;
            }

        }
        public override string ToString()
        {
            return "rekeningnummer = " + rekeningnummer + "\nSaldo = $"+ saldo + " \nEigenaar = "+ eigenaar.Dename+ "\nWoonplaats = "+ eigenaar.Woonplaats+ "";
        }
    }
}
