using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class MaximumSubarraySum
    {
        public int MaxSubArray(int[] nums)
        {
            //[3, -1, 2, 12, -2, 12, -10]

            // Initialize current sum with first element
            int currentSum = nums[0];

            // Initialize max sum with first element
            int maxSum = nums[0];

            //Console.WriteLine("=> " + currentSum);
            //Console.WriteLine("=> " + maxSum);

            // Loop from second element onward
            for (int i = 1; i < nums.Length; i++)
            {
                // Decide whether to start new subarray or extend existing one
              
                // Console.WriteLine("CurrentSum = Math.Max(" + nums[i] + ", " + currentSum +"+"+ nums[i] + ")");
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                // Console.WriteLine("=> " + currentSum);

                // Update maximum sum if current sum is higher
                
                // Console.WriteLine("MaxSum = Math.Max(" + maxSum + ", " + currentSum + ")");
                maxSum = Math.Max(maxSum, currentSum);
                // Console.WriteLine("=> " + maxSum);
                // Console.WriteLine("-----");
                // Console.WriteLine($"Index: {i}, CurrentSum: {currentSum}, MaxSum: {maxSum}");
            }

            // Return the maximum subarray sum
            return maxSum;
        }

    }
}
