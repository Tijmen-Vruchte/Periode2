using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    public class Motorfiets
    {
        private string merk;
        private string model;
        private string koffersetmerk;
        private double inhoud;

        public Motorfiets(string deMerk)
        {
            this.merk = deMerk;
        }

        public string Merk
        {
            get { return merk; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Koffersetmerk
        {
            get { return koffersetmerk; }
            set { koffersetmerk = value; }
        }

        public double Inhoud
        {
            get { return inhoud; }
            set { inhoud = value; }
        }

        public override string ToString()
        {
            return "-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                   "Merk= " + merk + " Model= " + model + " Koffersetmerk= " + koffersetmerk + " Inhoud= " + inhoud + " liter\n" +
                   "-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-\n";
        }
    }
}
