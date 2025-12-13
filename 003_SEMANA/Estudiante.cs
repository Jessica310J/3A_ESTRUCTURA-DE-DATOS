using System;

// Esta clase NO necesita el método Main. Solo define la estructura.
public class Estudiante
{
    // Propiedades (Datos)
    public int ID { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    
    // ARREGLO (ARRAY) para 3 teléfonos
    public string[] Telefonos { get; set; } = new string[3];

    // Método para mostrar la información
    public void MostrarInformacion()
    {
        Console.WriteLine("\n--- FICHA DE REGISTRO COMPLETO ---");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("\nTeléfonos Registrados:");
        
        // Recorre el arreglo de teléfonos
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"- Teléfono {i + 1}: {Telefonos[i]}");
        }
        Console.WriteLine("----------------------------------");
    }
}