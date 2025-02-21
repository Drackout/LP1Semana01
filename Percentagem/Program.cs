using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = 
            CultureInfo.InvariantCulture;   

            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            string n3 = Console.ReadLine();
            string n4 = Console.ReadLine();
           
           
            //mostrar numeros pedidos
            Console.WriteLine($"{float.Parse(n1)}");
            Console.WriteLine($"{float.Parse(n2)}");
            Console.WriteLine($"{float.Parse(n3)}");
            Console.WriteLine($"{float.Parse(n4)}");

            //percentagem
            Console.WriteLine($"{float.Parse(n1),8:p2}");
            Console.WriteLine($"{float.Parse(n2),8:p2}");
            Console.WriteLine($"{float.Parse(n3),8:p2}");
            Console.WriteLine($"{float.Parse(n4),8:p2}");
        }
    }
}
