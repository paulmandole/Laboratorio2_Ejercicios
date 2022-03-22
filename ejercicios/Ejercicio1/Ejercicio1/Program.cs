using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio
            int num;
            int max = 0;
            int flag = 0;
            string numText;


            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero:");
                    numText = Console.ReadLine();

                }while (!int.TryParse(numText, out num));
                if (flag == 0)
                {
                    max = num;
                    flag = 1;
                }
                else 
                {
                    if(max < num)
                    {
                        max = num;
                    }
                }
            }
            Console.WriteLine("El numero maximo es:{0}",max);

            
        }
    }
}
