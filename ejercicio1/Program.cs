using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer 
            //los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
            int max, pos;
            int[] vNum = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                vNum[x] = int.Parse(Console.ReadLine());
            }
            max = vNum[0];
            pos = 1;
            for (int x = 0; x < 10; x++)
            {
                if(vNum[x] > max){
                    max = vNum[x];
                    pos = x + 1;
                }
            }
            Console.WriteLine("El valor máximo dentro del vector es: " + max + " y su posicion es: " + pos);
        }
    }
}
