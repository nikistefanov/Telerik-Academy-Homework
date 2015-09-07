//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class SurfaceOfTriagnle
{
    static void SurfaceWithThreeSides(double sideOne, double sideTwo, double sideThree)
    {
        double p = (sideOne + sideTwo + sideThree) / 2;
        double area = Math.Sqrt((double)(p * (p - sideOne) * (p - sideTwo) * (p - sideThree)));
        Console.WriteLine("The ares is {0:F2}", area);
    }

    static void SurfaceWithAltitude(double side, double altitude)
    {
        double area = (side * altitude) / 2;
        Console.WriteLine("The ares is {0:F2}", area);
    }

    static void SurfaceWithAngle(double sideOne, double sideTwo, double degree)
    {
        double angle = Math.PI * degree / 180.0;
        double sinAngle = Math.Sin(angle);
        double area = (sideOne * sideTwo * sinAngle) / 2;
        Console.WriteLine("The ares is {0:F2}", area);
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        char[] separators = { ' ', '\t', '\n', '\\', '/' };

        Console.Write("Enter side A, side B, side C spearated by [space]: ");
        string inputToString = Console.ReadLine();
        string replacedInput = inputToString.Replace(",", ".");
        double[] sides = replacedInput.Split(separators).Select(double.Parse).ToArray();
        Console.Write("Now please enter heigth H and angle AB (separated by [space]): ");
        inputToString = Console.ReadLine();
        replacedInput = inputToString.Replace(",", ".");
        double[] heightAndAngle = replacedInput.Split(separators).Select(double.Parse).ToArray();

        Console.WriteLine("Pleas chose a method for calculating the area of a triangle.");
        Console.WriteLine(@"
1 - Three sides.
2 - Side and an altitude to it. 
3 - Two sides and an angle between them.");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: SurfaceWithThreeSides(sides[0], sides[1], sides[2]); break;
            case 2: SurfaceWithAltitude(sides[0], heightAndAngle[0]); break;
            case 3: SurfaceWithAngle(sides[0], sides[1], heightAndAngle[1]); break;
            default: Console.WriteLine("Invalid choice!"); break;
        }
    }

    static double RadianToDegree(double angle)
    {
        return angle * (180.0 / Math.PI);
    }
}

