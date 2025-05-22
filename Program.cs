using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace IWD23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine($"so tong = {Tong(n)}");
           int[,] matrix = new int[,]  {
                {7, 1, 5},
                {2, 4, 8},
                {9, 6, 3}
            };
            DuyetMang(matrix, 0, 0);
            Console.ReadLine(); 
        }

        // tinh tong tu 1 den n 
        // parameter = 5 
        // bo dem acc = 0
        static int Tong(int n, int acc = 0)
        {
            if (n == 0) return acc;
            return Tong(n - 1, acc + n);
        }


        static void DuyetMang(int[,] matrix, int i, int j)
        {
            int rows = matrix.GetLength(1);
            int cols = matrix.GetLength(1);

            if (i >= rows) return;
            if (j >= cols)
            {
                DuyetMang(matrix, i + 1, 0);
                return;
            }
            Console.WriteLine(matrix[i, j]);
            DuyetMang(matrix, i, j + 1);
        }
    }
}