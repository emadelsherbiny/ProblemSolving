using System;
using System.Collections;
using System.Collections.Generic;
/*
* Longest Substring Without Repeating Characters
* Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
*/
namespace LongestSubstringNoRepeate
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcabcbb";
            int result = longSub(str);
        }

         private static int longSub(string str)
        {
            int max = 0;
            string tempStr = "";


            for (int i = 0; i < str.Length; i++)
            {
                while(tempStr.Contains(str[i]))
                {
                   tempStr= tempStr.Substring(1);
                }
                tempStr +=str[i];
                max = Math.Max(max, tempStr.Length);
            }

            return max;
        }
    }
}
