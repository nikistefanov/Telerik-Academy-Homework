//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Title = "Third digit is 7?";
        Console.WriteLine("Enter a three digit number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 100 || number > 999)
        {
            Console.WriteLine("No, no, no! Three digit number is expected: ");
            number = int.Parse(Console.ReadLine());
        }
        string star = new string('*', 40);
        Console.WriteLine(star);
        Console.Write(number + "--->");
        Console.WriteLine((number /= 100) == 7);
        
        
    }
}
