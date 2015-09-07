
namespace Coordinates
{
    using System.Collections.Generic;

    //Problem 4. Path
    //Create a class Path to hold a sequence of points in the 3D space.
    
    public class Path
    {
        private List<Point3D> sequence;

        public Path()
        {
            this.sequence = new List<Point3D>();
        }
        public void AddPoint(Point3D point)
        {
            this.sequence.Add(point);
        }
        public Point3D this[int index]
        {
            get { return this.sequence[index]; }
            set { this.sequence[index] = value; }
        }
        public int Count
        {
            get { return this.sequence.Count; }
        }
        public override string ToString()
        {
            return string.Format("{0}", this.sequence);
        }

    }
}
