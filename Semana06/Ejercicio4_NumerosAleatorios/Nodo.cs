// Archivo: Nodo.cs
public class Nodo
{
    public int Data;
    public Nodo? Next;

    public Nodo(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}