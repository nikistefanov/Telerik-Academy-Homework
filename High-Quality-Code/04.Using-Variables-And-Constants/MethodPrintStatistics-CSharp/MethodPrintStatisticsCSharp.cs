namespace PrintArrayStatistics
{
    class MethodPrintStatisticsCSharp
    {
        static void Main()
        {
            var numbers = new double[] { 55.2, 12.0, 1.0, -5.0, 0.0, 75.6, 49.3 };
            var printer = new Printer();

            printer.PrintStatistics(numbers, 3);
        }
    }
}
