using System;

namespace Integrador2024.Entidades
{
    public class Vendedor(int idVendedor, string nombre, string apellido, string dni, string cuit)
    {
        public int ID_VENDEDOR { get; set; } = idVendedor;
        public string Nombre { get; set; } = nombre;
        public string Apellido { get; set; } = apellido;
        public string DNI { get; set; } = dni;
        public string CUIT { get; set; } = cuit;
    }

}
