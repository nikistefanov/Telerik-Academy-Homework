using System;
using Coordinates;
using GenericSpace;

public class DefiningClassesMain
{
    public static void Main()
    {
        //From Problem 1 to 4:
        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Coordinates problem");
        Console.WriteLine(new string('=', 40));
        var point = new Point3D(6, 9, 72);
        var anotherPoint = new Point3D(5, 21, 4);
        var yetAnotherPoint = Point3D.StartPoint;
        double distance = CalculatingDistance.CalculateDistanceBetweenPoints(point, anotherPoint);
        Console.WriteLine("Distance between\nPoint: {0}\nPoint: {1}\nIs ==> {2:F3}", point.ToString(), anotherPoint.ToString(), distance);
        PathStorage.SavePath(anotherPoint);
        PathStorage.SavePath(point);
        PathStorage.SavePath(new Point3D(3, 5, 6));



        var listOfPoints = PathStorage.LoadPaths(@"..\..\Files\Paths.txt");
        Console.WriteLine("Paths stored in text file:");
        for (int i = 0; i < listOfPoints.Count; i++)
        {
            Console.WriteLine("Line {0, -3} : {1}", i + 1, listOfPoints[i]);
        }

        //From Problem 5 to 7:

        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Now Generics");
        Console.WriteLine(new string('=', 40));
        var elementsOfStrings = new GenericList<string>();

        elementsOfStrings.Add("ABC"); 
        elementsOfStrings.Add("A");
        elementsOfStrings.Add("c");
        elementsOfStrings.Add("KEkE");
        elementsOfStrings.Add("HI");
        Console.WriteLine("Before:");
        Console.WriteLine(elementsOfStrings.ToString());
        Console.WriteLine("After:");
        elementsOfStrings.InsertAt(3, "Just another test!");
        elementsOfStrings.RemoveAt(0); 
        Console.WriteLine(elementsOfStrings.ToString());

        var indexOfTest = elementsOfStrings.IndexOf("HI");
        var minElement = elementsOfStrings.Min();
        var maxElement = elementsOfStrings.Max();

        Console.WriteLine(@"
IndexOf ""HI"" is {0}
Min element is {1}
Max element is {2}", indexOfTest, minElement, maxElement);

        elementsOfStrings.Clear();
        Console.WriteLine(new string('=', 40));

   
    }
}
