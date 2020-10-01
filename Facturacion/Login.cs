using Facturacion.Entidades;
using Facturacion.Servicio.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Login : Form
    {
        LoginService service = new LoginService();
        public Login()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarSistema();
        }

        #region Acceso Sistema
        private void IngresarSistema()
        {
            try
            {
                Usuario user = new Usuario();
                user.email = txtUsuario.Text;
                user.password = txtPassword.Text;
                var response = service.validarUsuario(user);
            
               if (response[0].nombre == "Administrador" || response[1].nombre == "Cajero")
                {

                    Dashboard principal = new Dashboard();
                    principal.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        #endregion

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
