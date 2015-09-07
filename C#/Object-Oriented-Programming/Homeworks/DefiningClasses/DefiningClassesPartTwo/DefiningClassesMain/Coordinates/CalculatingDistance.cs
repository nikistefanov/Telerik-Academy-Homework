namespace Coordinates
{
    using System;
    
    //Problem 3. Static class
    //Write a static class with a static method to calculate the distance between two points in the 3D space.

    public static class CalculatingDistance
    {
        //TODO:
        //http://www.calculatorsoup.com/calculators/geometry-solids/distance-two-points.php

        public static double CalculateDistanceBetweenPoints (Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow((secondPoint.X - firstPoint.X), 2) + Math.Pow((secondPoint.Y - firstPoint.Y), 2) + Math.Pow((secondPoint.Z - firstPoint.Z), 2));
            return distance;
        }
    }
}
