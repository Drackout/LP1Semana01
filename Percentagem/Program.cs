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

            float[] pedidos;
            pedidos = new float[4];

            // Pedir valores
            for (int i = 0; i < 4; i++)
            {
                pedidos[i] = float.Parse(Console.ReadLine());
            }

            // Mostrar com percentagens e alinhado a direita
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{pedidos[i],8:p2}");
            }
           
           
        }
    }
}
