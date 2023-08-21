using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal static class FibonacciCounter
    {
        public static ulong GetFibonacciNumber(uint index) //O(n)
        {
            if (index == 0)
            {
                throw new ArgumentException("Must be more than 0", nameof(index));
            }

            ulong second = 1, first = 0;

            if (index == 1) 
            { 
                return first;
            }

            for (uint i = 2; i < index; i++) // O^n
            {
                ulong temp = second;
                second += first;
                first = temp;
            }

            return second;
        }

        public static ulong GetFibonacciNumberRecursive(uint index) // O(2^n)
        {
            if (index == 0)
            {
                throw new ArgumentException("Must be more than 0", nameof(index));
            }

            if (index == 1)
            {
                return 0;
            }
            else if (index == 2)
            {
                return 1;
            }
            else
            {
                return GetFibonacciNumberRecursive(index - 1) + GetFibonacciNumberRecursive(index - 2);
            }
        }
    }
}
