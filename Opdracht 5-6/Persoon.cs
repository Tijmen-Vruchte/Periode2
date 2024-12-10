using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_6
{
    public class Persoon
    {
        private string johannes;
        private string petra;
        private string kevin;

        public string Johannes
        {
            get { return johannes; }
            set { johannes = value; }
        }
        public string Petra
        {
            get { return petra; }  
            set { petra = value; }
        }
        public string Kevin
        {
            get { return kevin; }
            set { kevin = value; }
        }
        public override string ToString()
        {
            string Namen = "Naam1 is " + johannes + ".";
            return Namen;
            
        }
    }
}
