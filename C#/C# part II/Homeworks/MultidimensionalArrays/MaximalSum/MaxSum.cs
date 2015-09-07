//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.IO;

class MaxSum
{
    static void Main()
    {
        int width = 3;
        int height = 3;      

        Console.Write("N= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M= ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        string star = new string('*', 40);

        Random rnd = new Random();

        if (n < height || m < width)
        {
            Console.WriteLine("Both numbers must be greater than {0}", width);
            return;
        }
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                // using random numbers
                matrix[row, col] = rnd.Next(1, 101);

                //// using user's input
                //Console.Write("index[{0}, {1}", row, col);
                //matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine(star);
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(star);

        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - height + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - width + 1; col++)
            {
                long sum = 0;
                for (int platformRow = row; platformRow < row + height; platformRow++)
                {
                    for (int platformCol = col; platformCol < col + width; platformCol++)
                    {
                        sum += matrix[platformRow, platformCol];
                    }
                }
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("The best platform is:");
        for (int platformRow = bestRow; platformRow < bestRow + height; platformRow++)
        {
            for (int platfromCol = bestCol; platfromCol < bestCol + width; platfromCol++)
            {
                Console.Write("{0} ", matrix[platformRow, platfromCol]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}