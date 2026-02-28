using System;
using System.Collections.Generic;

namespace TraductorBasico
{
    class Diccionario
    {
        private Dictionary<string, string> palabrasEsIngles;

        public Diccionario()
        {
            // Palabras de uso cotidiano cargadas al iniciar el programa
            palabrasEsIngles = new Dictionary<string, string>()
            {
                { "casa",       "house"      },
                { "agua",       "water"      },
                { "comida",     "food"       },
                { "perro",      "dog"        },
                { "gato",       "cat"        },
                { "libro",      "book"       },
                { "carro",      "car"        },
                { "puerta",     "door"       },
                { "ventana",    "window"     },
                { "mesa",       "table"      },
                { "silla",      "chair"      },
                { "cama",       "bed"        },
                { "ropa",       "clothes"    },
                { "zapato",     "shoe"       },
                { "celular",    "phone"      },
                { "dinero",     "money"      },
                { "amigo",      "friend"     },
                { "familia",    "family"     },
                { "ciudad",     "city"       },
                { "escuela",    "school"     },
                { "noche",      "night"      },
                { "sol",        "sun"        },
                { "luna",       "moon"       },
                { "cielo",      "sky"        },
                { "lluvia",     "rain"       }
            };
        }

        // Busca la palabra en minúsculas para evitar problemas con mayúsculas
        public string BuscarTraduccion(string palabra)
        {
            string clave = palabra.ToLower();

            if (palabrasEsIngles.ContainsKey(clave))
                return palabrasEsIngles[clave];

            return null;
        }

        public void AgregarPalabra()
        {
            Console.WriteLine("\n--- AGREGAR PALABRA ---");

            Console.Write("Palabra en español: ");
            string espanol = Console.ReadLine()?.Trim().ToLower();

            Console.Write("Traducción en inglés: ");
            string ingles = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrEmpty(espanol) || string.IsNullOrEmpty(ingles))
            {
                Console.WriteLine("[!] Las palabras no pueden estar vacías.");
                return;
            }

            // Si la clave ya existe, pregunta si desea reemplazarla
            if (palabrasEsIngles.ContainsKey(espanol))
            {
                Console.Write($"'{espanol}' ya existe ({palabrasEsIngles[espanol]}). ¿Reemplazar? (s/n): ");
                string respuesta = Console.ReadLine();

                if (respuesta?.ToLower() != "s")
                {
                    Console.WriteLine("Operación cancelada.");
                    return;
                }
            }

            palabrasEsIngles[espanol] = ingles;
            Console.WriteLine($"\n[OK] Palabra agregada: '{espanol}' => '{ingles}'");
        }
    }
}