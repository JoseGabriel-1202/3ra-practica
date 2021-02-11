using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        //Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while"
        {
            int a = 1;
            do
            {
                
                Console.WriteLine("{0}", a);
                a++; 

            } while (a != 11);
        }
    }
}
