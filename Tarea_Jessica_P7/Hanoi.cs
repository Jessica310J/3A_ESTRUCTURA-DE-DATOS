using System;
using System.Collections.Generic;

namespace Tarea_Jessica_P7 {
    public class Hanoi {
        // Definimos las tres torres como Pilas de números enteros
        private Stack<int> torreA = new Stack<int>();
        private Stack<int> torreB = new Stack<int>();
        private Stack<int> torreC = new Stack<int>();

        public void Resolver(int n) {
            // Llenamos la torre de origen (3 es el disco más grande, va al fondo)
            for (int i = n; i >= 1; i--) torreA.Push(i);
            
            // Llamamos al método recursivo para mover los discos
            MoverDiscos(n, torreA, torreC, torreB, "ORIGEN", "DESTINO", "AUXILIAR");
        }

        private void MoverDiscos(int n, Stack<int> de, Stack<int> a, Stack<int> aux, string nDe, string nA, string nAux) {
            if (n > 0) {
                // Mover n-1 discos hacia la torre auxiliar
                MoverDiscos(n - 1, de, aux, a, nDe, nAux, nA);

                // Movimiento físico: Sacar de una pila y meter en otra
                int disco = de.Pop(); 
                a.Push(disco);
                Console.WriteLine($"[ACCIÓN] Mover disco {disco} de {nDe} a {nA}");

                // Mover los n-1 discos de la auxiliar al destino final
                MoverDiscos(n - 1, aux, a, de, nAux, nA, nDe);
            }
        }
    }
}