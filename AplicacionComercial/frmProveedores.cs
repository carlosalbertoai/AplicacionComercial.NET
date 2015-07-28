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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSAplicacionComercial);
            DeshabilitarCampos();
        }

        private bool ValidarCampos()
        {
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox, "Debe seleccionar un tipo de documento");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }
            errorProvider1.SetError(iDTipoDocumentoComboBox, "");
            
            if (documentoTextBox.Text == "")
            { 
                errorProvider1.SetError(documentoTextBox, "Debe ingresar un numero de documento");
                documentoTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(documentoTextBox, "");
            
            if (nombresContactoTextBox.Text == "")
            {
                errorProvider1.SetError(nombresContactoTextBox, "Debe ingresar un nombre de contacto");
                nombresContactoTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(nombresContactoTextBox, "");
            
            if (apellidosContactoTextBox.Text == "")
            {
                errorProvider1.SetError(apellidosContactoTextBox, "Debe ingresar un apellido de contacto");
                apellidosContactoTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(apellidosContactoTextBox, "");

            if (nombreTextBox.Text == "")
            {
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un nombre de proveedor");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(nombreTextBox, "");

            if (correoTextBox.Text != "")
            {
                RegexUtilities regexUtilities = new RegexUtilities();
                if(!regexUtilities.IsValidEmail(correoTextBox.Text))
                {
                    errorProvider1.SetError(correoTextBox, "Ingrese un correo valido");
                    correoTextBox.Focus();
                    return false;
                }
                errorProvider1.SetError(correoTextBox, "");
            }
            return true;
        }

        private void DeshabilitarCampos()
        {
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorCancel.Enabled = false;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorEdit.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorPositionItem.Enabled = true;
            proveedorBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorSearch.Enabled = true;

            iDTipoDocumentoComboBox.Enabled = false;
            documentoTextBox.ReadOnly = true;
            nombresContactoTextBox.ReadOnly = true;
            apellidosContactoTextBox.ReadOnly = true;
            nombreTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            correoTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            notasTextBox.ReadOnly = true;
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dSAplicacionComercial.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dSAplicacionComercial.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dSAplicacionComercial.Proveedor);

        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorCancel.Enabled = true;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorEdit.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorPositionItem.Enabled = false;
            proveedorBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorSearch.Enabled = false;
            
            iDTipoDocumentoComboBox.Enabled = true;
            documentoTextBox.ReadOnly = false;
            nombresContactoTextBox.ReadOnly = false;
            apellidosContactoTextBox.ReadOnly = false;
            nombreTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            correoTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            notasTextBox.ReadOnly = false;
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.proveedorBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            proveedorBindingSource.AddNew();
            iDTipoDocumentoComboBox.Focus();
        }

        private void nombresContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            ArmaNombre();
        }

        private void ArmaNombre()
        {
            if(iDTipoDocumentoComboBox.SelectedIndex == 0)
            {
                nombreTextBox.Text = nombresContactoTextBox.Text + " " + apellidosContactoTextBox.Text;
            }
        }

        private void apellidosContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            ArmaNombre();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Esta seguro de borrar el registro actual?",
                                                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            proveedorBindingSource.RemoveAt(proveedorBindingSource.Position);
        }
    }
}
