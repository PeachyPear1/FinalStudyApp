using System;
using static System.Console;

namespace FinalStudyApp
{
    class App
    {
        public App()
        {

        }

        public void Start()
        {
            Title = "Studying for Intro to Programming by Hannah Hamilton";
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine(@"       .--.                   .---.
   .---|__|           .-.     |~~~|
.--|===|--|_          |_|     |~~~|--.
|  |===|  |'\     .---!~|  .--|   |--|
|%%|   |  |.'\    |===| |--|%%|   |  |
|%%|   |  |\.'\   |   | |__|  |   |  |
|  |   |  | \  \  |===| |==|  |   |  |
|  |   |__|  \.'\ |   |_|__|  |~~~|__|
|  |===|--|   \.'\|===|~|--|%%|~~~|--|
^--^---'--^    `-'`---^-^--^--^---'--'");
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine(@"
   _____ __            __         _____           __  
  / ___// /___  ______/ /_  __   / ___/___  _____/ /_ 
  \__ \/ __/ / / / __  / / / /   \__ \/ _ \/ ___/ __ \
 ___/ / /_/ /_/ / /_/ / /_/ /   ___/ /  __(__  ) / / /
/____/\__/\__,_/\__,_/\__, /   /____/\___/____/_/ /_/ 
                     /____/                           
");
            ForegroundColor = ConsoleColor.Red;
            WriteLine(String.Format("{0, -10}   {1, -10}", " ", "Press enter to begin!"));
            ResetColor();
            ReadKey();
        }

        public void Rules()
        {
            Clear();
            WriteLine("In this application, you will be quizzed on Intro to Programming terminology.\nYou will recieve a score at the end of the quiz.\nFor each question, read all of the options.\nThen, type in a number to select your answer.");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n\n\nReady to move on to the preview?");
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("1.) Y or 2.) N");
            int Input = new int();
            int.TryParse(Console.ReadLine(), out Input);
            while (Input != 1 && Input != 2)
            {
                WriteLine("Please type in 1.) Y or 2.) N.");
                int.TryParse(Console.ReadLine(), out Input);
            }
            ResetColor();
            if (Input == 1)
            {
                Vocab myVocab = new Vocab();
                Clear();
                myVocab.QuizTerm();
            }
            else if(Input == 2)
            {
                WriteLine("\n\nOh, not ready to be quizzed yet? That's ok! Have a good day.");
                Utils.Quit();
            }
        }
    }
}
