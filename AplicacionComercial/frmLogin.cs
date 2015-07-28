using CADAplicacionComercial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionComercial
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar un usuario");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.SetError(txtUsuario, "");
            
            if (txtContraseña.Text == "")
            {
                errorProvider1.SetError(txtContraseña, "Debe ingresar una contraseña");
                txtContraseña.Focus();
                return;
            }
            errorProvider1.SetError(txtContraseña, "");

            if(!CADUsuario.validarUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Usuario o Clave no Válidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
                return;
            }

            frmPrincipal miForm = new frmPrincipal();
            miForm.Show();
            this.Hide();

        }
    }
}
