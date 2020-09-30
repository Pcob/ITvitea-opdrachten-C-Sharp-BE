using System;
using System.ComponentModel;

namespace Csharp
{
  
    public class ExerciseTen
    {
        static void Main(string[] args)
        {
            double Inkoopprijs, winstmarge, intSom;
            

            Console.WriteLine("Berekening van winstmarge op inkoopprijzen");
            Console.Write("Type inkoopprijs: ");
            Inkoopprijs = Convert.ToInt32(Console.ReadLine());
            winstmarge = 1.90;
           

            intSom = (Inkoopprijs / 100 * 190);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Winstmarge is: " + intSom.ToString());
            Console.ReadKey();
        }
    }
}
