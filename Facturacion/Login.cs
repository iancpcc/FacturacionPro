﻿using System;
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
            Dashboard principal = new Dashboard();
            principal.Show();
            this.Hide();
        } 
        #endregion
    }
}
