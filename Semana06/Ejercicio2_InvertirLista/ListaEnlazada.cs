// Archivo: ListaEnlazada.cs
// Implementación de lista enlazada con método de inversión

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

    // EJERCICIO 2: Invertir la lista enlazada
    public void Invertir()
    {
        if (cabeza == null || cabeza.Next == null)
        {
            Console.WriteLine("La lista está vacía o tiene un solo elemento.");
            return;
        }

        Nodo? anterior = null;
        Nodo? actual = cabeza;
        Nodo? siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Next;  // Guardar el siguiente nodo
            actual.Next = anterior;   // Invertir el enlace
            anterior = actual;        // Avanzar anterior
            actual = siguiente;       // Avanzar actual
        }

        cabeza = anterior;  // La nueva cabeza es el último nodo
        Console.WriteLine("✓ Lista invertida exitosamente.");
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
        while (actual != null)
        {
            Console.Write(actual.Data);
            if (actual.Next != null)
                Console.Write(" -> ");
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
}