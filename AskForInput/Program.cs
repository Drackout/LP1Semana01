using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int intC;
            float floatC;

            intC = Convert.ToInt16(Console.ReadLine());

            floatC = float.Parse(Console.ReadLine());

            Console.WriteLine($"Sum of {intC}+{floatC}={intC+floatC}");
        }
    }
}
