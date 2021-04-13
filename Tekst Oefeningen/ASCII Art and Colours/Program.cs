using System;

namespace ASCII_Art_and_Colours
{
    class Program
    {
        static void Main(string[] args)
        {
            //had de opdracht niet direct begrepen
            /*
            string art1 = @"#######                                    
   #    #    #  ####  #    #   ##    ####  
   #    #    # #    # ##  ##  #  #  #      ";
            string art2 = @"   #    ###### #    # # ## # #    #  ####  
   #    #    # #    # #    # ######      # ";
            string art3 = @"   #    #    # #    # #    # #    # #    # 
   #    #    #  ####  #    # #    #  ####  ";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(art1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(art2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(art3);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
            */

            Console.Write(@"#######                                    
   #    #    #  ####  #    #   ##  ");
            LetterColorChanger(@"  ####  ");
            Console.Write(@"   #    #    # #    # ##  ##  #  # ");
            LetterColorChanger(@" #      ");
            Console.Write(@"   #    ###### #    # # ## # #    #");
            LetterColorChanger(@"  ####  ");
            Console.Write(@"   #    #    # #    # #    # ######");
            LetterColorChanger(@"      # ");
            Console.Write(@"   #    #    # #    # #    # #    #");
            LetterColorChanger(@" #    # ");
            Console.Write(@"   #    #    #  ####  #    # #    #");
            LetterColorChanger(@"  ####  ");
        }

        public static void LetterColorChanger(string art)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(art);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
