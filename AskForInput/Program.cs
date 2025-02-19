using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string userTxt;
            int intCon;
            float floatConverted;

            userTxt = Console.ReadLine();
            intConverted = Convert.ToInt16(userTxt);

            userTxt = Console.ReadLine();
            floatConverted = float.Parse(userTxt);

            Console.WriteLine($"Sum of {intConverted} + {floatConverted} = {intConverted + floatConverted}");


        }
    }
}
