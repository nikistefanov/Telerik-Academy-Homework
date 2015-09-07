namespace RefactorPrinter
{
    using System;

    class Print
    {
        public void PrintBoolean(bool value)
        {
            string boleanAsString = value.ToString();
            Console.WriteLine(boleanAsString);
        }
    }
}