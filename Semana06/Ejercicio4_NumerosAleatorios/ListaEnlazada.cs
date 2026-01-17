// Archivo: ListaEnlazada.cs
// EJERCICIO 4: Lista con números aleatorios y eliminación por rango

public class ListaEnlazada
{
    private Nodo? cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Agregar elemento al final
    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);

        if (cabeza == null)
        {
            cabeza = nuevoNodo;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Next != null)
        {
            actual = actual.Next;
        }
        actual.Next = nuevoNodo;
    }

    // Generar 50 números aleatorios del 1 al 999
    public void GenerarNumerosAleatorios(int cantidad)
    {
        Random random = new Random();
        Console.WriteLine($"Generando {cantidad} números aleatorios del 1 al 999...\n");

        for (int i = 0; i < cantidad; i++)
        {
            int numero = random.Next(1, 1000);  // 1 a 999
            Agregar(numero);
        }
    }

    // EJERCICIO 4: Eliminar nodos fuera de un rango
    public void EliminarFueraDeRango(int minimo, int maximo)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        int eliminados = 0;

        // Eliminar nodos al inicio que estén fuera del rango
        while (cabeza != null && (cabeza.Data < minimo || cabeza.Data > maximo))
        {
            cabeza = cabeza.Next;
            eliminados++;
        }

        // Eliminar nodos intermedios
        Nodo? actual = cabeza;
        while (actual != null && actual.Next != null)
        {
            if (actual.Next.Data < minimo || actual.Next.Data > maximo)
            {
                actual.Next = actual.Next.Next;
                eliminados++;
            }
            else
            {
                actual = actual.Next;
            }
        }

        Console.WriteLine($"✓ Se eliminaron {eliminados} nodos fuera del rango [{minimo}, {maximo}]");
    }

    // Mostrar la lista
    public void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo? actual = cabeza;
        int contador = 0;

        while (actual != null)
        {
            Console.Write($"{actual.Data}");
            if (actual.Next != null)
                Console.Write(", ");
            
            contador++;
            if (contador % 10 == 0)  // Nueva línea cada 10 elementos
                Console.WriteLine();
            
            actual = actual.Next;
        }
        Console.WriteLine();
    }

    // Contar elementos
    public int ContarElementos()
    {
        int contador = 0;
        Nodo? actual = cabeza;
        while (actual != null)
        {
            contador++;
            actual = actual.Next;
        }
        return contador;
    }

    // Obtener valor mínimo y máximo
    public void ObtenerMinMax(out int minimo, out int maximo)
    {
        if (cabeza == null)
        {
            minimo = 0;
            maximo = 0;
            return;
        }

        minimo = cabeza.Data;
        maximo = cabeza.Data;
        Nodo? actual = cabeza.Next;

        while (actual != null)
        {
            if (actual.Data < minimo)
                minimo = actual.Data;
            if (actual.Data > maximo)
                maximo = actual.Data;
            
            actual = actual.Next;
        }
    }
}