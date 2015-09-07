//Problem 1. Define class
//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

using System;
using System.Globalization;
using System.Threading;

namespace MoblePhones
{
    class MobilePhonesMain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var phonesInfo = new GSMTest();
            phonesInfo.Testing();
            var phoneCalls = GSMCallHistoryTest.CallHistory();
            Console.WriteLine(phoneCalls);
        }
    }
}
