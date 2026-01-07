/*
 * EJERCICIO 12:
 * Escribir un programa que almacene las matrices:
 * A = [[1, 2, 3], [4, 5, 6]]
 * B = [[-1, 0], [0, 1], [1, 1]]
 * en una lista y muestre por pantalla su producto.
 * Nota: Para representar matrices mediante listas usar listas anidadas, 
 * representando cada vector fila en una lista.
 */

using System;
using System.Collections.Generic;

namespace Ejercicio12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== EJERCICIO 12: Producto de Matrices ===\n");

            // Matriz A (2x3)
            var a = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 }
            };

            // Matriz B (3x2)
            var b = new List<List<int>>
            {
                new List<int> { -1, 0 },
                new List<int> {  0, 1 },
                new List<int> {  1, 1 }
            };

            // Matriz resultado (2x2)
            var resultado = new List<List<int>>
            {
                new List<int> { 0, 0 },
                new List<int> { 0, 0 }
            };

            // Calcular producto
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        resultado[i][j] += a[i][k] * b[k][j];
                    }
                }
            }

            // Mostrar resultado
            Console.WriteLine("Resultado A × B:");
            foreach (var fila in resultado)
            {
                Console.Write("[ ");
                foreach (var valor in fila)
                {
                    Console.Write($"{valor} ");
                }
                Console.WriteLine("]");
            }
        }
    }
}