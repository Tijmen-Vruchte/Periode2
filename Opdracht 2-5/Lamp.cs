using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_5
{
    public class Lamp
    {
        private bool AanUit;
        private int Lichtsterkte;
        public void SetAanuit(bool AanUit)
        {
            this.AanUit = AanUit;
        }
        public bool GetAanuit()
        {
            return this.AanUit;
        }
        public void SetLichtsterkte(int lichtsterkte)
        {
            this.Lichtsterkte = lichtsterkte;
        }
        public int GetLichtsterkte()
        {
            return this.Lichtsterkte;
        }
    } 
}
