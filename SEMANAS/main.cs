using System;

namespace MiProyectoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                // Mostrar el menú principal
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                EscribirTextoConEfecto("Bienvenido al menú interactivo");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("BBBBB   III  SSSSS  H   H  OOO   X   X");
                Console.WriteLine("B    B   I   S      H   H O   O   X X");
                Console.WriteLine("BBBBB    I   SSS    HHHHH O   O    X");
                Console.WriteLine("B    B   I      S   H   H O   O   X X");
                Console.WriteLine("BBBBB   III  SSSSS  H   H  OOO   X   X");
                Console.WriteLine("");
                encabezado.MostrarEncabezado();
                Console.WriteLine("");
                Console.WriteLine("Seleccione una opción:");
                EscribirTextoConEfecto("Seleccione una opción:");
                Console.WriteLine("1. Semana 2: Calcular área y perímetro de Figuras Geometricas");
                Console.WriteLine("2. Semana 3: Matrices y Arrays");
                Console.WriteLine("0. Salir");
                Console.Write("\nOpción: ");

                // Leer la opción seleccionada por el usuario
                opcion = Convert.ToInt32(Console.ReadLine());

                // Ejecutar la acción correspondiente según la opción seleccionada
                switch (opcion)
                {
                    case 1:
                        semana2.MostrarMenuSemana2(); // Llamar al menú de la semana 2
                        break;
                    case 2:
                        // Aquí iría el código para la semana 3, si ya la tienes implementada
                        semana3.MostrarMenuSemana3();
                        break; 
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta nuevamente.");
                        break;
                }

                // Esperar a que el usuario presione una tecla para continuar
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 0); // El menú continuará hasta que se seleccione la opción 0 (salir)
        }

        public static void EscribirTextoConEfecto(string texto)
        {
            foreach (char c in texto)
            {
                Console.Write(c);
                Thread.Sleep(50); // Espera 50 milisegundos para simular el tipeo
            }
            Console.WriteLine(); // Añadir salto de línea después del texto
        }
    }

    
}
