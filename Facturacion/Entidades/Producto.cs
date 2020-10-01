using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int Estado { get; set; }
        public int IdProveedor { get; set; }

        public Producto()
        {

        }
        public Producto(int id, string nombre, string codigo, float precio, int stock, int idproveedor, int estado)
        {
            Id = id;
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            Stock = stock;
            IdProveedor = idproveedor;
            Estado = estado;
        }

    }
}
