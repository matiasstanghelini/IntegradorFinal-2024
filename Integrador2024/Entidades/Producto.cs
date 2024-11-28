using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2024.Entidades
{
    public class Producto(int idProducto, string pNombre, string pDescripcion, decimal pPrecioCosto,
        double pMargen, double pIVA, decimal pPrecioBruto, decimal pPrecioVenta,
        string pProveedor, string pCategoria, string pSubcategoria)
    {
        internal int ID;

        public Producto(string pNombre, string pDescripcion, decimal pPrecioCosto,
            double pMargen, double pIVA, decimal pPrecioBruto, decimal pPrecioVenta,
            string pProveedor, string pCategoria, string pSubcategoria)
            : this(0, pNombre, pDescripcion, pPrecioCosto, pMargen, pIVA, pPrecioBruto, pPrecioVenta, pProveedor, pCategoria, pSubcategoria)
        {
        }


        public int ID_PRODUCTO { get; set; } = idProducto;
        public string Nombre { get; set; } = pNombre;
        public string Descripcion { get; set; } = pDescripcion;
        public decimal PrecioCosto { get; set; } = pPrecioCosto;
        public double Margen { get; set; } = pMargen;
        public double IVA { get; set; } = pIVA;
        public decimal PrecioBruto { get; set; } = pPrecioBruto;
        public decimal PrecioVenta { get; set; } = pPrecioVenta;
        public string Proveedor { get; set; } = pProveedor;
        public string Categoria { get; set; } = pCategoria;
        public string Subcategoria { get; set; } = pSubcategoria;
    }
}
