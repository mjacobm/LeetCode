// Import core System namespace for basic types and Array operations.
using System;
// Import collections namespace for potential utility methods.
using System.Collections.Generic;
// Import Text namespace for consistency with project style.
using System.Text;

// Declare the LeetCode namespace to contain the BinarySearch class.
namespace LeetCode
{
    // Define an internal class named BinarySearch visible only within the assembly.
    internal class BinarySearch
    {
        // Declare a public method that performs binary search on a sorted array.
        // Returns the index of the target value if found, otherwise returns -1.
        public int FunBinarySearch(int[] nums, int target)
        {
            // Initialize left pointer at the start of the array.
            int left = 0;
            // Initialize right pointer at the end of the array.
            int right = nums.Length - 1;

            // Continue searching while the left pointer does not exceed the right pointer.
            while (left <= right)
            {
                // Calculate the middle index to avoid potential integer overflow.
                int mid = left + (right - left) / 2;

                // Check if the middle element is the target value.
                if (nums[mid] == target)
                    // If found, return the index of the target.
                    return mid;

                // If the middle element is less than the target, the target must be in the right half.
                if (nums[mid] < target)
                    // Move the left pointer to search in the right half.
                    left = mid + 1;
                else
                    // If the middle element is greater than the target, the target must be in the left half.
                    // Move the right pointer to search in the left half.
                    right = mid - 1;
            }

            // If the target was not found, return -1 to indicate it does not exist in the array.
            return -1;
        }

        // Declare a public method that performs binary search recursively.
        // Returns the index of the target value if found, otherwise returns -1.
        public int FunBinarySearchRecursive(int[] nums, int target)
        {
            // Call the helper method starting with the full array range.
            return BinarySearchHelper(nums, target, 0, nums.Length - 1);
        }

        // Define a private helper method for recursive binary search.
        private int BinarySearchHelper(int[] nums, int target, int left, int right)
        {
            // Base case: if left pointer exceeds right pointer, target is not found.
            if (left > right)
                return -1;

            // Calculate the middle index.
            int mid = left + (right - left) / 2;

            // Check if the middle element is the target value.
            if (nums[mid] == target)
                // If found, return the index of the target.
                return mid;

            // If the middle element is less than the target, search the right half recursively.
            if (nums[mid] < target)
                return BinarySearchHelper(nums, target, mid + 1, right);

            // If the middle element is greater than the target, search the left half recursively.
            return BinarySearchHelper(nums, target, left, mid - 1);
        }
    }
}
