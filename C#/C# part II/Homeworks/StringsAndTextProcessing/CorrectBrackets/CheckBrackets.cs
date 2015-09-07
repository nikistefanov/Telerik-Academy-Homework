//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CheckBrackets
{
    static void IsBracketsPutCorrect(string textToCheck)
    {
        int closeBracket = textToCheck.IndexOf(')');
        int openBracket = textToCheck.IndexOf('(');

        if (closeBracket < openBracket)
        {
            Console.WriteLine("NO! Brackets are put incorrectly!");
            Environment.Exit(0);
        }
        else
        {
            int counter = 0;
            for (int i = 0; i < textToCheck.Length; i++)
            {
                if (textToCheck[i] == '(') counter++;
                if (textToCheck[i] == ')') counter--;
            }
            if (counter == 0) Console.WriteLine("Brackets are put correctly.");
            else Console.WriteLine("NO! Brackets are put incorrectly!");
        }
    }

    static void Main()
    {
        Console.Write("Please, enter an expression: ");
        string text = Console.ReadLine();
        //string text = "((a+b)/5-d))";

        IsBracketsPutCorrect(text);
    }
}
