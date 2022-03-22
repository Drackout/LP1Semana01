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

            string str4 = "abc" + 2;
            string str5 = "oof" + str1;
            string str6 = $"a {str1} e b {str2}";
            //string str7 = string.format("A {1} e B {0}" + str2, str1);
            
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            //Console.WriteLine(str7);

        }
    }
}
