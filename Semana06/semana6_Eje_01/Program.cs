using System;

namespace EjercicioConteo
{
    // Representa la unidad básica de la secuencia
    public class Eslabón 
    {
        public int Información;
        public Eslabón? SiguientePaso;

        public Eslabón(int dato)
        {
            Información = dato;
            SiguientePaso = null;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(">>> CÁLCULO DE LONGITUD DE LISTA <<<");

            // Construcción manual para demostrar el manejo de punteros
            Eslabón cabeza = new Eslabón(100);
            cabeza.SiguientePaso = new Eslabón(200);
            cabeza.SiguientePaso.SiguientePaso = new Eslabón(300);

            // Algoritmo de recorrido
            int totalNodos = 0;
            Eslabón? cursor = cabeza;

            while (cursor != null)
            {
                totalNodos++;
                cursor = cursor.SiguientePaso;
            }

            Console.WriteLine($"La lista contiene actualmente: {totalNodos} eslabones.");
        }
    }
}