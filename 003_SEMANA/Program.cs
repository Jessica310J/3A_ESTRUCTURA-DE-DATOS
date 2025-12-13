using System;

// La clase 'Estudiante' es accesible porque está en un archivo en el mismo proyecto.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** SISTEMA DE REGISTRO DE ESTUDIANTES C# ***\n");

        // Crea el objeto 'nuevoEstudiante' basado en la plantilla de Estudiante.cs
        Estudiante nuevoEstudiante = new Estudiante();

        // 1. Recolección de Datos Sencilla
        
        Console.Write("Ingrese el ID (solo números): ");
        // Leemos la línea y la convertimos a entero si es posible
        int.TryParse(Console.ReadLine(), out int idIngresado);
        nuevoEstudiante.ID = idIngresado; 
        
        Console.Write("Ingrese nombres: ");
        nuevoEstudiante.Nombres = Console.ReadLine();

        Console.Write("Ingrese apellidos: ");
        nuevoEstudiante.Apellidos = Console.ReadLine();

        Console.Write("Ingrese dirección: ");
        nuevoEstudiante.Direccion = Console.ReadLine();

        // 2. Llenar el Array (3 Teléfonos)
        Console.WriteLine("\n== Ingrese los 3 números de teléfono ==");
        
        for (int i = 0; i < nuevoEstudiante.Telefonos.Length; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            nuevoEstudiante.Telefonos[i] = Console.ReadLine();
        }

        // 3. Muestra el resultado
        nuevoEstudiante.MostrarInformacion();
        
        Console.WriteLine("\nRegistro terminado. Presione Enter para salir.");
        Console.ReadKey(); 
    }
}