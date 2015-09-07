namespace SizeOperations
{
    using System;

    public class ClassSizeCSharp
    {
        public static void Main()
        {
            var figure = new Size(23.0, 7.0);
            var sizeAfterRotation = figure.GetRotatedSize(figure, 13.5);

            Console.WriteLine(figure);
            Console.WriteLine(sizeAfterRotation);
        }
    }
}
