using Integrador2024.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2024.Datos
{
    public class Dal
    {
        // Productos
        public static void AgregarProducto(Producto producto)
        {
            using SqlConnection connection = new(Conexion.sConnection);
            string query = @"
        INSERT INTO Producto (Nombre, Descripcion, PrecioCosto, PrecioBruto, PrecioVenta,  Margen, IVA, Proveedor, Categoria, Subcategoria)
        VALUES (@Nombre, @Descripcion, @PrecioCosto, @PrecioBruto, @PrecioVenta, @Margen, @IVA, @Proveedor, @Categoria, @Subcategoria)";

            try
            {
                using SqlCommand command = new SqlCommand(query, connection);
                // Asignar los valores de los parámetros
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@PrecioCosto", producto.PrecioCosto);
                command.Parameters.AddWithValue("@PrecioBruto", producto.PrecioBruto);
                command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@Margen", producto.Margen);
                command.Parameters.AddWithValue("@IVA", producto.IVA);
                command.Parameters.AddWithValue("@Proveedor", producto.Proveedor);
                command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                command.Parameters.AddWithValue("@Subcategoria", producto.Subcategoria);

                // Abrir conexión y ejecutar comando
                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Producto agregado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar producto: {ex.Message}");
                throw;
            }
        }
        public static DataTable ObtenerProductos()
        {
            using SqlConnection connection = new(Conexion.sConnection);
            string query = "SELECT * FROM Producto";

            try
            {
                using SqlCommand command = new(query, connection);
                using SqlDataAdapter adapter = new(command);
                DataTable productos = new();
                connection.Open();
                adapter.Fill(productos);
                return productos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener productos: {ex.Message}");
                throw;
            }
        }
        public static void ModificarProducto(int idProducto, string nuevoNombre)
        {
            using SqlConnection connection = new(Conexion.sConnection);
            string query = "UPDATE Producto SET Nombre = @NuevoNombre WHERE ID_PRODUCTO = @ID_PRODUCTO";

            try
            {
                using SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                command.Parameters.AddWithValue("@ID_PRODUCTO", idProducto);

                connection.Open();
                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    throw new Exception("No se encontró ningún producto con el ID proporcionado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al modificar el producto: {ex.Message}");
            }
        }
        public static void EliminarProducto(int idProducto)
        {
            using SqlConnection connection = new(Conexion.sConnection);
            string query = @"DELETE FROM Producto WHERE ID_PRODUCTO = @ID_PRODUCTO";

            try
            {
                using SqlCommand command = new(query, connection);
                // Asignar el valor del parámetro
                command.Parameters.AddWithValue("@ID_PRODUCTO", idProducto);

                
                connection.Open();
                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    Console.WriteLine("Producto eliminado exitosamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún producto con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar producto: {ex.Message}");
                throw;
            }
        }
        // Vendedores
        public static void AgregarVendedor(Vendedor vendedor)
        {
            using SqlConnection connection = new SqlConnection(Conexion.sConnection);
            string query = @"
INSERT INTO VENDEDOR (Nombre, Apellido, DNI, CUIT)
VALUES (@Nombre, @Apellido, @DNI, @CUIT)";

            try
            {
                using SqlCommand command = new SqlCommand(query, connection);
                
                command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                command.Parameters.AddWithValue("@Apellido", vendedor.Apellido);
                command.Parameters.AddWithValue("@DNI", vendedor.DNI);
                command.Parameters.AddWithValue("@CUIT", vendedor.CUIT);

               
                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Vendedor agregado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar vendedor: {ex.Message}");
                throw;
            }
        }
        public static DataTable ObtenerVendedores()
        {
            using SqlConnection connection = new(Conexion.sConnection);
            string query = "SELECT * FROM Vendedor"; 

            try
            {
                using SqlCommand command = new(query, connection);
                using SqlDataAdapter adapter = new(command);
                DataTable vendedor = new();
                connection.Open();
                adapter.Fill(vendedor);
                return vendedor;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener vendedor: {ex.Message}");
                throw;
            }
        }
        public static void ModificarVendedor(Vendedor vendedor)
        {
            using SqlConnection connection = new(Conexion.sConnection);
            string query = @"
    UPDATE VENDEDOR
    SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, CUIT = @CUIT
    WHERE ID_VENDEDOR = @ID_VENDEDOR";

            try
            {
                using SqlCommand command = new SqlCommand(query, connection);
               
                command.Parameters.AddWithValue("@ID_VENDEDOR", vendedor.ID_VENDEDOR);
                command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                command.Parameters.AddWithValue("@Apellido", vendedor.Apellido);
                command.Parameters.AddWithValue("@DNI", vendedor.DNI);
                command.Parameters.AddWithValue("@CUIT", (object)vendedor.CUIT ?? DBNull.Value);  // El value null no me hincha las bolas

                
                connection.Open();
                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    Console.WriteLine("Vendedor modificado exitosamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró un vendedor con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al modificar vendedor: {ex.Message}");
                throw;
            }
        }
        public static void EliminarVendedor(int idVendedor)
        {
            using SqlConnection connection = new(Conexion.sConnection);
            string query = @"DELETE FROM VENDEDOR WHERE ID_VENDEDOR = @ID_VENDEDOR";

            try
            {
                using SqlCommand command = new(query, connection);
               
                command.Parameters.AddWithValue("@ID_VENDEDOR", idVendedor);

                
                connection.Open();
                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    Console.WriteLine("Vendedor eliminado exitosamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún vendedor con el ID especificado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar vendedor: {ex.Message}");
                throw;
            }
        }

    }
}
