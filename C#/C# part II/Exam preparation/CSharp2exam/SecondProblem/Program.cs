using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var isSeqList = new List<bool>();
            int repaet = int.Parse(Console.ReadLine());
            for (int j = 0; j < repaet; j++)
            {
                var inputed = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            //var inputed = "4 7 4".Split(' ').Select(int.Parse).ToArray();


                int beforeNumber = inputed[0];
                int firstAbsolute = beforeNumber - inputed[1];
                if (firstAbsolute < 0) firstAbsolute = -(firstAbsolute);
                bool isSeq = true;
                for (int i = 0; i < inputed.Length - 1; i++)
                {
                    beforeNumber = inputed[i];
                    int absolute = beforeNumber - inputed[i + 1];
                    if (absolute < 0) absolute = -(absolute);
                    if (firstAbsolute == absolute || firstAbsolute == absolute + 1)
                    {
                        firstAbsolute = absolute;
                        continue;
                    }
                    else
                    {
                        isSeq = false;
                    }
                    beforeNumber = inputed[i];
                }
                //Console.WriteLine(isSeq);
                isSeqList.Add(isSeq);
            }
            foreach (var tf in isSeqList)
            {
                if (tf == true)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
