using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FirstProblem
{
    class Program
    {
        static BigInteger Power(int number, int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            string numberInCatiz = Console.ReadLine();

            //string numberInCatiz = "miao miao miao";
            List<string> cats = new List<string>(numberInCatiz.Split(' '));
            int power = 0;
            BigInteger result = 0;
            var numbersIn17th = new List<BigInteger>();

            foreach (var word in cats)
            {
                result = 0;
                power = 0;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    int currentNumber = word[i] - 'a';
                    result += currentNumber * Power(17, power);
                    power++;
                }
                numbersIn17th.Add(result);

            }
            numbersIn17th.Reverse();
            int numeralSystem26th = 26;
            StringBuilder text = new StringBuilder();
            foreach (var number in numbersIn17th)
            {
                var anotherNumber = number;
                while (anotherNumber > 0)
                {
                    int digitIn26th = (int)(anotherNumber % numeralSystem26th);
                    text.Insert(0, (char)(digitIn26th + 'a'));
                    anotherNumber /= numeralSystem26th;
                }
                text.Insert(0, ' ');
               
            }
            Console.WriteLine(text.ToString().TrimStart());


            



        }
    }
}
