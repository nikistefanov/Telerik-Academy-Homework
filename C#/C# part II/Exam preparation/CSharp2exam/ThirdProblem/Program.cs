using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ThirdProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder code = new StringBuilder();
            //int repeat = int.Parse(Console.ReadLine());
            //for (int i = 0; i < repeat; i++)
            //{
            //    string line = Console.ReadLine();
            //    code.AppendLine(line);
            //}
            //
            ////sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal, bool, char, string
            //var variables = new[] { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal", /"bool", /"char", "string" };
            //// DO NOT - switch / do-while
            //var vars = new StringBuilder();
            //using (StreamReader reader = new StreamReader("text.txt"))
            //{
            //    var line = reader.ReadLine();
            //    while (line != null)
            //    {
            //        int indexOfInt = line.IndexOf("int ");
            //        Console.WriteLine(indexOfInt);
            //        var sub = line.Substring(indexOfInt + 4);
            //        Console.WriteLine(sub);
            //        int indexOfSpace = sub.IndexOf(" ");
            //        vars.Append(sub.Substring(0, indexOfSpace));
            //        vars.Replace(",", "");
            //        Console.WriteLine(vars);
            //        line = vars.ToString();
            //    }
            //}




            //Console.WriteLine("Methods -> None");
            //Console.WriteLine("Loops -> None");
            //Console.WriteLine("Conditional Statements -> None");


            int rows = 5;
            int cols = 6;
            int moves = 4;
            int[] code = { 14, 27, 1, 25 };


            int coeff = Math.Max(rows, cols);
            int row = code[0] / coeff;
            int col = code[0] % coeff;
            for (int i = 1; i < moves; i++)
            {
                Console.WriteLine(row);
                Console.WriteLine(col);
                Console.WriteLine("***");
                row = code[i] / coeff;
                col = code[i] % coeff;
            }
            Console.WriteLine(row);
            Console.WriteLine(col);



        }
    }
}
