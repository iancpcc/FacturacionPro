using Newtonsoft.Json;
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
        public string RUC { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Proveedor()
        {

        }
        public Proveedor(int id, string ruc, string nombre, string direccion, string telefono)
        {
            Id = id;
            RUC = ruc;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    
    
    }
}
