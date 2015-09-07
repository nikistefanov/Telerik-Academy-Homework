//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoid
{
    static void Main()
    {
        Console.Write("Enter side A of the trapezoid: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Enter side B of the trapezoid: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the trapezoid: ");
        double height = double.Parse(Console.ReadLine());
        


        double area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area of this trapezoid is {0}!", area);
    }
}
