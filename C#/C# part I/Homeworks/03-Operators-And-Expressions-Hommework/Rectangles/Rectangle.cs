//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangle
{
    static void Main()
    {
        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());        
        Console.Write("Enter the height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(new string ('*', 40));
        double perimeter = (width * 2) + (height * 2);
        double area = width * height;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The perimeter of this rectangle is: {0}", perimeter);
        Console.WriteLine("The area of this retangle is: {0}", area);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(new string('*', 40));
        Console.ForegroundColor = ConsoleColor.Gray;

    }
}