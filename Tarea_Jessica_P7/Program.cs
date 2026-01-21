using System;

namespace Tarea_Jessica_P7 {
    class Program {
        static void Main() {
            // Datos de la estudiante
            Console.WriteLine("========================================");
            Console.WriteLine("TAREA SEMANA 7 - JESSICA PESANTEZ");
            Console.WriteLine("TEMA: PILAS Y RECURSIVIDAD");
            Console.WriteLine("========================================\n");

            // --- PRUEBA DE BALANCÉO ---
            // Usamos una fórmula propia para personalizar el deber
            string miFormula = "{[4*5] + (2+2)}"; 
            Console.WriteLine($">> PRUEBA DE BALANCEO:");
            Console.WriteLine($"Expresión: {miFormula}");
            Console.WriteLine(Validador.Comprobar(miFormula) ? "Resultado: CORRECTO" : "Resultado: ERROR");

            Console.WriteLine("\n----------------------------------------\n");

            // --- PRUEBA DE HANOI ---
            Console.WriteLine($">> SOLUCIÓN HANOI (3 DISCOS):");
            Hanoi juego = new Hanoi();
            juego.Resolver(3);

            Console.WriteLine("\n========================================");
            Console.WriteLine("FIN DEL PROGRAMA");
            Console.ReadKey();
        }
    }
}
