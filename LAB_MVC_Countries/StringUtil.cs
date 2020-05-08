using System;

namespace LAB_MVC_Countries
{
    class StringUtil
    {
        public static string ToProperNoun(string s)
        {
            return s.ToUpper()[0] + s.ToLower().Substring(1);
        }
        public static ConsoleColor GetConsoleColor(string color)
        {
            return (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ToProperNoun(color));
        }
    }
}
