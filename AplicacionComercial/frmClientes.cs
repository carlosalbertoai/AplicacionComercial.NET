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
    public partial class frmClientes : Form
    {
        private int i = 0;
        private bool nuevo;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);

            dgvDatos.DataSource = CADCliente.GetData();
            MostrarRegistro();

        }

        private void MostrarRegistro()
        {
            if (dgvDatos.Rows.Count == 0) return;
            txtIDCliente.Text = dgvDatos.Rows[i].Cells["IDCliente"].Value.ToString();
            txtDocumento.Text = dgvDatos.Rows[i].Cells["Documento"].Value.ToString();
            txtNombresContacto.Text = dgvDatos.Rows[i].Cells["NombresContacto"].Value.ToString();
            txtApellidosContacto.Text = dgvDatos.Rows[i].Cells["ApellidosContacto"].Value.ToString();
            txtNombreComercial.Text = dgvDatos.Rows[i].Cells["NombreComercial"].Value.ToString();
            txtTelefono1.Text = dgvDatos.Rows[i].Cells["Telefono1"].Value.ToString();
            txtTelefono2.Text = dgvDatos.Rows[i].Cells["Telefono2"].Value.ToString();
            txtCorreo.Text = dgvDatos.Rows[i].Cells["Correo"].Value.ToString();
            txtNotas.Text = dgvDatos.Rows[i].Cells["Notas"].Value.ToString();
            cmbTipoDocumento.SelectedValue = dgvDatos.Rows[i].Cells["IDTipoDocumento"].Value;
            
            try
            {
                dtpAniversario.Value = Convert.ToDateTime(dgvDatos.Rows[i].Cells["Aniversario"].Value);
            }
            catch (Exception)
            {

                dtpAniversario.Value = DateTime.Now;
            }

        }

        private void tsbSiguiente_Click(object sender, EventArgs e)
        {
            if (i >= dgvDatos.Rows.Count -1) return;
            i++;
            MostrarRegistro();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i--;
            MostrarRegistro();

        }

        private void tsbPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            MostrarRegistro();
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            i = dgvDatos.Rows.Count - 1;
            MostrarRegistro();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            nuevo = false;
        }

        private void HabilitarCampos()
        {
            tsbPrimero.Enabled = false;
            tsbUltimo.Enabled = false;
            tsbAnterior.Enabled = false;
            tsbSiguiente.Enabled = false;
            tsbModificar.Enabled = false;
            tsbNuevo.Enabled = false;
            tsbBorrar.Enabled = false;
            tsbBuscar.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;

            txtDocumento.ReadOnly = false;
            txtNombresContacto.ReadOnly = false;
            txtApellidosContacto.ReadOnly = false;
            txtNombreComercial.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtTelefono1.ReadOnly = false;
            txtTelefono2.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            txtNotas.ReadOnly = false;

            cmbTipoDocumento.Enabled = true;
            dtpAniversario.Enabled = true;
            cmbTipoDocumento.Focus();

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            MostrarRegistro();
        }

        private void DeshabilitarCampos()
        {
            tsbPrimero.Enabled = true;
            tsbUltimo.Enabled = true;
            tsbAnterior.Enabled = true;
            tsbSiguiente.Enabled = true;
            tsbModificar.Enabled = true;
            tsbNuevo.Enabled = true;
            tsbBorrar.Enabled = true;
            tsbBuscar.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;

            txtDocumento.ReadOnly = true;
            txtNombresContacto.ReadOnly = true;
            txtApellidosContacto.ReadOnly = true;
            txtNombreComercial.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtTelefono1.ReadOnly = true;
            txtTelefono2.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtNotas.ReadOnly = true;

            cmbTipoDocumento.Enabled = false;
            dtpAniversario.Enabled = false;
            
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimpiarCampos();
            nuevo = true;
        }

        private void LimpiarCampos()
        {
            txtIDCliente.Text = "";
            txtDocumento.Text = "";
            txtNombresContacto.Text = "";
            txtApellidosContacto.Text = "";
            txtNombreComercial.Text = "";
            txtDireccion.Text = "";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtCorreo.Text = "";
            txtNotas.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
            dtpAniversario.Value = DateTime.Now;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (nuevo)
            {
                CADCliente.InsertCliente(
                                        (int)cmbTipoDocumento.SelectedValue, 
                                        txtDocumento.Text, 
                                        txtNombreComercial.Text,
                                        txtNombresContacto.Text, 
                                        txtApellidosContacto.Text, 
                                        txtDireccion.Text, 
                                        txtTelefono1.Text, 
                                        txtTelefono2.Text, 
                                        txtCorreo.Text, 
                                        txtNotas.Text, 
                                        dtpAniversario.Value
                                        );
            }
            else
            {
                CADCliente.UpdateCliente(
                                        (int)cmbTipoDocumento.SelectedValue,
                                        txtDocumento.Text,
                                        txtNombreComercial.Text,
                                        txtNombresContacto.Text,
                                        txtApellidosContacto.Text,
                                        txtDireccion.Text,
                                        txtTelefono1.Text,
                                        txtTelefono2.Text,
                                        txtCorreo.Text,
                                        txtNotas.Text,
                                        dtpAniversario.Value,
                                        Convert.ToInt32(txtIDCliente.Text)
                                        );
            }
            DeshabilitarCampos();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADCliente.GetData();
            if (nuevo) tsbUltimo_Click(sender, e);
            MostrarRegistro();

        }

        private bool ValidarCampos()
        {
             if(cmbTipoDocumento.SelectedIndex == -1)
             {
                 errorProvider1.SetError(cmbTipoDocumento, "Debe seleccionar un tipo de documento");
                 cmbTipoDocumento.Focus();
                 return false;
             }
             errorProvider1.SetError(cmbTipoDocumento, "");

             if (txtDocumento.Text == "")
             {
                 errorProvider1.SetError(txtDocumento, "Debe ingresar un documento");
                 txtDocumento.Focus();
                 return false;
             }
             errorProvider1.SetError(txtDocumento, "");

             if (txtNombresContacto.Text == "")
             {
                 errorProvider1.SetError(txtNombresContacto, "Debe ingresar un nombre(s) de contacto");
                 txtNombresContacto.Focus();
                 return false;
             }
             errorProvider1.SetError(txtNombresContacto, "");

             if (txtApellidosContacto.Text == "")
             {
                 errorProvider1.SetError(txtApellidosContacto, "Debe ingresar un apellido(s) de contacto");
                 txtApellidosContacto.Focus();
                 return false;
             }
             errorProvider1.SetError(txtApellidosContacto, "");

             if (txtNombreComercial.Text == "")
             {
                 errorProvider1.SetError(txtNombreComercial, "Debe ingresar un nombre comercial");
                 txtNombreComercial.Focus();
                 return false;
             }
             errorProvider1.SetError(txtNombreComercial, "");

             return true;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            
            DialogResult rta = MessageBox.Show("Esta seguro de borrar el registro actual?",
                                                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            CADCliente.DeleteCliente(Convert.ToInt32(txtIDCliente.Text));
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = CADCliente.GetData();
            if (i != 0) i--;
            MostrarRegistro();  
        }
    }
}   
