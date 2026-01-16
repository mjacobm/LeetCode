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
        TwoSum TS = new TwoSum();
        int[] a = TS.FunTwoSum([3, 8, 1, 23, 11, 15], 34);
        //print the content of the array a 
        foreach (var number in a)
        {
            Console.WriteLine(number);
        }



    }
}