using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_4
{
    public class Circle
    {
        private double diameter;
        private double radius;
        private double area;
        private string kleur;

        public string Kleur
        {
            get
            {
                return kleur;

            }
            set
            {
                kleur = value;
            }
        }

        public double Diameter
        {
            get
            {
                { return diameter; }
            }
            set
            {
                diameter = value;
            }


        }
        public double Radius
        {
            get
            {
                { return radius; }
            }
            set
            {

                radius = value;
                Diameter = radius * 2;
                Area = Math.PI * Math.Pow(radius, 2);

            }
        }
        public double Area
        {
            get
            {
                return area;
            }
            set { area = value; }
        }
        public void print()
        {
            Console.WriteLine("Deze cirkel heeft een diameter van " + diameter + " meter en een oppervlakte van " + Math.Round(area, 3) + " meter2 en de kleur is " + kleur + ".");
        }







    }
}
