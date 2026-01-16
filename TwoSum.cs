// Import core System namespace for basic types like Array and Int32.
using System;
// Import collections namespace to use Dictionary<TKey,TValue>.
using System.Collections.Generic;
// Import Text namespace (preserved from original file).
using System.Text;

// Declare the LeetCode namespace to contain the TwoSum class.
namespace LeetCode
{
    // Define an internal class named TwoSum visible only within the assembly.
    internal class TwoSum
    {
        // Declare a public method that returns an array of two integers and accepts an int array and a target int.
        public int[] FunTwoSum(int[] nums, int target)
        {
            // Create a dictionary to map previously seen values to their indices.
            Dictionary<int, int> map = new Dictionary<int, int>();

            // Iterate over the array indices from 0 to nums.Length - 1.
            for (int i = 0; i < nums.Length; i++)
            {
                // Compute the value needed to add to nums[i] to reach the target.
                int complement = target - nums[i];

                // Check if the complement has already been recorded in the dictionary.
                if (map.ContainsKey(complement))
                    // If found, return an array containing the index of the complement and the current index.
                    return new int[] { map[complement], i };

                // Record the current value and its index in the dictionary for future checks.
                map[nums[i]] = i;
            }

            // If no matching pair was found, return an empty integer array.
            return Array.Empty<int>();
        }

    }
}