using System;
using System.Collections.Generic;

namespace TestTasks
{
    public static class ArraySubstrings
    {
        /*
         * ["baseball", "a,all,b,ball,bas,base,cat,code,d,e,quit,z"]
         * output: 4
        Have the function ArrayChallenge(strArr) read the array off strings stored in strArr, which will contain 2 elements: 
        the first element will be a sequence of characters, and the second element will be a long string of comma-seperated words, 
        in alphabetical order, that represents a dictionary of some arbitrary length.
          
        For example: strArr can be: ["hellocat", "apple, bat,cat,goodbye,hello,yellow,why"].
        Input : dict = {"ale", "apple", "monkey", "plea"}   
        str = "abpcplea"  
        Output : apple 
        Find largest word in dictionary by deleting some characters of given string

        Need to find the minimal substring length that you need to remove from the first string to get string from the array.

         */
        public static string ArrayChallenge(string[] strArr)
        {
            if (strArr.Length < 2)
            {
                Console.WriteLine("Incoming array should contain 2 elements");
            }

            var firstWord = strArr[0];
            var rawArr = strArr[1];
            var subs = rawArr.Split(',');
            var len = 0;
            var firstWordSubs = Calc(firstWord, firstWord.Length - 1);

            foreach (var x in firstWordSubs)
            {
                foreach (var sub in subs)
                {
                    if (len < sub.Length && IsSubs(sub, x))
                    {
                        len = sub.Length;
                    }
                }
            }

            var result = firstWord.Length - len;
            Console.WriteLine($"Output: {result}");

            // code goes here  
            return strArr[0];
        }

        public static List<string> Calc(string word, int len)
        {
            var result = new List<string>();

            if (len < 0)
            {
                return result;
            }

            for (var i = 0; i < word.Length - len; i++)
            {
                var replaced = word.Substring(i, len);

                if (string.IsNullOrEmpty(replaced))
                {
                    break;
                }

                var repStr = word.Replace(replaced, "");

                result.Add(repStr);
            }

            result.AddRange(Calc(word, len - 1));

            return result;
        }

        public static bool IsSubs(string word, string str)
        {
            int wordLen = word.Length;
            int strLen = str.Length;
            int j = 0;

            for (int i = 0; i < wordLen && j < strLen; i++)
            {
                if (word[i] == str[j])
                {
                    j++;
                }
            }

            return j == wordLen;
        }

        public static void Run(string[] args)
        {
            // keep this function call here
            Console.WriteLine(ArrayChallenge(args));
        }
    }
}
