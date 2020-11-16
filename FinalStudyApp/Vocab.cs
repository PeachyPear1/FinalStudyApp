using System;
using static System.Console;
using System.IO;

namespace FinalStudyApp
{

    class Vocab
    {
        private string TermFile = "terms.txt";
        private string DefinitionFile = "definitions.txt";
        private string Content1 = "[Empty Term.]";
        private string Content2 = "[Empty Definition.]";

        public Vocab()
        {

        }

        public void QuizTerm()
        {
            if (File.Exists(TermFile) && File.Exists(DefinitionFile))
            {
                Content1 = File.ReadAllText(TermFile);
                Content2 = File.ReadAllText(DefinitionFile);
            }
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Here is a preview of all the terms:\n");
            ResetColor();
            WriteLine(Content1);
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("\n\n\nPress enter to preview all the definitions.");
            ResetColor();
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Here is a preview of all the definitons:\n");
            ResetColor();
            WriteLine(Content2);
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n\nReady to move on to the quiz?");
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
                Question.Quiz();
            }
            else if (Input == 2)
            {
                WriteLine("\n\nOh, you want to preview the vocab again? Ok!");
                Utils.Wait();
                Clear();
                QuizTerm();
            }
        }
    }
}
