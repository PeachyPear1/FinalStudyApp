using System;
using static System.Console;

namespace FinalStudyApp
{
    static class Utils
    {
        public static void Wait()
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Press enter to continue.");
            ResetColor();
            ReadKey();
        }

        public static void Quit()
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("Press enter to exit.");
            ResetColor();
            ReadKey();
            Environment.Exit(0);
        }
    }
}
