using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int row = input;
            int col = input;
            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
