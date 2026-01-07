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

            // Definición explícita de la lista de precios (double)
            List<double> precios = new List<double> { 50, 75, 46, 22, 80, 65, 8 };

            // Inicialización explícita de variables de comparación
            double menor = precios[0];
            double mayor = precios[0];

            // Recorrido de la lista con tipo de dato explícito
            foreach (double precio in precios)
            {
                if (precio < menor)
                {
                    menor = precio;
                }
                
                if (precio > mayor)
                {
                    mayor = precio;
                }
            }

            // Mostrar resultados por pantalla
            Console.WriteLine("Precios en la lista: " + string.Join(", ", precios));
            Console.WriteLine($"El precio menor es: {menor}");
            Console.WriteLine($"El precio mayor es: {mayor}");
            
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}