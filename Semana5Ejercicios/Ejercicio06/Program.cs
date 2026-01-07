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

            // 1. Almacenar las asignaturas solicitadas
            List<string> asignaturas = new List<string> 
            { 
                "Fisica", 
                "Matematicas", 
                "Programacion Orientada a Objetos", 
                "Sistemas Operativos" 
            };

            // Lista para guardar las notas y lista para identificar cuáles borrar
            List<double> notas = new List<double>();
            List<string> aprobadas = new List<string>();

            // 2. Preguntar la nota de cada asignatura
            foreach (var asignatura in asignaturas)
            {
                Console.Write($"Introduce la nota de {asignatura}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas.Add(nota);

                // Si la nota es 7 o más, la marcamos para eliminar
                if (nota >= 7.0)
                {
                    aprobadas.Add(asignatura);
                }
            }

            // 3. ELIMINAR de la lista original las asignaturas aprobadas
            foreach (var materiaAprobada in aprobadas)
            {
                asignaturas.Remove(materiaAprobada);
            }

            // 4. Mostrar las asignaturas que quedaron (las que tiene que repetir)
            Console.WriteLine("\n--- Asignaturas a Repetir (Nota menor a 7) ---");

            if (asignaturas.Count == 0)
            {
                Console.WriteLine("¡Felicidades! No tienes que repetir ninguna asignatura.");
            }
            else
            {
                foreach (var asignatura in asignaturas)
                {
                    Console.WriteLine($"• {asignatura}");
                }
            }
            
            // Pausa para ver el resultado
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}