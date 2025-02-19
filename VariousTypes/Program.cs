﻿using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int inteiro1 = 11;
            uint inteiro2 = 21U;
            int inteiro30 = 0x10;
            Console.WriteLine(inteiro1);
            Console.WriteLine(inteiro2);
            Console.WriteLine(inteiro30);

            char unic1 = '\u001A';
            char unic2 = '\u0A29';
            char unic3 = '\u2609';
            Console.WriteLine(unic1);
            Console.WriteLine(unic2);
            Console.WriteLine(unic3);

            float real1 = 1.2456f;
            decimal real2 = 14.555m;
            double real3 = 68.419d;
            Console.WriteLine(real1);
            Console.WriteLine(real2);
            Console.WriteLine(real3);
            
            //BOOLS
            bool bverdade = true;
            bool bfalso = false;
            Console.WriteLine(bverdade);
            Console.WriteLine(bfalso);
        }
    }
}
