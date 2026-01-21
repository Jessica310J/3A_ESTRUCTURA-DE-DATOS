using System;
using System.Collections.Generic; // Necesario para usar Stack<>

namespace Tarea_Jessica_P7 {
    public class Validador {
        public static bool Comprobar(string expresion) {
            Stack<char> pila = new Stack<char>(); // Creamos la pila de caracteres

            foreach (char c in expresion) {
                // Si es apertura, lo 'empujamos' a la pila (Push)
                if (c == '(' || c == '[' || c == '{') {
                    pila.Push(c);
                }
                // Si es cierre, validamos con el último que entró (LIFO)
                else if (c == ')' || c == ']' || c == '}') {
                    if (pila.Count == 0) return false; // Error: hay un cierre sin apertura
                    
                    char ultimo = pila.Pop(); // Sacamos el elemento superior (Pop)
                    
                    // Comprobamos que el par sea correcto
                    if ((c == ')' && ultimo != '(') || 
                        (c == ']' && ultimo != '[') || 
                        (c == '}' && ultimo != '{')) return false;
                }
            }
            return pila.Count == 0; // Si la pila está vacía, todo cuadró
        }
    }
}