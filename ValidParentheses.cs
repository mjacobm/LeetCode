using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {
            // Stack to keep track of expected closing brackets
            Stack<char> stack = new Stack<char>();

            // Loop through each character in the string
            foreach (char c in s)
            {
                // If opening bracket, push expected closing bracket
                if (c == '(')
                    stack.Push(')');
                else if (c == '{')
                    stack.Push('}');
                else if (c == '[')
                    stack.Push(']');
                else
                {
                    // If stack is empty or top doesn't match current char, invalid
                    if (stack.Count == 0 || stack.Pop() != c)
                        return false;
                }
            }

            // If stack is empty, all brackets matched correctly
            return stack.Count == 0;
        }

    }
}
