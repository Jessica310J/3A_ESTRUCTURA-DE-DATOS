// Archivo: Nodo.cs
// Clase que representa un nodo de la lista enlazada

public class Nodo
{
    public int Data;      // Dato almacenado
    public Nodo? Next;    // Referencia al siguiente nodo

    public Nodo(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}