using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero,
            //caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            int num;
            int cubo;
            int cuadrado;
            string numText;

            do 
            {
                Console.WriteLine("Ingrese un numero:");
                numText = Console.ReadLine();


            }while (int.TryParse(numText,out num) || num == 0);
            

        }
    }
}
