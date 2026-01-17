//write a main method in c# that prints hello world to the console
using LeetCode;
using System;
class Program
{
    static void Main(string[] args)
    {
        //1.
        //Given an array of integers nums and an integer target, return the indices of the two numbers that add up to target.
        //nums = [2,7,11,15], target = 9 → [0,1]nums = [2,7,11,15], target = 9 → [0,1]
        Console.WriteLine
            ("1. Given an array of integers nums and an integer target, return the indices of the two numbers that add up to target.");
        TwoSum TS = new TwoSum();
        int[] a = TS.FunTwoSum([3, 8, 1, 23, 11, 15], 34);
        //print the content of the array a 
        foreach (var number in a)
        {
            Console.WriteLine(number);
        }

        //2.
        //Reverse a String
        Console.WriteLine("2. Reverse a String");
        ReverseAString RAS = new ReverseAString();
        Console.WriteLine(RAS.ReverseString("MATHEW"));

        //3.
        //Check if parentheses are properly closed and ordered.
        Console.WriteLine("3. Check if parentheses are properly closed and ordered.");
        ValidParentheses VP = new ValidParentheses();
        Console.WriteLine(VP.IsValid("{}[{}]"));


        //4.
        //Find the contiguous subarray with the maximum sum.
        Console.WriteLine("4. Find the contiguous subarray with the maximum sum.");
        MaximumSubarraySum MSS = new MaximumSubarraySum();
        int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine(MSS.MaxSubArray(nums));

        //5.
        //Fibonacci Number
        Console.WriteLine("Return the nth Fibonacci number.");
        FibonacciNumber FN = new FibonacciNumber();
        Console.WriteLine(FN.Fib(41));


        //6.
        //Given a string s, find the length of the longest substring without repeating characters.
        //Example: "abcabcbb" → 3("abc")
        Console.WriteLine("Given a string s, find the length of the longest substring without repeating characters.");
        LongestSubstringWithoutRepeatingCharacters LSWRC = new LongestSubstringWithoutRepeatingCharacters();
        Console.WriteLine(LSWRC.LengthOfLongestSubstring("MATHEWJAZQ"));

    }
}