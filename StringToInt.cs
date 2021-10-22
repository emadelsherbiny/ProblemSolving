using System;

namespace StringToInt
{/*
    Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).

The algorithm for myAtoi(string s) is as follows:
  Input: s = "42"
Output: 42
Explanation: The underlined characters are what is read in, the caret is the current reader position.
Step 1: "42" (no characters read because there is no leading whitespace)
         ^
Step 2: "42" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "42" ("42" is read in)
           ^
The parsed integer is 42.
Since 42 is in the range [-231, 231 - 1], the final result is 42.





    Input: s = "words and 987"
Output: 0
Explanation:
Step 1: "words and 987" (no characters read because there is no leading whitespace)
         ^
Step 2: "words and 987" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "words and 987" (reading stops immediately because there is a non-digit 'w')
         ^
The parsed integer is 0 because no digits were read.
Since 0 is in the range [-231, 231 - 1], the final result is 0.
  */
    class Program
    {
        static void Main(string[] args)
        {
            int result = MyAtoi(" - 91283472332");
            Console.WriteLine(result);
        }

        private static  int MyAtoi(string s) 
        {
            string result = "";
            bool isPos = true;
            int intResult = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == '+')
                    continue;
                if (s[i] == '-')
                {
                    isPos = false;
                    continue;
                }
                if (!char.IsNumber( s[i]))
                {
                    break;
                }
                else 
                {
                    result +=  s[i]   ;
                }
            }
            if (isPos  )
            {
                if (Int32.TryParse(result, out intResult))
                {
                    return intResult;
                }
                else
                {
                    return Int32.MaxValue;
                }
                

            }
            else
            {

                if (Int32.TryParse(result, out intResult))
                {
                    return intResult*-1;
                }
                else
                {
                    return Int32.MinValue;
                }
            }
            


        }
    }
}

