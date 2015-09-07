using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = x;
        int z = (x / 2) + 1;

        int width = (2 * x + 2 * z) - 3; // minus 3, cuz there are 3 point that y(x==y) and z are sharing.
        int height = width;

        int[,] matrix = new int[height, width];

        int currentRow = x / 2;
        int currentCol = 0;
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow--;
            currentCol++;

            if (currentRow < 0)
            {
                currentRow++;           //reset them
                currentCol--;
                break;
            }
        }

        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow++;
            currentCol++;

            if (currentRow == 2 * x - 1)
            {
                currentRow--;
                currentCol--;
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;

            currentRow++;
            currentCol--;

            if (currentRow == width)
            {
                currentRow--;
                currentCol++;
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow--;
            currentCol--;
            if (currentCol == x / 2 - 1)
            {
                currentRow++;
                currentCol++;
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow--;
            currentCol++;
        
            if (currentRow < 0)
            {
                currentRow++;
                currentCol--;
                break;
            }
        }
        while (true)
        {
            matrix[currentRow, currentCol] = 1;
            currentRow++;
            currentCol++;
            if (currentCol == width)
            {
                currentRow--;
                currentCol--;
                break;
            }
        }

        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }

    }
}