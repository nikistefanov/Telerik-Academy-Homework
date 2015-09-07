//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Threading;
using System.Globalization;

class PlayWithTypes
{
    static void Main()
    {
        static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine(@"
Please choose a type:	
1 --> int	
2 --> double	
3 --> string");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": Console.Write("Please enter a integer here: ");
                int numberInt = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(numberInt);
                break;
            case "2": Console.Write("Please enter a double here: ");
                double numberDouble = double.Parse(Console.ReadLine()) + 1;
                Console.WriteLine(numberDouble);
                break;
            case "3": Console.Write("Please enter a text here: ");
                string text = Console.ReadLine() + "*";
                Console.WriteLine(text);
                break;
            default: Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Invalid choice, mate");
                Console.ResetColor();
                break;
        }
    }
}