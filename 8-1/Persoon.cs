using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    public class Persoon
    {
        private string name;
        private string woonplaats;

        public Persoon(string Dename)
        {
            this.name = Dename;

        }
        public string Dename
        {
            get { return name; }
        }
        public string Woonplaats
        {
            get
            {
                return woonplaats;

            }
            set
            {
               woonplaats = value;
            }
        }
    }
}
