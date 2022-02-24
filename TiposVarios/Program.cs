using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //inteiros
            int intSimple= 9;
            uint uIntSimple = 8;
            Console.WriteLine("Int -> " + intSimple);
            Console.WriteLine("UInt -> " + uIntSimple);

            //chars
            char charSimple = '\u00A9';
            char charSimpleTwo = '\\';
            char charSimpleThree = '\u1234';
            Console.WriteLine("Char -> " + charSimple);
            Console.WriteLine("CharTwo -> " + charSimpleTwo);
            Console.WriteLine("CharThree -> " + charSimpleThree);

        }
    }
}
