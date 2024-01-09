using System;

class Program
{
    static void FillMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Enter the value for position [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    static void PrintMatrix(int[,] matrix, string matrixName)
    {
        Console.WriteLine($"{matrixName}:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"[{matrix[i, j]}] ");
            }
            Console.WriteLine();
        }
    }

    static void PrintResult(int[,] result)
    {
        Console.WriteLine("Result of matrix 1 x matrix 2:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write($"[{result[i, j]}] ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] matrix1 = new int[2, 3];
        int[,] matrix2 = new int[3, 2];

        FillMatrix(matrix1);
        FillMatrix(matrix2);

        PrintMatrix(matrix1, "Matrix 1");
        PrintMatrix(matrix2, "Matrix 2");

        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        PrintResult(result);
    }
}
