using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = elements[j];
                }
            }
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "END")
            {
                if (command[0] == "Add")
                {
                    int currRow = int.Parse(command[1]);
                    int currCol = int.Parse(command[2]);
                    int currIndex = int.Parse(command[3]);
                    if (currRow >= n || currCol >= n || currRow < 0 || currCol < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[currRow, currCol] += currIndex;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int currRow = int.Parse(command[1]);
                    int currCol = int.Parse(command[2]);
                    int currIndex = int.Parse(command[3]);
                    if (currRow >= n || currCol >= n || currRow < 0 || currCol < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[currRow, currCol] -= currIndex;
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
