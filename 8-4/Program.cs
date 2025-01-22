namespace _8_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raceteam Raceteam1 = new Raceteam("Eppinka");
            Raceteam1.TeamLeider = new Persoon("Eppie");
            Raceteam1.TeamLeider.Leeftijd = 45;
            Raceteam1.TeamLeider.Functie = "Teamleider";
            Raceteam1.EersteRijder = new Persoon("Klaas");
            Raceteam1.EersteRijder.Leeftijd = 35;
            Raceteam1.EersteRijder.Functie = "Rijder";
            Raceteam1.EersteAuto = new Raceauto(1);
            Raceteam1.TweedeRijder = new Persoon("Piet");
            Raceteam1.TweedeRijder.Leeftijd = 40;
            Raceteam1.TweedeRijder.Functie = "Rijder";
            Raceteam1.TweedeAuto = new Raceauto(2);
            Console.WriteLine(Raceteam1);
        }
    }
}
