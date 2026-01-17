using System;

namespace EjercicioConteo
{
    // Clase que representa el nodo de la lista
    public class NodoRegistro
    {
        public int Valor;
        public NodoRegistro? Siguiente;

        public NodoRegistro(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    class Program
    {
        // Función solicitada: Calcular el número de elementos recorriendo la lista
        public static int ContarNodos(NodoRegistro? cabeza)
        {
            int contador = 0;
            NodoRegistro? actual = cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente; // Salto al siguiente nodo
            }
            return contador;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- EJERCICIO 1: CONTEO DE ELEMENTOS ---");
            // Aquí reside la lógica del algoritmo de conteo.
        }
    }
}