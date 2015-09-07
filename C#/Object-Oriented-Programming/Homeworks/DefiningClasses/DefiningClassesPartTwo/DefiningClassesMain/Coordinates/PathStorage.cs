namespace Coordinates
{
    using System.IO;
    using System.Linq;

    //Problem 4.
    //Create a static class PathStorage with static methods to save and load paths from a text file.
    //Use a file format of your choice.
    public static class PathStorage
    {
        public static void SavePath(Point3D point)
        {
            StreamWriter savePath = new StreamWriter(@"..\..\Files\Paths.txt", true);
            using (savePath)
            {
                savePath.WriteLine(point.ToStringForFile());
            }
        }
        public static Path LoadPaths(string filePath)
        {
            Path listOfPaths = new Path();
            StreamReader reader = new StreamReader(filePath);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    double[] coordinates = line.Split(' ').Select(double.Parse).ToArray();
                    Point3D point = new Point3D(coordinates[0], coordinates[1], coordinates[2]);
                    listOfPaths.AddPoint(point);
                    line = reader.ReadLine();
                }
            }
            return listOfPaths;
        }
    }
}
