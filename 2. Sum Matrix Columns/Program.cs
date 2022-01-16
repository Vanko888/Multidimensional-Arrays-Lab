using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
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
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sum = 0;
                for (int ji = 0; ji < matrix.GetLength(0); ji++)
                {
                    sum += matrix[ji, i];
                }
                Console.WriteLine(sum);
            }
            
            
        }
    }
}
