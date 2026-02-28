using System;
using System.Collections.Generic;

namespace TraductorBasico
{
    class Traductor
    {
        private Diccionario _diccionario;

        public Traductor(Diccionario diccionario)
        {
            _diccionario = diccionario;
        }

        public void TraducirFrase()
        {
            Console.WriteLine("\n--- TRADUCIR FRASE (Español → Inglés) ---");
            Console.Write("Ingrese la frase: ");
            string frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
            {
                Console.WriteLine("[!] La frase no puede estar vacía.");
                return;
            }

            string resultado = ProcesarFrase(frase);

            Console.WriteLine($"\nOriginal:   {frase}");
            Console.WriteLine($"Traducción: {resultado}");
        }

        private string ProcesarFrase(string frase)
        {
            string[] palabras = frase.Split(' ');
            List<string> traducidas = new List<string>();

            foreach (string palabra in palabras)
            {
                string puntuacion = "";
                string palabraLimpia = palabra;

                // Separa la puntuación al final para no afectar la búsqueda en el diccionario
                if (palabraLimpia.Length > 0)
                {
                    char ultimo = palabraLimpia[palabraLimpia.Length - 1];
                    if (ultimo == '.' || ultimo == ',' || ultimo == '!' || ultimo == '?')
                    {
                        puntuacion = ultimo.ToString();
                        palabraLimpia = palabraLimpia.Substring(0, palabraLimpia.Length - 1);
                    }
                }

                string traduccion = _diccionario.BuscarTraduccion(palabraLimpia);

                // Si no existe en el diccionario, conserva la palabra original
                if (traduccion != null)
                    traducidas.Add(traduccion + puntuacion);
                else
                    traducidas.Add(palabra);
            }

            return string.Join(" ", traducidas);
        }
    }
}