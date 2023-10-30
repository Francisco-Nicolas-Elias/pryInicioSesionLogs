using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryInicioSesionLogs
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            clsUsuario objUsuario = new clsUsuario();

            objUsuario.ValidarUsuario(txtNombre.Text, txtPassword.Text);

            if (objUsuario.estadoConexion == "Usuario EXISTE")
            {
                MessageBox.Show("Ingrese al sistema...");
                objUsuario.RegistroLogInicioSesion();
            }
            else
            {
                MessageBox.Show("No pasaràs...");
                objUsuario.RegistroLogInicioSesion();
            }

        }
    }
}
