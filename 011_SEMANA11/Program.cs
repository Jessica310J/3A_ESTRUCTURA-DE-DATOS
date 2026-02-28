using System;

namespace TraductorBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Diccionario diccionario = new Diccionario();
            Traductor traductor = new Traductor(diccionario);

            bool salir = false;

            // Mantiene el programa en ejecución hasta que el usuario elija salir
            while (!salir)
            {
                MostrarMenu();
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        traductor.TraducirFrase();
                        break;
                    case "2":
                        diccionario.AgregarPalabra();
                        break;
                    case "0":
                        salir = true;
                        Console.WriteLine("\nCerrando el traductor... ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("\n[!] Opción no válida. Intente nuevamente.\n");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.WriteLine("==============================================");
        }
    }
}