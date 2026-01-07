/*
 * EJERCICIO 9:
 * Escribir un programa que pida al usuario una palabra y muestre por pantalla 
 * el número de veces que contiene cada vocal.
 */

using System;
using System.Collections.Generic;

namespace Ejercicio09
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== EJERCICIO 9: Contador de Vocales ===\n");

            Console.Write("Introduce una palabra: ");
            var word = Console.ReadLine().ToLower();

            var vocals = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (var vocal in vocals)
            {
                var times = 0;
                foreach (var letter in word)
                {
                    if (letter == vocal)
                    {
                        times++;
                    }
                }
                Console.WriteLine($"La vocal {vocal} aparece {times} veces");
            }
        }
    }
}