// Archivo: Program.cs
// EJERCICIO 2: Invertir una lista enlazada

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        Console.WriteLine("╔═══════════════════════════════════════════════╗");
        Console.WriteLine("║  EJERCICIO 2: INVERTIR LISTA ENLAZADA        ║");
        Console.WriteLine("╚═══════════════════════════════════════════════╝\n");

        // Agregar elementos
        Console.WriteLine("📌 Agregando elementos: 10, 20, 30, 40, 50\n");
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);
        lista.Agregar(50);

        // Mostrar lista original
        Console.WriteLine("Lista ORIGINAL:");
        lista.Mostrar();
        Console.WriteLine($"Total elementos: {lista.ContarElementos()}\n");

        // Invertir la lista
        Console.WriteLine("───────────────────────────────────────────────");
        Console.WriteLine("🔄 Invirtiendo la lista...");
        Console.WriteLine("───────────────────────────────────────────────");
        lista.Invertir();
        Console.WriteLine();

        // Mostrar lista invertida
        Console.WriteLine("Lista INVERTIDA:");
        lista.Mostrar();
        Console.WriteLine($"Total elementos: {lista.ContarElementos()}\n");

        // Verificación
        Console.WriteLine("───────────────────────────────────────────────");
        Console.WriteLine("✓ El primer elemento (10) ahora es el último");
        Console.WriteLine("✓ El último elemento (50) ahora es el primero");
        Console.WriteLine("───────────────────────────────────────────────");
    }
}
