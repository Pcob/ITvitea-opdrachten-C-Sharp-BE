using System;
using System.ComponentModel;

namespace Csharp
{
  
    public class ExerciseTwelve
    {
        static void Main(string[] args)
        {
            int Aantalstrips, intSom;
            double btw, btwbedrag, totaalbedrag;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Wat is je naam?: ");
            String naam = Console.ReadLine();
            Console.Write("Geef het aantal strips in: ");
            Aantalstrips = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("##########################################" +
                "");

            btw = 1.06;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("U wordt geholpen door: " + naam);

            intSom = (Aantalstrips * 5);
            btwbedrag = (intSom * btw);
            totaalbedrag = (intSom + btwbedrag);



            Console.WriteLine("Eenheidsprijs exclusief BTW = 5 EUR: " + intSom.ToString());
            Console.WriteLine("Aantal = " + Aantalstrips);
            Console.WriteLine("Subtotaal exclusief BTW = " + Aantalstrips * 5);
            Console.WriteLine("BTW-tarief = 6 % ");
            Console.WriteLine("BTW bedrag = " + btwbedrag);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Totaal inclusief BTW = " + totaalbedrag);
            Console.ReadKey();
        }
    }
}
