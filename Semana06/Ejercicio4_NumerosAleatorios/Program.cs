// Archivo: Program.cs
// EJERCICIO 4: 50 números aleatorios y eliminación por rango

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
        Console.WriteLine("║  EJERCICIO 4: NÚMEROS ALEATORIOS Y RANGO            ║");
        Console.WriteLine("╚═══════════════════════════════════════════════════════╝\n");

        // Generar 50 números aleatorios
        lista.GenerarNumerosAleatorios(50);

        // Mostrar lista original
        Console.WriteLine("───────────────────────────────────────────────────────");
        Console.WriteLine("📊 LISTA ORIGINAL (50 números del 1 al 999):");
        Console.WriteLine("───────────────────────────────────────────────────────");
        lista.Mostrar();
        
        int totalInicial = lista.ContarElementos();
        lista.ObtenerMinMax(out int minInicial, out int maxInicial);
        
        Console.WriteLine($"\n✓ Total elementos: {totalInicial}");
        Console.WriteLine($"✓ Valor mínimo: {minInicial}");
        Console.WriteLine($"✓ Valor máximo: {maxInicial}\n");

        // Solicitar rango al usuario
        Console.WriteLine("───────────────────────────────────────────────────────");
        Console.WriteLine("📝 Ingresa el rango para MANTENER los elementos:");
        Console.WriteLine("───────────────────────────────────────────────────────");
        
        Console.Write("Valor mínimo del rango: ");
        int rangoMin = int.Parse(Console.ReadLine()!);
        
        Console.Write("Valor máximo del rango: ");
        int rangoMax = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine();

        // Eliminar elementos fuera del rango
        Console.WriteLine("───────────────────────────────────────────────────────");
        Console.WriteLine($"🗑️  Eliminando elementos fuera del rango [{rangoMin}, {rangoMax}]");
        Console.WriteLine("───────────────────────────────────────────────────────");
        lista.EliminarFueraDeRango(rangoMin, rangoMax);
        Console.WriteLine();

        // Mostrar lista filtrada
        Console.WriteLine("───────────────────────────────────────────────────────");
        Console.WriteLine("📊 LISTA FILTRADA:");
        Console.WriteLine("───────────────────────────────────────────────────────");
        lista.Mostrar();
        
        int totalFinal = lista.ContarElementos();
        Console.WriteLine($"\n✓ Total elementos restantes: {totalFinal}");
        Console.WriteLine($"✓ Elementos eliminados: {totalInicial - totalFinal}");
        
        Console.WriteLine("\n───────────────────────────────────────────────────────");
        Console.WriteLine("✓ Proceso completado exitosamente.");
        Console.WriteLine("───────────────────────────────────────────────────────");
    }
}