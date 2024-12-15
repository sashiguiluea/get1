using System;
using System.Collections.Generic;
using System.Linq;

namespace MiProyectoCSharp
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioPVP { get; set; }
        public decimal PrecioProvedores { get; set; }
        public decimal PrecioOferta { get; set; }
    }

    public class semana3
    {
        static List<Producto> productos = new List<Producto>();

        public static void MostrarMenuSemana3()
        {
            int opcion;
            do
            {
                Console.Clear();
                encabezado.MostrarEncabezado();
                Console.WriteLine("Menú de Productos");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Eliminar producto");
                Console.WriteLine("5. Modificar producto");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarProducto();
                        break;
                    case 2:
                        MostrarProductos();
                        break;
                    case 3:
                        BuscarProducto();
                        break;
                    case 4:
                        EliminarProducto();
                        break;
                    case 5:
                        ModificarProducto();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 0);
        }

        public static void AgregarProducto()
        {
            Console.Write("Ingrese el ID del producto: ");
            int id = int.Parse(Console.ReadLine());

            // Validar que el ID no exista
            if (productos.Any(p => p.Id == id))
            {
                Console.WriteLine("Ya existe un producto con ese ID.");
                return;
            }

            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el precio PVP: ");
            decimal precioPVP = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio para proveedores: ");
            decimal precioProvedores = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio de oferta: ");
            decimal precioOferta = decimal.Parse(Console.ReadLine());

            Producto nuevoProducto = new Producto
            {
                Id = id,
                Nombre = nombre,
                PrecioPVP = precioPVP,
                PrecioProvedores = precioProvedores,
                PrecioOferta = precioOferta
            };
            productos.Add(nuevoProducto);

            Console.WriteLine("Producto agregado correctamente.");
        }

        public static void MostrarProductos()
        {
            Console.WriteLine("\nLista de Productos:");
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                foreach (var producto in productos)
                {
                    Console.WriteLine($"ID: {producto.Id}");
                    Console.WriteLine($"Nombre: {producto.Nombre}");
                    Console.WriteLine($"Precio PVP: {producto.PrecioPVP:C}");
                    Console.WriteLine($"Precio Proveedores: {producto.PrecioProvedores:C}");
                    Console.WriteLine($"Precio Oferta: {producto.PrecioOferta:C}");
                }
            }
        }

        public static void BuscarProducto()
        {
            Console.Write("Ingrese el nombre del producto a buscar: ");
            string nombreABuscar = Console.ReadLine();

            var productosEncontrados = productos.Where(p => p.Nombre.Contains(nombreABuscar, StringComparison.OrdinalIgnoreCase));

            if (productosEncontrados.Any())
            {
                Console.WriteLine("Productos encontrados:");
                foreach (var producto in productosEncontrados)
                {
                    Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Nombre}, Precio PVP: {producto.PrecioPVP:C}, Precio Proveedores: {producto.PrecioProvedores:C}, Precio Oferta: {producto.PrecioOferta:C}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron productos con ese nombre.");
            }
        }

        public static void EliminarProducto()
        {
            Console.Write("Ingrese el ID del producto a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int idEliminar))
            {
                Producto productoAEliminar = productos.FirstOrDefault(p => p.Id == idEliminar);
                if (productoAEliminar != null)
                {
                    productos.Remove(productoAEliminar);
                    Console.WriteLine("Producto eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró un producto con ese ID.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }

        public static void ModificarProducto()
        {
            Console.Write("Ingrese el ID del producto a modificar: ");
            if (int.TryParse(Console.ReadLine(), out int idModificar))
            {
                Producto productoAModificar = productos.FirstOrDefault(p => p.Id == idModificar);
                if (productoAModificar != null)
                {
                    // Pedir los nuevos datos del producto y actualizarlos
                    Console.Write("Ingrese el nuevo nombre: ");
                    productoAModificar.Nombre = Console.ReadLine();
                    // ... (Actualizar otros campos)
                    Console.WriteLine("Producto modificado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró un producto con ese ID.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }
    }
}