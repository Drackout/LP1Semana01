using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;

            string str1 = "Batatas";
            string str2 = @"verstring args:\ \\ "" main void and such";
            string str3 = "\u01A9\u02A9\u03A9";
            string str4 = "abc" + 2;
            string str5 = "oof" + str1;
            string str6 = $"a {str1} e b {str2}";
            string str7 = String.Format("A {1} e B {0}", str2, str1);
            
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(str5);
            Console.WriteLine(str6);
            Console.WriteLine(str7);

            Console.WriteLine("{0:f2}", xx);
            Console.WriteLine("{0:p1}", xx);
            
            Console.WriteLine("{0:x}", ii);
            Console.WriteLine("{0:c}", ii);
        }
    }
}
