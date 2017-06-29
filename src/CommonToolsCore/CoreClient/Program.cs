using System;
using AnalyticAlways.CommonToolsCore;

namespace CoreClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validando WTF! as a regular expression!");
            var isValid = RegexUtil.IsRegexPatternValid("WTF!");
            Console.WriteLine($"Is Valid={isValid}");
        }
    }
}