using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class ReverseAString
    {
        public string ReverseString(string s)
        {
            // Convert string to character array (strings are immutable)
            char[] chars = s.ToCharArray();

            // Initialize left pointer at start
            int left = 0;

            // Initialize right pointer at end
            int right = chars.Length - 1;

            // Continue until pointers meet
            while (left < right)
            {
                // Swap characters at left and right positions
                (chars[left], chars[right]) = (chars[right], chars[left]);

                //Another way to write the above line of code.
                //char temp = chars[left];
                //chars[left] = chars[right];
                //chars[right] = temp;

                // Move left pointer forward
                left++;

                // Move right pointer backward
                right--;
            }

            // Convert character array back to string
            return new string(chars);
        }


    }
}
