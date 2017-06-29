using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AnalyticAlways.CommonToolsCore
{
    public static class RegexUtil
    {
        /// <summary>   Query if 'pattern' is a valid regular expression. </summary>
        /// <remarks>   This code is just fort a NuGet PoC </remarks>
        /// <param name="pattern">  Specifies the pattern. </param>
        /// <returns>   true if regular expression pattern valid, false if not. </returns>
        public static bool IsRegexPatternValid(string pattern)
        {
            try
            {
                new Regex(pattern); //WTF!
                return true;
            }
            catch { }  //TODO: please give me a punch!

            return false;
        }
    }
}
