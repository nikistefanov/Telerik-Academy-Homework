//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointsInCircle
{
    static void Main()
    {
        Console.Write("Enter value for X= ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter value for Y= ");
        double pointY = double.Parse(Console.ReadLine());
        double radius = 2;

        double pointXPow = Math.Pow(pointX, 2);
        double pointYPow = Math.Pow(pointY, 2);
        double radiusPow = Math.Pow(radius, 2);

        if (pointXPow + pointYPow <= radiusPow)
        {
            Console.WriteLine("X and Y are inside the circle!");
        }
        else
        {
            Console.WriteLine("They are NOT inside the circle!");
        }
    }
}
