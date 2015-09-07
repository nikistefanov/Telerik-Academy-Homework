namespace RefactorPrinter
{
    using System;

    class Printer
    {
        const int MAX_COUNT = 6;

        public static void Main()
        {
            Print consoleWriter = new Print();
            consoleWriter.PrintBoolean(true);

        }
    }
}
