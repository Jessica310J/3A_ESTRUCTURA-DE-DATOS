/*
 * EJERCICIO 10:
 * Escribir un programa que almacene en una lista los siguientes precios: 
 * 50, 75, 46, 22, 80, 65, 8, y muestre por pantalla el menor y el mayor 
 * de los precios.
 */

using System;
using System.Collections.Generic;

namespace Ejercicio10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== EJERCICIO 10: Análisis de Precios ===\n");

            var precios = new List<double> { 50, 75, 46, 22, 80, 65, 8 };

            Console.WriteLine("Lista de precios:");
            foreach (var precio in precios)
            {
                Console.Write($"{precio} ");
            }

            // Encontrar mínimo
            var minimo = precios[0];
            foreach (var precio in precios)
            {
                if (precio < minimo)
                {
                    minimo = precio;
                }
            }

            // Encontrar máximo
            var maximo = precios[0];
            foreach (var precio in precios)
            {
                if (precio > maximo)
                {
                    maximo = precio;
                }
            }

            // Mostrar resultados
            Console.WriteLine($"\n\nPrecio mínimo: {minimo}");
            Console.WriteLine($"Precio máximo: {maximo}");
        }
    }
}