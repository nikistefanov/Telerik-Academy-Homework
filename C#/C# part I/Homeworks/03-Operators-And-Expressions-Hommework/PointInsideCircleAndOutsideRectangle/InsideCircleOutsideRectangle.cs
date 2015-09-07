//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("Enter value for X= ");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter value for Y= ");
        double pointY = double.Parse(Console.ReadLine());
        double radius = 2;

        bool inCircle;
        bool outRectangle;
       
        if (Math.Pow((pointY - 1), 2) + Math.Pow((pointX - 1), 2) <= Math.Pow(radius, 2))

        {
            inCircle = true;
        }
        else
        {
            inCircle = false;
        }

        if (pointY > 1 && pointX > -0.5 && pointX < 2.5)
        {
            outRectangle = true;
        }
        else
        {
            outRectangle = false;
        }
        
        if (inCircle && outRectangle)
        {
            Console.WriteLine("X and Y are inside the circle and outside the rectangle!");
        }
        else
        {
            Console.WriteLine("They are NOT inside the circle and outside the rectangle!");
        }
    }
}
