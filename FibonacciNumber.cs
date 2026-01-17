using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class FibonacciNumber
    {
        public int Fib(int n)
        {
            // Base case: fib(0) = 0, fib(1) = 1
            if (n <= 1)
                return n;

            // First Fibonacci number
            int a = 0;

            // Second Fibonacci number
            int b = 1;

            // Loop from 2 to n
            for (int i = 2; i <= n; i++)
            {
                // Calculate next Fibonacci number
                int temp = a + b;

                // Move b to a
                a = b;

                // Update b with new value
                b = temp;
            }

            // b now contains fib(n)
            return b;
        }

    }
}
