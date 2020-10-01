using Facturacion.Entidades;
using Facturacion.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Servicio.Login
{
    class LoginService
    {

        URLServicios servicios = new URLServicios();
        ClaseMetodos metodos = new ClaseMetodos();

        public dynamic validarUsuario(Usuario usuario)
        {
            try
            {
                dynamic data = metodos.sendRequest($"{servicios.uRL}/auth/login", usuario);

                return data.perfiles;


            }
            catch (Exception)
            {

                throw;
            }
          

        }


    }
}
