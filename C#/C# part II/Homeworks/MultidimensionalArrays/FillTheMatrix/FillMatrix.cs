//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:

//  a)
//  1   5	9	13
//  2	6	10	14
//  3	7	11	15
//  4	8	12  16

using System;

class FillMatrix
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int digit = 1;
        string star = new string('*', 40);
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == 0) matrix[row, col] = row + 1;
                else matrix[row, col] = digit + n;
                digit = matrix[row, col];
            }
        }
        
        Console.WriteLine(star);
        Console.WriteLine("a)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(star);
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == 0) matrix[row, col] = row + 1;
                if (col % 2 != 0) matrix[row, col] = (n * (col + 1)) - row;
            }
            
        }
        Console.WriteLine("b)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(star);
        digit = 1;

        for (int row = n - 1; row >= 0; row--)
        {
            for (int col = 0; col <= n - row - 1; col++)
            {
                if (col > 0)
                {
                    matrix[row + col, col] = digit;
                    digit++;
                }
                else
                {
                    matrix[row, col] = digit;
                    digit++;
                }
            }
        }
        for (int col = 1; col < n; col++)
        {
            for (int row = 0; row < n - col; row++)
            {
                if (row > 0)
                {
                    matrix[row, col + row] = digit;
                    digit++;
                }
                else
                {
                    matrix[row, col] = digit;
                    digit++;
                }
            }
        }
        Console.WriteLine("c)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(star);

        digit = 1;
        int currentRow = 0;
        int currentCol = 0;
        int side = n;

        while (digit <= n * n)
        {
            for (int i = 0; i < side; i++)
            {
                matrix[currentRow, currentCol] = digit;
                currentRow++;
                digit++;
            }

            side--;
            currentRow--;
            currentCol++;
            for (int i = 0; i < side; i++)
            {
                matrix[currentRow, currentCol] = digit;
                currentCol++;
                digit++;
            }
            currentCol--;
            currentRow--;
            for (int i = 0; i < side; i++)
            {
                matrix[currentRow, currentCol] = digit;
                currentRow--;
                digit++;
            }
            side--;
            currentRow++;
            currentCol--;

            for (int i = 0; i < side; i++)
            {
                matrix[currentRow, currentCol] = digit;
                currentCol--;
                digit++;
            }
            currentRow++;
            currentCol++;
        }

        Console.WriteLine("d)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine(star);
    }
}