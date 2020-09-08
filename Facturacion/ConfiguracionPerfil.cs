using Facturacion.Configuracion;
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
    public partial class ConfiguracionPerfil : Form
    {
        public ConfiguracionPerfil()
        {
            InitializeComponent();
            abrirFormulario(new Perfil());
        }

        private void abrirFormulario(object formulario)
        {
            if (this.panelConfiguracion.Controls.Count > 0)
            {
                this.panelConfiguracion.Controls.RemoveAt(0);
            }
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConfiguracion.Controls.Add(fh);
            this.panelConfiguracion.Tag = fh;
            fh.Show();


        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Perfil());
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Contraseña());

        }
    }

}
