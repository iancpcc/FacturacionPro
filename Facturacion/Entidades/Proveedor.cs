using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RUC { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }

        public Proveedor()
        {

        }
        public Proveedor(int id, string nombre, string rUC, string telefono, string direccion, string estado)
        {
            Id = id;
            Nombre = nombre;
            RUC = rUC;
            Telefono = telefono;
            Direccion = direccion;
            Estado = estado;
        }
    }
}
