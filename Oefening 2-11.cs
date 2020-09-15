using System;
using System.ComponentModel;

namespace Csharp
{
  
    public class ExerciseTwelve
    {
        static void Main(string[] args)
        {
            int Omzet, intSom;
            double variable, vastmaandwedde;

            Console.WriteLine("Bereken maandwedde: ");
            Console.Write("Geef het omzetbedrag van deze maand weer: ");
            Omzet = Convert.ToInt32(Console.ReadLine());

            variable = 1.825;
            vastmaandwedde = 958.36;




            Console.WriteLine("Het maandwedde bedrag is: " + vastmaandwedde + (Omzet * variable));
            Console.ReadKey();
        }
    }
}
