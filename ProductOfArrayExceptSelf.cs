using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            //[8, 1, 3, 2, 4]
            int n = nums.Length;

            // Result array
            int[] result = new int[n];

            // Prefix product
            int prefix = 1;

            // Calculate prefix products
            for (int i = 0; i < n; i++)
            {
                result[i] = prefix;
                prefix = prefix * nums[i];
            }

            // Suffix product
            int suffix = 1;

            // Multiply with suffix products
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] = result[i] * suffix;
                suffix = suffix * nums[i];
            }

            return result;
        }

    }
}
