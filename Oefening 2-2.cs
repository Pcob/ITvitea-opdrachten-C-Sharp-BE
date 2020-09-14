using System;

namespace Csharp
{ 
 
    public class ExerciseTwo
    {
        static public void Second()
        {
            int intGetal1, intSom;

            Console.Write("Type Temperatuur in Celsius: ");
            intGetal1 = Convert.ToInt16(Console.ReadLine());

            intSom = (9 / 5) * intGetal1 + 32;

            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("De Temperatuur in Fahrenheit bedraagt: " + intSom.ToString());
            Console.ReadLine();

        }
    }
}
