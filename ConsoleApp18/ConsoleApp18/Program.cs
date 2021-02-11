using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        { //Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos(terminará cuando se teclea un número negativo o cero).

            int numP,num=1, suma=0;


            while (num <= 5)
            {
                Console.Write("ingrese un numeros");
                numP = int.Parse(Console.ReadLine());

                if (numP > -1)
                {
                    Console.WriteLine("es un numero positivo");
                }
                else 
                {
                    suma = suma + numP;
                    
                    num++;
                }
                

            }
            Console.Write("la suma de los valores es: {0}", suma);
            Environment.Exit(1);


        }
    }
}
