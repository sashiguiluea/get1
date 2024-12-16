using System;
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
        // Definimos un array de productos de tamaño fijo, en este caso, 10
        static Producto[] productos = new Producto[10];
        static int contador = 0; // Control de la cantidad de productos agregados

        public static void MostrarMenuSemana3()
        {
            int opcion;
            do
            {
                Console.Clear();
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
            if (contador < productos.Length)  // Verificamos si hay espacio en la matriz
            {
                Console.Write("Ingrese el ID del producto: ");
                int id = int.Parse(Console.ReadLine());

                // Validar que el ID no exista
                if (productos.Any(p => p != null && p.Id == id))
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

                productos[contador] = nuevoProducto;  // Guardamos el producto en la posición indicada por el contador
                contador++;  // Incrementamos el contador

                Console.WriteLine("Producto agregado correctamente.");
            }
            else
            {
                Console.WriteLine("No hay espacio suficiente para agregar más productos.");
            }
        }

        public static void MostrarProductos()
        {
            Console.WriteLine("\nLista de Productos:");
            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                for (int i = 0; i < contador; i++)  // Recorremos hasta el número de productos agregados
                {
                    if (productos[i] != null)  // Verificamos que el producto no sea null
                    {
                        Console.WriteLine($"ID: {productos[i].Id}");
                        Console.WriteLine($"Nombre: {productos[i].Nombre}");
                        Console.WriteLine($"Precio PVP: {productos[i].PrecioPVP:C}");
                        Console.WriteLine($"Precio Proveedores: {productos[i].PrecioProvedores:C}");
                        Console.WriteLine($"Precio Oferta: {productos[i].PrecioOferta:C}");
                    }
                }
            }
        }

        public static void BuscarProducto()
        {
            Console.Write("Ingrese el nombre del producto a buscar: ");
            string nombreABuscar = Console.ReadLine();

            var productosEncontrados = productos.Where(p => p != null && p.Nombre.Contains(nombreABuscar, StringComparison.OrdinalIgnoreCase));

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
                Producto productoAEliminar = productos.FirstOrDefault(p => p != null && p.Id == idEliminar);
                if (productoAEliminar != null)
                {
                    // Encontramos el producto a eliminar y lo desplazamos hacia la izquierda para llenar el vacío
                    int index = Array.IndexOf(productos, productoAEliminar);
                    for (int i = index; i < contador - 1; i++)
                    {
                        productos[i] = productos[i + 1];  // Desplazamos los productos a la izquierda
                    }
                    productos[contador - 1] = null;  // Limpiamos el último producto

                    contador--;  // Decrementamos el contador
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
                Producto productoAModificar = productos.FirstOrDefault(p => p != null && p.Id == idModificar);
                if (productoAModificar != null)
                {
                    // Pedir los nuevos datos del producto y actualizarlos
                    Console.Write("Ingrese el nuevo nombre: ");
                    productoAModificar.Nombre = Console.ReadLine();

                    Console.Write("Ingrese el nuevo precio PVP: ");
                    productoAModificar.PrecioPVP = decimal.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nuevo precio para proveedores: ");
                    productoAModificar.PrecioProvedores = decimal.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nuevo precio de oferta: ");
                    productoAModificar.PrecioOferta = decimal.Parse(Console.ReadLine());

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
