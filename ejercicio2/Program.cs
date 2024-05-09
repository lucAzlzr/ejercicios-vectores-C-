using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
            int[] vNum = new int[10];
            int acu = 0, promedio;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                vNum[x] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < 10; x++)
            {
                acu += vNum[x];
            }
            promedio = acu / 10;
            Console.WriteLine("El promedio es " + promedio);

            for (int x = 0; x < 10; x++)
            {
                if(vNum[x] > promedio)
                    Console.WriteLine("El valor " + vNum[x] + " es mayor al promedio");
            }
        }
    }
}
