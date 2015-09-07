namespace PrintArrayStatistics
{
    using System;
    using System.Linq;

    public class Printer
    {
        public Printer()
        {
        }

        public void PrintStatistics(double[] arr, int count)
        {
            double max = arr.Max();

            this.Print("Max number", max);

            double min = arr.Min();

            this.Print("Min number", min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            this.Print("Average sum", sum / count);
        }

        private void Print(string name, double value)
        {
            Console.WriteLine("{0}: {1:F2}",name, value);
        }
    }

}
