/*
 * EJERCICIO 3:
 * Escribir un programa que almacene las asignaturas de un curso 
 * (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista, 
 * pregunte al usuario la nota que ha sacado en cada asignatura, y después 
 * las muestre por pantalla con el mensaje "En <asignatura> has sacado <nota>" 
 * donde <asignatura> es cada una de las asignaturas de la lista y <nota> 
 * cada una de las correspondientes notas introducidas por el usuario.
 */

using System;
using System.Collections.Generic;

namespace Ejercicio03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== EJERCICIO 3: Gestión de Notas ===\n");

            var asignaturas = new List<string> 
            { 
                "Sistemas Operativos",
                "Física",
                "Metodología de la Investigación",
                "Estructura de Datos",
                "Administración de Sistemas Operativos"
            };
            
            var notas = new List<double>();

            // Pedir notas
            foreach (var asignatura in asignaturas)
            {
                Console.Write($"Nota de {asignatura}: ");
                var nota = Convert.ToDouble(Console.ReadLine());
                notas.Add(nota);
            }

            // Mostrar resultados
            Console.WriteLine("\n--- Resultados ---");
            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
            }
        }
    }
}
