//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
using System.Threading;
using System.Globalization;

class CirclePerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * (radius * Math.PI);
        double area = Math.PI * radius * radius;
        Console.WriteLine("Perimeter is -> {0:F2}", perimeter);
        Console.WriteLine("Area is -> {0:F2}",area);

    }
}
