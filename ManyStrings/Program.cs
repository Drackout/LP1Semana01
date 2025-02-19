using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string str1;
            str1 = "isto é uma string";

            string str2 = "\u0a02 <- ayy lmao, ayy limão -> \uF0F2";

            string str3 = "tabs!\tTabs!";
            
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
