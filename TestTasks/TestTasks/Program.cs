using System;

namespace TestTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArraySubstrings.Run(new[]{ "baseball", "a,all,b,ball,bas,base,cat,code,d,e,quit,z"});
            ArraySubstrings.Run(new[]{ "abpcplea", "ale,apple,monkey,plea" });
            LongestConsecutiveSequence.Run(new[] {0, 3, 7, 2, 5, 8, 4, 6, 0, 1});
        }
    }
}
