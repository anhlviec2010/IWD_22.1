using System;
using System.Runtime.CompilerServices;

namespace IWD22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 5;

            Console.WriteLine($"Kết quả Giai Thừa = {GiaiThua(n)}");

            Console.WriteLine($"Kết quả số Fibonacci của {n} = {Fibonacci(n)}");

            if (IsEven(n) == true)
                Console.WriteLine($"Số {n} là số  chẵn");
            else if (IsOdd(n)==true)
                Console.WriteLine($"Số {n} là số lẽ");



        }

        static int GiaiThua(int n)
        {
            if (n == 0)
                return n = 1;
            return n * GiaiThua(n - 1);
        }
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static bool IsEven(int n)
        {
            if (n == 0) return true;
            return IsOdd(n - 1);
        }
        static bool IsOdd(int n)
        {
            if (n == 0) return false;
            return IsEven(n - 1);
        }

    }
}
