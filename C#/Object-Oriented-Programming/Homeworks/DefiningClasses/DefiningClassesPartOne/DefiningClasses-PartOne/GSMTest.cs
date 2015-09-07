//Problem 7. GSM test

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

using MobilePhones;
using System;

namespace MoblePhones
{
    class GSMTest
    {
        public void Testing()
        {
            GSM[] phones = new GSM[3];
            phones[0] = new GSM("Galaxy S5", "Samsung", 950, "Vulcho", new Battery(BatteryType.LiIon), new Display(5.1, 16000000), ColorOfPhones.Gold);
            phones[1] = new GSM("Xperia Z3", "Sony", 1199, "Richerson", new Battery("Jundjun 3100 mAh", 890.0, 15.0), new Display(5.2, 16000000), ColorOfPhones.Black);
            phones[2] = new GSM("M9", "HTC", 1575, "Morerich Thanricherson", new Battery("Banzai 2840 mAh", 391.0, 25.20), new Display(5.0, 16000000), ColorOfPhones.White);

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
            }
            var iPhone = GSM.iPhone4S;
            Console.WriteLine(iPhone);
        }
    }
}
