using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static int Мultiplication(int number, int until)
        {

            for (int i = 0; i < until; i++)
            {
                number *= 2;
            }

            return number;
        }

        static int Partitioning(int number, int until)
        {
            for (int i = 0; i < until; i++)
            {
                number /= 2;
            }
            return number;
        }
        
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());
            var code = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            //int rows = 5;
            //int cols = 6;
            //int moves = 4;
            //int[] code = { 14, 27, 1, 25 };


            int coeff = Math.Max(rows, cols);
            int startNumber = Мultiplication(1, rows - 1);
            int numberForCols = startNumber;
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numberForCols;
                    numberForCols *= 2;
                }
                startNumber /= 2;
                numberForCols = startNumber;
            }
            BigInteger points = matrix[rows - 1, 0];
            matrix[rows - 1, 0] = 0;
            int startRow = rows - 1;
            int startCol = 0;
            int nextCol = code[0] % coeff;
            int nextRow = code[0] / coeff;


            for (int i = 1; i <= moves; i++)
            {
                
                points += matrix[nextRow, startCol];
                matrix[nextRow, startCol] = 0;
                int diffRows = startRow - nextRow;
                if (diffRows < 0) diffRows = -(diffRows);
                if (diffRows > 1)
                {
                    for (int j = 1; j <= diffRows - 1; j++)
                    {
                        if (startRow < nextRow)
                        {
                            points += matrix[startRow + j, startCol];
                            matrix[startRow + j, startCol] = 0;
                        }
                        else
                        {
                            points += matrix[startRow - j, startCol];
                            matrix[startRow - j, startCol] = 0;
                        }
                    }
                }
                startRow = nextRow;

                if (i == moves)
                {
                    continue;
                }
                else
                {
                    points += matrix[nextRow, nextCol];
                    matrix[nextRow, nextCol] = 0;
                    int diffCols = startCol - nextCol;
                    if (diffCols < 0) diffCols = -(diffCols);
                    if (diffCols > 1)
                    {
                        for (int k = 1; k <= diffCols - 1; k++)
                        {
                            points += matrix[nextRow, startCol + k];
                            matrix[nextRow, startCol + k] = 0;
                        }
                    }
                    startCol = nextCol;
                }
                if (i == moves)
                {
                    continue;
                }
                else
                {
                    nextCol = code[i] % coeff;
                    nextRow = code[i] / coeff;
                }
                

            }
            Console.WriteLine(points);
            Console.WriteLine("end");

        }
    }
}
