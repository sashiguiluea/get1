using System;

namespace MiProyectoCSharp
{
    public class semana2
    {
        public static void MostrarMenuSemana2()
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                encabezado.MostrarEncabezado();
                EscribirTextoConEfecto("Seleccione una opción:");
                Console.WriteLine("1. Calcular área y perímetro del triángulo");
                Console.WriteLine("2. Calcular área y perímetro del trapecio");
                Console.WriteLine("3. Calcular área y perímetro de la elipse");
                Console.WriteLine("0. Salir");
                Console.Write("\nOpción: ");
                //opcion = Convert.ToInt32(Console.ReadLine());
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: CalcularTriangulo(); break;
                    case 2: CalcularTrapecio(); break;
                    case 3: CalcularElipse(); break;
                    case 0: Console.WriteLine("Saliendo..."); return;
                    default: Console.WriteLine("Opción no válida."); break;
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 0);
        }

        public static void CalcularTriangulo()
        {
            EscribirTextoConEfecto("Seleccione una opción:");
            Console.WriteLine("1. Área");
            Console.WriteLine("2. Perímetro");
            Console.Write("\nOpción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.Write("Datos para el area del triangulo");
                Console.Write("\nBase del triángulo: ");
                double baseT = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura del triángulo: "); 
                double altura = Convert.ToDouble(Console.ReadLine());
                double area = (baseT * altura) / 2;
                Console.WriteLine($"Área del triángulo: {area}");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Datos para el perímetro del triangulo");
                Console.Write("Lado 1: ");
                double lado1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado 2: ");
                double lado2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado 3: ");
                double lado3 = Convert.ToDouble(Console.ReadLine());
                double perimetro = lado1 + lado2 + lado3;
                Console.WriteLine($"Perímetro del triángulo: {perimetro}");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        public static void CalcularTrapecio()
        {
            EscribirTextoConEfecto("Seleccione una opción:");
            Console.WriteLine("1. Área");
            Console.WriteLine("2. Perímetro");
            Console.Write("\nOpción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.Write("Base mayor: ");
                double baseMayor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Base menor: ");
                double baseMenor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                double area = (baseMayor + baseMenor) * altura / 2;
                Console.WriteLine($"Área del trapecio: {area}");
            }
            else if (opcion == 2)
            {
                Console.Write("Lado 1: ");
                double lado1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado 2: ");
                double lado2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Base mayor: ");
                double baseMayor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Base menor: ");
                double baseMenor = Convert.ToDouble(Console.ReadLine());
                double perimetro = baseMayor + baseMenor + lado1 + lado2;
                Console.WriteLine($"Perímetro del trapecio: {perimetro}");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        public static void CalcularElipse()
        {
            EscribirTextoConEfecto("Seleccione una opción:");
            Console.WriteLine("1. Área");
            Console.WriteLine("2. Perímetro");
            Console.Write("\nOpción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                Console.Write("Semi-eje mayor: ");
                double semiEjeMayor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Semi-eje menor: ");
                double semiEjeMenor = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * semiEjeMayor * semiEjeMenor;
                Console.WriteLine($"Área de la elipse: {area}");
            }
            else if (opcion == 2)
            {
                Console.Write("Semi-eje mayor: ");
                double semiEjeMayor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Semi-eje menor: ");
                double semiEjeMenor = Convert.ToDouble(Console.ReadLine());
                double perimetro = Math.PI * (3 * (semiEjeMayor + semiEjeMenor) - Math.Sqrt((3 * semiEjeMayor + semiEjeMenor) * (semiEjeMayor + 3 * semiEjeMenor)));
                Console.WriteLine($"Perímetro de la elipse: {perimetro}");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
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
