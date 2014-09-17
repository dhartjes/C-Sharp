using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstants
{
    class Program
    {
        enum Color
        {
            Red,
            Orange,
            Green,
            Blue,
            Indigo,
            Violet
        }

        static void Main(string[] args)
        {
            Color favorite = Color.Blue;

            switch(favorite)
            {
                case Color.Blue:
                    Console.WriteLine("You chose Blue");
                    break;
                case Color.Green:
                    Console.WriteLine("You chose Green");
                    break;
                case Color.Indigo:
                    Console.WriteLine("You chose Indigo");
                    break;
                case Color.Orange:
                    Console.WriteLine("You chose Orange");
                    break;
                case Color.Red:
                    Console.WriteLine("You chose Red");
                    break;
                case Color.Violet:
                    Console.WriteLine("You chose Violet");
                    break;
                default:
                    Console.WriteLine("You didn't choose a color.");
                    break;
            }
        }
    }
}
