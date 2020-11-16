using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace FinalStudyApp
{
    class Question
    {
        static string Term;
        static string ChoiceA;
        static string ChoiceB;
        static string ChoiceC;
        static Random myRandom = new Random();

        public Question()
        {
            
        }

        static string getTerm()
        {
            string[] term = new string[] { "Static", "String", "Double", "Interpolation", "Do-While Loop", "Private", "Public", "Void", "While Loop", "For Loop", "Increment", "Switch", "Array", "List", "Conditional Statement" };
            return term[getRandomNumber(term.Length)];
        }

        static string getChoiceA()
        {
            string[] choiceA = new string[] { "If-else statements", "A string of characters", "A large number that can include a decimal", "A modifier in C#", "A modifier in C# that doesn't allow access to other parts of the program", "A loop, uses do and while, runs at least once regardless of anything", "A loop that uses while", "A modifier in C# that implies there is no instanization", "Allows testing against a list of values, creates cases and breaks", "A modifier in C# that allows access to other parts of the program", "Refers to a string, utilizes the symbol $, defines the string as an interpolated string", "Done by ++", "A loop that uses for", "Stores multiple values and can have a limitless amount added", "Stores multiple values at a defined amount" };
            return choiceA[getRandomNumber(choiceA.Length)];
        }

        static string getChoiceB()
        {
            string[] choiceB = new string[] { "If-else statements", "A string of characters", "A large number that can include a decimal", "A modifier in C#", "A modifier in C# that doesn't allow access to other parts of the program", "A loop, uses do and while, runs at least once regardless of anything", "A loop that uses while", "A modifier in C# that implies there is no instanization", "Allows testing against a list of values, creates cases and breaks", "A modifier in C# that allows access to other parts of the program", "Refers to a string, utilizes the symbol $, defines the string as an interpolated string", "Done by ++", "A loop that uses for", "Stores multiple values and can have a limitless amount added", "Stores multiple values at a defined amount" };
            return choiceB[getRandomNumber(choiceB.Length)];
        }

        static string getChoiceC()
        {
            string[] choiceC = new string[] { "If-else statements", "A string of characters", "A large number that can include a decimal", "A modifier in C#", "A modifier in C# that doesn't allow access to other parts of the program", "A loop, uses do and while, runs at least once regardless of anything", "A loop that uses while", "A modifier in C# that implies there is no instanization", "Allows testing against a list of values, creates cases and breaks", "A modifier in C# that allows access to other parts of the program", "Refers to a string, utilizes the symbol $, defines the string as an interpolated string", "Done by ++", "A loop that uses for", "Stores multiple values and can have a limitless amount added", "Stores multiple values at a defined amount" };
            return choiceC[getRandomNumber(choiceC.Length)];
        }

        static int getRandomNumber(int range)
        {
            return myRandom.Next(range);
        }

        public static void Quiz()
        {
            Clear();
            Question.Term = getTerm();
            Question.ChoiceA = getChoiceA();
            Question.ChoiceB = getChoiceB();
            Question.ChoiceC = getChoiceC();
            WriteLine($"Question: What does {Term} mean?\n1.) {ChoiceA}\n2.) {ChoiceB}\n3.) {ChoiceC}");
            Utils.Wait();
        }
    }
}
