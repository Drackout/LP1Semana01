using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int x=1, y=2;
            string str1;
            str1 = "isto é uma string";

            string str2 = "\u0a02 <- ayy lmao, ayy limão -> \uF0F2";

            string str3 = "tabs!\tTabs!";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            string str1Concat = "string concat ->'"+str1+"'<-";
            string str2Concat = 2+" "+"s"+"a"+"p"+"o"+"s";
            Console.WriteLine(str1Concat);
            Console.WriteLine(str2Concat);
            
            string str1Interp = $"quantos sapos?: {str2Concat}";
            string str2Interp = $"soma de {x} + {y}: {y+x}";
            Console.WriteLine(str1Interp);
            Console.WriteLine(str2Interp);

        }
    }
}
