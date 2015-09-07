namespace Coordinates
{
    //Problem 1. Structure
    //Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    //Implement the ToString() to enable printing a 3D point

    //Problem 2. Static read-only field
    //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
    //Add a static property to return the point O.
    public struct Point3D
    {
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartPoint
        {
            get
            {
                return startingPoint;
            }
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        
        public string ToStringForFile()
        {
            return string.Format("{0} {1} {2}", this.X, this.Y, this.Z);
        }

        public override string ToString()
        {
            return string.Format("X = {0,-3} | Y = {1,-3} | Z = {2,-3}", this.X, this.Y, this.Z);
        }
    }
}
