using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argumentos!");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Argumento " + i + " -> " + args[i]);
            }
        }
    }
}
