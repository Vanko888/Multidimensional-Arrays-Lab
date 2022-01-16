using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            char currInput = char.Parse(Console.ReadLine());
            bool isTrue = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (currInput == matrix[i,j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        isTrue = false;
                        return;
                    }
                }
            }
            if (isTrue)
            {
                Console.WriteLine($"{currInput} does not occur in the matrix");
            }
        }
    }
}
