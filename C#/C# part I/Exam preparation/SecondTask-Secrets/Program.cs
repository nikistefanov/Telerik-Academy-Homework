using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        
        BigInteger number = n;
        if (number < 0)
        {
            number = number * -1;
        }
        int position = 1;
        int sum = 0;
        int digit = 0;
        while (number > 0)
        {
            digit = (int) (number % 10);
            number /= 10;
            if (position % 2 != 0)
            {
                sum += digit * position * position;
            }
            else
            {
                sum += digit * digit * position;
            }
            position++;
        }
        Console.WriteLine(sum);

        int lastDigitSum = sum % 10;

        if (lastDigitSum == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        else
        {
            int start = sum % 26; //alphabet symbols
            for (int i = 0; i < lastDigitSum; i++)
            {
                Console.Write((char)('A' + (start + i) % 26));
            }
            Console.WriteLine();
        }
    }

    public static int number { get; set; }
}
    
