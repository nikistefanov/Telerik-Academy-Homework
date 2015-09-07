using MobilePhones;
using System;


namespace MoblePhones
{
    class GSMCallHistoryTest
    {

        //Problem 12. Call history test
        //Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        //Create an instance of the GSM class.
        //Add few calls.
        //Display the information about the calls.
        //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        //Remove the longest call from the history and calculate the total price again.
        //Finally clear the call history and print it.
        
        public static GSM CallHistory()
        {
            Console.WriteLine(new string('=' , 60));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Now showing the call history!");
            Console.ResetColor();
            
            var phone = new GSM("Xperia Z2", "Sony", 1200.99M, "Rocho", new Battery(BatteryType.LiIon), new Display(5.1, 16000000), ColorOfPhones.Black);
            phone.AddCalls(new Call(DateTime.Parse("03/03/2003 12:00:44"), "0888454124", 154));
            phone.AddCalls(new Call(DateTime.Parse("02/04/2003 13:00:44"), "0899975412", 647));
            phone.AddCalls(new Call(DateTime.Parse("06/10/2003 23:40:44"), "0894526475", 345));

            var callMoney = phone.TotalPriceOfCalls();

            Console.WriteLine("Total calls price: {0:F2} лв.", callMoney);


            Call longestCall = new Call(DateTime.Parse("06/10/2003 23:40:44"), "", 0);
            foreach (var call in phone.CallHistory)
            {
                if (call.DurationInSeconds > longestCall.DurationInSeconds)
                {
                    longestCall = call;
                }
            }
            phone.DeleteCalls(longestCall);
            callMoney = phone.TotalPriceOfCalls();
            Console.WriteLine("Total calls price without the longest call: {0:F2} лв.", callMoney);
            phone.ClearCalls();
            Console.WriteLine("Call histroy has been cleared!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This test was done on this device:");
            Console.ResetColor();

            return phone;
        }
    }
}
