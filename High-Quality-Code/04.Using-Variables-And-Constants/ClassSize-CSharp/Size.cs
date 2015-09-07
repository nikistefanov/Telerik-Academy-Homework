namespace SizeOperations
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public Size GetRotatedSize(Size size, double figureAngle)
        {
            double figureAngleCos = Math.Abs(Math.Cos(figureAngle));
            double figureAngleSin = Math.Abs(Math.Sin(figureAngle));

            double width = (figureAngleCos * size.Width) + (figureAngleSin * size.Height);
            double height = (figureAngleSin * size.Width) + (figureAngleCos * size.Height);

            return new Size(width, height);
        }

        public override string ToString()
        {
            return String.Format("Width: {0:F2}, Height: {1:F2}", this.Width, this.Height);
        }
    }
}
