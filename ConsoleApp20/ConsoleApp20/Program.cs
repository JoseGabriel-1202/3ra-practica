using System;

namespace actividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" se mostrarán los primeros 10 números pares a partir del producto de (10 x 10).");


            for (int i = 100; i <= 118; i= i+2)
            {
                Console.WriteLine( i + "\t");
            }
            Console.ReadKey();
        } 
    }
}
