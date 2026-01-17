using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            //[[1, 3], [2, 6], [8, 10]]
            // Sort intervals by starting time
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            // List to store merged intervals
            List<int[]> merged = new List<int[]>();

            // Start with first interval
            int[] current = intervals[0];
            merged.Add(current);

            // Iterate through remaining intervals
            foreach (var interval in intervals)
            {
                // If overlapping, merge intervals
                if (interval[0] <= current[1])
                {
                    current[1] = Math.Max(current[1], interval[1]);
                }
                else
                {
                    // No overlap, add new interval
                    current = interval;
                    merged.Add(current);
                }
            }

            return merged.ToArray();
        }

    }
}
