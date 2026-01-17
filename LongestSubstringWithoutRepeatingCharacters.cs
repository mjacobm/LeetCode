using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        //"MATHEWJA"
        public int LengthOfLongestSubstring(string s)
        {
            // HashSet to store unique characters in current window
            HashSet<char> set = new HashSet<char>();

            // Left pointer of sliding window
            int left = 0;

            // Variable to store maximum length found
            int maxLength = 0;

            // Right pointer moves through the string
            for (int right = 0; right < s.Length; right++)
            {
                // If character already exists, shrink window from left
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                // Add current character to set
                set.Add(s[right]);

                // Update maximum length
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }


    }
}
