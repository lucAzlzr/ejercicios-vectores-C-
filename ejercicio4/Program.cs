using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 

            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.
            int numeroArticulo, cantidadVendida, numeroArtMax = 0;
            int[] totalVendido = new int[15];
            for (int x = 0; x < 15; x++)
            {
                totalVendido[x] = 0;
            }

            Console.WriteLine("Ingrese número de artículo: ");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            while (numeroArticulo != 0)
            {
                totalVendido[numeroArticulo - 1] += cantidadVendida;

                Console.WriteLine("Ingrese número de artículo: ");
                numeroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantidadVendida = int.Parse(Console.ReadLine());
            }
            //punto a
            int maxCantidad = totalVendido[0];
            int numeroMax = 1;
            for (int x = 0; x < 15; x++)
            {
                if(totalVendido[x] > maxCantidad){
                    maxCantidad = totalVendido[x];
                    numeroArtMax = x + 1;
                }
            }
            Console.WriteLine("El número de artículo que mas se vendió fue: " + numeroArtMax);
            //punto b
            for (int x = 0; x < 15; x++)
            {
                if(totalVendido[x] == 0)
                    Console.WriteLine("El número de articulo " + (x + 1) + " no tuvo ventas");
            }
            //punto c
            Console.WriteLine("La cantidad vendida del artículo 10 es: " + totalVendido[9]);
        }
    }
}
