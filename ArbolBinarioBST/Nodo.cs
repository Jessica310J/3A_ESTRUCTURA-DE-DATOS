namespace ArbolBinarioBST
{
    // Clase que representa cada nodo del árbol
    class Nodo
    {
        public int Valor;
        public Nodo Izquierdo, Derecho;

        public Nodo(int valor)
        {
            Valor = valor;
            Izquierdo = Derecho = null;
        }
    }
}