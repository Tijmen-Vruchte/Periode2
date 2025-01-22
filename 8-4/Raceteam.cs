using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    public class Raceteam
    {
        private string teamNaam;
        private Persoon teamLeider;
        private Persoon eersteRijder;
        private Raceauto eersteAuto;
        private Persoon tweedeRijder;
        private Raceauto tweedeAuto;

        public Raceteam(string deNaam)
        {
            this.teamNaam = deNaam;
        }
        public string TeamNaam
        {
            get { return teamNaam; }
        }
        public Persoon TeamLeider
        {
            get { return teamLeider; }
            set { teamLeider = value; }
        }
        public Persoon EersteRijder
        {
            get { return eersteRijder; }
            set { eersteRijder = value; }

        }
        public Raceauto EersteAuto
        {
            get { return eersteAuto; }
            set { eersteAuto = value; }
        }
        public Persoon TweedeRijder
        {
            get { return tweedeRijder; }
            set { tweedeRijder = value; }
        }
        public Raceauto TweedeAuto
        {
            get { return tweedeAuto; }
            set { tweedeAuto = value; }
        }
        public override string ToString()
        {
            return "-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                   "Naam= " + TeamNaam + "\nTeamleider= " + teamLeider.Naam + "\nEerste rijder= " + eersteRijder.Naam + "\nEerste auto= " + eersteAuto.Racenummer + "\nTweede rijder= " + tweedeRijder.Naam + "\nTweede auto= " + tweedeAuto.Racenummer + "\n" +
                   "-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-\n";
        }
    }
}