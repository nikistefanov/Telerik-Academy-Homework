using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FirstTask
{
    class Zerg
    {
        static void Main(string[] args)
        {
            string numberInZerg = Console.ReadLine();
            BigInteger numberInDecimal = 0;
            BigInteger power = 1;
            for (int i = numberInZerg.Length - 4; i >= 0; i -= 4)
            {
                string digit = numberInZerg.Substring(i, 4);
                int digitValue = GetDigitValue(digit);

                numberInDecimal += digitValue * power;
                power *= 15;
            }
            Console.WriteLine(numberInDecimal);
        }

        private static int GetDigitValue(string digit)
        {
            switch (digit)
            {
                case "Rawr": return 0;
                case "Rrrr": return 1;
                case "Hsst": return 2;
                case "Ssst": return 3;
                case "Grrr": return 4;
                case "Rarr": return 5;
                case "Mrrr": return 6;
                case "Psst": return 7;
                case "Uaah": return 8;
                case "Uaha": return 9;
                case "Zzzz": return 10;
                case "Bauu": return 11;
                case "Djav": return 12;
                case "Myau": return 13;
                case "Gruh": return 14;
                default: throw new ArgumentOutOfRangeException("Digit is outside the digit value");
            }
        }
    }
}