using System;

namespace Csharp
{
  
    public class ExerciseEight
    {
        static public void Main()
        {
            int a, intSom;
            Double b;

            Console.WriteLine("Prijzen berekenen van auto's inclusief btw naar exclusief btw: ");
            Console.Write("Typ prijs mercedes inclusief BTW: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = 1.21;
            

            intSom = a / (int)b;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Prijs mercedes exclusief btw is: " + intSom.ToString());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
