/*
 * EJERCICIO 6:
 * Escribir un programa que almacene las asignaturas de un curso 
 * (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista, 
 * pregunte al usuario la nota que ha sacado en cada asignatura y elimine de 
 * la lista las asignaturas aprobadas. Al final el programa debe mostrar por 
 * pantalla las asignaturas que el usuario tiene que repetir.
 */

using System;
using System.Collections.Generic;

namespace Ejercicio06
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== CONTROL DE ASIGNATURAS ===\n");

            // 1. Almacenar las asignaturas en una lista explícita
            List<string> asignaturas = new List<string> 
            { 
                "Fisica", 
                "Matematicas", 
                "Programacion Orientada a Objetos", 
                "Sistemas Operativos" 
            };

            // Definición explícita de listas auxiliares
            List<double> notas = new List<double>();
            List<string> aprobadas = new List<string>();

            // 2. Preguntar la nota de cada asignatura usando string en el foreach
            foreach (string asignatura in asignaturas)
            {
                Console.Write($"Introduce la nota de {asignatura}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas.Add(nota);

                // Si la nota es 7 o más, la agregamos a la lista de aprobadas
                if (nota >= 7.0)
                {
                    aprobadas.Add(asignatura);
                }
            }

            // 3. ELIMINAR de la lista original usando el tipo explícito string
            foreach (string materiaAprobada in aprobadas)
            {
                asignaturas.Remove(materiaAprobada);
            }

            // 4. Mostrar las asignaturas restantes
            Console.WriteLine("\n--- Asignaturas a Repetir (Nota menor a 7) ---");

            if (asignaturas.Count == 0)
            {
                Console.WriteLine("¡Felicidades! No tienes que repetir ninguna asignatura.");
            }
            else
            {
                foreach (string asignatura in asignaturas)
                {
                    Console.WriteLine($"• {asignatura}");
                }
            }
            
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}