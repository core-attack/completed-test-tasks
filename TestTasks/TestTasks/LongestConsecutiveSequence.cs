using System;
using System.Collections.Generic;

namespace TestTasks
{
    public static class LongestConsecutiveSequence
    {
        /*
        Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

        Example 1:

        Input: nums = [100,4,200,1,3,2]
        Output: 4
        Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
        Example 2:

        Input: nums = [0,3,7,2,5,8,4,6,0,1]
        Output: 9
        */
        public static int ArrayChallenge(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }

            int lcsLen = 0;
            var cache = new HashSet<int>();

            foreach (var num in arr)
            {
                cache.Add(num);
            }

            foreach (var num in cache)
            {
                if (!cache.Contains(num - 1))
                {
                    var current = num;
                    var lcs = 1;

                    while (cache.Contains(current + 1))
                    {
                        current += 1;
                        lcs += 1;
                    }

                    lcsLen = Math.Max(lcsLen, lcs);
                }
            }

            // code goes here  
            return lcsLen;
        }

        public static void Run(int[] args)
        {
            // keep this function call here
            Console.WriteLine($"Output: {ArrayChallenge(args)}");
        }
    }
}
