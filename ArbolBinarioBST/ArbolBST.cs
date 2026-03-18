using System;

namespace ArbolBinarioBST
{
    class ArbolBST
    {
        private Nodo raiz;

        public bool EstaVacio() => raiz == null;

        // INSERTAR: menor izquierda, mayor derecha
        public void Insertar(int valor) => raiz = Insertar(raiz, valor);
        private Nodo Insertar(Nodo n, int v)
        {
            if (n == null) return new Nodo(v);
            if (v < n.Valor)      n.Izquierdo = Insertar(n.Izquierdo, v);
            else if (v > n.Valor) n.Derecho   = Insertar(n.Derecho, v);
            else Console.WriteLine($"  [!] {v} ya existe.");
            return n;
        }

        // BUSCAR
        public bool Buscar(int v) => Buscar(raiz, v);
        private bool Buscar(Nodo n, int v)
        {
            if (n == null) return false;
            if (n.Valor == v) return true;
            return v < n.Valor ? Buscar(n.Izquierdo, v) : Buscar(n.Derecho, v);
        }

        // ELIMINAR: sin hijos, un hijo, dos hijos
        public void Eliminar(int v)
        {
            if (!Buscar(v)) { Console.WriteLine($"  [!] {v} no existe."); return; }
            raiz = Eliminar(raiz, v);
            Console.WriteLine($"  [OK] {v} eliminado.");
        }
        private Nodo Eliminar(Nodo n, int v)
        {
            if (n == null) return null;
            if (v < n.Valor)      n.Izquierdo = Eliminar(n.Izquierdo, v);
            else if (v > n.Valor) n.Derecho   = Eliminar(n.Derecho, v);
            else
            {
                if (n.Izquierdo == null) return n.Derecho;
                if (n.Derecho == null)   return n.Izquierdo;
                int s = MinValor(n.Derecho);
                n.Valor = s;
                n.Derecho = Eliminar(n.Derecho, s);
            }
            return n;
        }

        // RECORRIDOS
        public void Preorden()  { Console.Write("  Preorden  : "); Pre(raiz);  Console.WriteLine(); }
        public void Inorden()   { Console.Write("  Inorden   : "); In(raiz);   Console.WriteLine(); }
        public void Postorden() { Console.Write("  Postorden : "); Post(raiz); Console.WriteLine(); }

        private void Pre(Nodo n)  { if (n==null) return; Console.Write($"{n.Valor} "); Pre(n.Izquierdo);  Pre(n.Derecho); }
        private void In(Nodo n)   { if (n==null) return; In(n.Izquierdo);  Console.Write($"{n.Valor} "); In(n.Derecho); }
        private void Post(Nodo n) { if (n==null) return; Post(n.Izquierdo); Post(n.Derecho); Console.Write($"{n.Valor} "); }

        // MINIMO, MAXIMO, ALTURA
        private int MinValor(Nodo n) { while (n.Izquierdo != null) n = n.Izquierdo; return n.Valor; }

        public void Minimo()  { Console.WriteLine(raiz==null ? "  [!] Vacio." : $"  Minimo  : {MinValor(raiz)}"); }
        public void Maximo()  { Nodo n=raiz; while(n.Derecho!=null) n=n.Derecho; Console.WriteLine($"  Maximo  : {n.Valor}"); }
        public void Altura()  { Console.WriteLine($"  Altura  : {AlturaRec(raiz)}"); }
        private int AlturaRec(Nodo n) => n==null ? -1 : 1 + Math.Max(AlturaRec(n.Izquierdo), AlturaRec(n.Derecho));

        // LIMPIAR
        public void Limpiar() { raiz = null; Console.WriteLine("  [OK] Arbol limpiado."); }
    }
}