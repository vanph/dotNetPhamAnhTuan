using System;

namespace Common
{
    public static class StringExtensions
    {
        public static void SayHello(this string source)
        {
            Console.WriteLine("Hello " + source);
        }

        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
