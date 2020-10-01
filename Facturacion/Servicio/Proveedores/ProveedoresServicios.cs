using Facturacion.Entidades;
using Facturacion.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Facturacion.Servicio.Proveedores
{
    class ProveedoresServicios
    {
        URLServicios servicios = new URLServicios();
        ClaseMetodos metodos = new ClaseMetodos();
        public List<Proveedor> ListadoProveedores()
            {
            try
            {
                List<Proveedor> listadoJSON = new List<Proveedor>();

                dynamic respuesta = metodos.getRequest($"{servicios.uRL}/proveedores");

                foreach (var proveedor in respuesta.proveedores)
                {
                    listadoJSON.Add(new Proveedor(Convert.ToInt32(proveedor.id), Convert.ToString(proveedor.ruc), Convert.ToString(proveedor.nombre), Convert.ToString(proveedor.direccion), Convert.ToString(proveedor.telefono)));
                }
                return listadoJSON;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
    }
}
