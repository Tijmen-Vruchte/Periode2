using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToetsWeek4
{
    public class bootgegevens
    {
        private string merk;
        private double lengte;
        private double breedte;
        private double hoogte;
        private double diepgang;
        private int maximalesnelheid;

        public bootgegevens(string HetMerk)
        {
            this.merk = HetMerk;
        }
        public string HetMerk
        {
            get
            {
                return merk;
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
        public double Breedte
        {
            get
            { 
                return breedte;
            }
            set
            {
              breedte = value;
            }
        }
        public double Hoogte
        {
            get
            {
                return hoogte;
            }
            set
            {
                hoogte = value;
            }
        }
        public double Diepgang
        {
            get
            {
              return diepgang;
            }
            set
            {
                diepgang = value;
            }
        }
        public int Maximalesnelheid
        {
            get
            {
                return maximalesnelheid;
            }
            set
            {
                maximalesnelheid = value;
            }
        }
        public string BootInfo()
        {
            return "***************************\nMerk: " + merk + "\nlxbxh: " + lengte + " x " + breedte + " x " + hoogte +
                " m\nDiepgang: " + diepgang + " m\nMaximale snelheid: " + maximalesnelheid + " knopen\n***************************";
            
        }
        public override string ToString()
        {
            return "Merk: " + merk + "\nMaximale snelheid: " + maximalesnelheid;
        }
        public double BerekenAfstand(double tijd)
        {
                      
            
            return maximalesnelheid * tijd;
        }


    }
}
