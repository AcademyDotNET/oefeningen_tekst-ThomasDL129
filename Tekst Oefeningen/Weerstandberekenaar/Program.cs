using System;

namespace Weerstandberekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Wat is de kleurcode van de 1ste ring?");
            int tientallen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Wat is de kleurcode van de 2de ring?");
            int eenheden = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Wat is de kleurcode van de 3de ring?");
            int macht = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"De weerstand bedraagt {Calculator(tientallen, eenheden, macht)} Ohm\n");

            PrintTabel(tientallen, eenheden, macht);
        }
        public static long Calculator(int tientallen, int eenheden, int macht)
        {
            long result = Convert.ToInt64((tientallen*10 + eenheden) * Math.Pow(10, macht));
            return result;
        }

        public static void PrintTabel(int tientallen, int eenheden, int macht)
        {
            Console.WriteLine("╔═══════════════╦═══════════════╗");
            ColourChanger(tientallen);
            Console.WriteLine($"║ Ring 1        ║        {tientallen}      ║");
            ColourChanger(10);
            Console.WriteLine("╟───────────────╫───────────────╢");
            ColourChanger(eenheden);
            Console.WriteLine($"║ Ring 2        ║        {eenheden}      ║");
            ColourChanger(10);
            Console.WriteLine("╟───────────────╫───────────────╢");
            ColourChanger(macht);
            Console.WriteLine($"║ Ring 3        ║        {macht}      ║");
            ColourChanger(10);
            Console.WriteLine("╚═══════════════╩═══════════════╝");
        }
        public static void ColourChanger(int colour)
        {
            switch (colour)
            {
                case 0: 
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case 8:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 9:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }
        }
    }
}
