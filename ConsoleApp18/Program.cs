using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        { //Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos(terminará cuando se teclea un número negativo o cero).

            int numP =1 ,num = 0, suma = 0,n;

            while (numP > 0)
            {
                num++;
                Console.WriteLine("ingrese un numero:   ");
                numP = int.Parse(Console.ReadLine());
                n = numP;

                if (n > 0)
                {
                    suma = suma + n;
                    
                    
                }
               
            }
            Console.WriteLine("la  suma de los numeros es: " + suma);
            Console.ReadKey();

        }
    }
}
