using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _4_5
{
    public class Auto
    {
        private string merk;
        private string kleur;
        private int maxsnelheid;
        private int huidigesnelheid;

        public Auto(string hetmerk)
        {
            this.merk = hetmerk;
        }

        public Auto(string hetmerk, string dekleur)
        {
            this.merk = hetmerk;
            this.kleur = dekleur;
        }

        public string Merk
        {
            get { return merk; }
            //set { merk = value; }
        }
        public string Kleur
        { get { return kleur; } set { kleur = value; } }

        public int Maxsnelheid
        {
            get { return Maxsnelheid; }
            set { maxsnelheid = value; }

        }
        public int Huidigesnelheid
        {
            get { return huidigesnelheid; }
            set { huidigesnelheid = value; }



        }
        public override string ToString()
        {
           
            string tekst = "Merk: " + Merk + "\n Max Snelheid " + maxsnelheid + "\n Huidige snelheid: " + huidigesnelheid +
            "\n Kleur: " + kleur + ".";
            return tekst;
        }
    }
}
