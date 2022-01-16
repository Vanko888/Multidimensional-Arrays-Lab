using System;
using System.Linq;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }
            int sum = int.MinValue;
            int curRow = 0;
            int curCol = 0;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    if ((matrix[i,j] + matrix[i+1,j] + matrix[i,j+1] + matrix[i+1,j+1]) > sum)
                    {
                        sum = (matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);
                        curRow = i;
                        curCol = j;
                    }
                }
            }
            Console.Write($"{matrix[curRow,curCol]} {matrix[curRow, curCol + 1]}");
            Console.WriteLine();
            Console.Write($"{matrix[curRow + 1, curCol]} {matrix[curRow + 1, curCol + 1]}");
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
