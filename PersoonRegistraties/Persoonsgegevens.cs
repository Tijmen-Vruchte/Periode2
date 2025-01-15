using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersoonRegistraties
{
    public class Persoonsgegevens
    {
        private string voornaam;
        private string achternaam;
        private int leeftijd;
        private double lengte;
        private double gewicht;

        public Persoonsgegevens (string DeVoorNaam, string DeAchternaam)
        {
            this.voornaam = DeVoorNaam;
            this.achternaam = DeAchternaam;
        }
        public string Voornaam
        {
            get
            {
                return voornaam;
            }
        }
        public string Achternaam
        {
            get
            {
                return achternaam;
            }
        }
       
        public int Leeftijd {
            get
            {
                return leeftijd;
            }
            set
            {
                leeftijd = value;
            }
        
        }
        public double Lengte
        {
            get
            {
                return lengte;
            }
            set
            {
                lengte = value;
            }
        }
        public double Gewicht
        {
            get
            {
                return gewicht;
            }
            set
            {
                gewicht = value;
            }
        }

        public override string ToString()
        {
            string tekst = "";
            if (lengte == 0)
            {
             tekst = "-=-=-=-=-=-=-=-=-=-=-=- \nNaam: " + Voornaam + " " + achternaam + "\nLengte: Onbekend. ";
            }
            else
            {
            tekst = "-=-=-=-=-=-=-=-=-=-=-=- \nNaam: " + Voornaam + " " + achternaam + "\nLengte: " + lengte;
            }
               
            return tekst;   
        }

        public string ToonInfo()
        {
            string tekst = "-=-=-=-=-=-=-=-=-=-=-=- \nNaam: " + Voornaam + " " + achternaam + "\nLeeftijd: " +
                "" + leeftijd + "\nLengte: " + lengte + " cm" + "\nGewicht: " + gewicht + " kg.\n-=-=-=-=-=-=-=-=-=-=-=-";
            return tekst;
        }

        public double BerekenBMI()
        {
            double meter = lengte / 100;
            return gewicht / (meter * meter);
           
            
        }



    }
}

