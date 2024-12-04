namespace Opdracht_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Lamp lamp = new Lamp();
            lamp.SetAanuit(true);
            lamp.SetLichtsterkte(60);

            if (lamp.GetAanuit() == true)
            {
            Console.WriteLine( "  De lamp is aan en heeft een lichtsterkte van " +
                ""+ lamp.GetLichtsterkte() + " procent.");

            }
            else
            {
                Console.WriteLine("De lamp staat uit");
            }

                

            
  
        }
    }
}
