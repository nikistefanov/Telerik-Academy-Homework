//123	    2 4
//10000	    3 1
//987654	3 21
//5005005	4 10
//200000000	5 2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Horror
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int counter = 0;
            int evenCounter = 0;
            int sumEven = 0;

            foreach (char symbol in text)
            {
                if (counter % 2 == 0)
                {
                    if (Char.IsDigit(symbol))
                    {
                        evenCounter++;
                        sumEven += symbol - '0';
                    }

                }
                counter++;
            }
            Console.WriteLine("{0} {1}", evenCounter, sumEven);
        }
    }
}
