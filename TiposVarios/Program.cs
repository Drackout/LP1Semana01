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
            Console.WriteLine(intSimple);
            Console.WriteLine(uIntSimple);

            //chars
            char charSimple = '\u00A9';
            char charSimpleTwo = '\\';
            char charSimpleThree = '\u1234';
            Console.WriteLine(charSimple);
            Console.WriteLine(charSimpleTwo);
            Console.WriteLine(charSimpleThree);

            //reais
            double doubleSimple= 9.125;
            float floatSimple = 8.235f;
            Console.WriteLine(doubleSimple);
            Console.WriteLine(floatSimple);

            //Booleans
            bool bool1Simple= true;
            bool bool2Simple= false;
            Console.WriteLine(bool1Simple);
            Console.WriteLine(bool2Simple);
        }
    }
}
