using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Batatas";
            string str2 = @"verstring args:\ \\ "" main void and such";
            string str3 = "\u01A9\u02A9\u03A9";
            
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
