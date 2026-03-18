using System;

namespace ArbolBinarioBST
{
    class Program
    {
        static ArbolBST arbol = new ArbolBST();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int op;
            do
            {
                Menu();
                Console.Write("  Opcion: ");
                if (!int.TryParse(Console.ReadLine(), out op))
                { Console.WriteLine("  [!] Numero invalido."); Pausa(); continue; }

                Console.WriteLine();
                switch (op)
                {
                    case 1: Leer("Insertar", v => { arbol.Insertar(v); Console.WriteLine($"  [OK] {v} insertado."); }); break;
                    case 2: Leer("Buscar",   v => Console.WriteLine(arbol.Buscar(v) ? $"  [OK] {v} ENCONTRADO." : $"  [X] {v} NO encontrado.")); break;
                    case 3: Leer("Eliminar", v => arbol.Eliminar(v)); break;
                    case 4:
                        if (arbol.EstaVacio()) { Console.WriteLine("  [!] Arbol vacio."); break; }
                        arbol.Preorden(); arbol.Inorden(); arbol.Postorden(); break;
                    case 5:
                        if (arbol.EstaVacio()) { Console.WriteLine("  [!] Arbol vacio."); break; }
                        arbol.Minimo(); arbol.Maximo(); arbol.Altura(); break;
                    case 6:
                        Console.Write("  Limpiar? (s/n): ");
                        if (Console.ReadLine()?.ToLower() == "s") arbol.Limpiar();
                        else Console.WriteLine("  Cancelado."); break;
                    case 0: Console.WriteLine("  Hasta pronto, Jessica!"); break;
                    default: Console.WriteLine("  [!] Opcion invalida."); break;
                }
                if (op != 0) Pausa();
            } while (op != 0);
        }

        static void Leer(string accion, Action<int> ejecutar)
        {
            Console.Write($"  Valor a {accion}: ");
            if (int.TryParse(Console.ReadLine(), out int v)) ejecutar(v);
            else Console.WriteLine("  [!] Valor invalido.");
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("  ╔══════════════════════════════════════════════╗");
            Console.WriteLine("  ║      ARBOL BINARIO DE BUSQUEDA (BST)         ║");
            Console.WriteLine("  ╠══════════════════════════════════════════════╣");
            Console.WriteLine("  ║  Estudiante : Jessica Pesantez               ║");
            Console.WriteLine("  ║  Carrera    : Ing. Tecnologias Informacion   ║");
            Console.WriteLine("  ║  Docente    : MSc. Gabriel Vaca Ortega       ║");
            Console.WriteLine("  ║  Materia    : Estructura de Datos            ║");
            Console.WriteLine("  ╠══════════════════════════════════════════════╣");
            Console.WriteLine("  ║  1. Insertar    2. Buscar    3. Eliminar     ║");
            Console.WriteLine("  ║  4. Recorridos  5. Min/Max/Altura            ║");
            Console.WriteLine("  ║  6. Limpiar     0. Salir                     ║");
            Console.WriteLine("  ╚══════════════════════════════════════════════╝");
        }

        static void Pausa() { Console.WriteLine("\n  Tecla para continuar..."); Console.ReadKey(); }
    }
}