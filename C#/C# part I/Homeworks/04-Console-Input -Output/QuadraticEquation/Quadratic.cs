//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class Quadratic
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());
        double x1 = 0;
        double x2 = 0;
        //b2-4ac
        double Discriminant = Math.Pow(b, 2) - 4 * (a * c);
        
        if (Discriminant < 0)
        {
            Console.WriteLine("Sorry! No real roots....Or not sorry :)");
        }
        
        else if (Discriminant == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        //[ -b ± √(b2-4ac) ] / 2a
        else
        {
            x1 = (-b - Math.Sqrt(Discriminant)) / (2 * a);
            x2 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
            Console.WriteLine("x1= {0}  |  x2= {1}", x1, x2);
        }
    }
}