namespace AplicacionComercial
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrimero = new System.Windows.Forms.ToolStripButton();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.tsbSiguiente = new System.Windows.Forms.ToolStripButton();
            this.tsbUltimo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAplicacionComercial = new AplicacionComercial.DSAplicacionComercial();
            this.tipoDocumentoTableAdapter = new AplicacionComercial.DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombresContacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidosContacto = new System.Windows.Forms.TextBox();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpAniversario = new System.Windows.Forms.DateTimePicker();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrimero,
            this.tsbAnterior,
            this.tsbSiguiente,
            this.tsbUltimo,
            this.tsbModificar,
            this.tsbNuevo,
            this.tsbBorrar,
            this.tsbGuardar,
            this.tsbCancelar,
            this.tsbBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(842, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrimero
            // 
            this.tsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimero.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrimero.Image")));
            this.tsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimero.Name = "tsbPrimero";
            this.tsbPrimero.Size = new System.Drawing.Size(23, 22);
            this.tsbPrimero.Text = "toolStripButton1";
            this.tsbPrimero.ToolTipText = "Primer registro";
            this.tsbPrimero.Click += new System.EventHandler(this.tsbPrimero_Click);
            // 
            // tsbAnterior
            // 
            this.tsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnterior.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnterior.Image")));
            this.tsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnterior.Name = "tsbAnterior";
            this.tsbAnterior.Size = new System.Drawing.Size(23, 22);
            this.tsbAnterior.Text = "toolStripButton2";
            this.tsbAnterior.ToolTipText = "Anterior Registro";
            this.tsbAnterior.Click += new System.EventHandler(this.tsbAnterior_Click);
            // 
            // tsbSiguiente
            // 
            this.tsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("tsbSiguiente.Image")));
            this.tsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSiguiente.Name = "tsbSiguiente";
            this.tsbSiguiente.Size = new System.Drawing.Size(23, 22);
            this.tsbSiguiente.Text = "toolStripButton3";
            this.tsbSiguiente.ToolTipText = "Siguiente Registro";
            this.tsbSiguiente.Click += new System.EventHandler(this.tsbSiguiente_Click);
            // 
            // tsbUltimo
            // 
            this.tsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUltimo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUltimo.Image")));
            this.tsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUltimo.Name = "tsbUltimo";
            this.tsbUltimo.Size = new System.Drawing.Size(23, 22);
            this.tsbUltimo.Text = "toolStripButton4";
            this.tsbUltimo.ToolTipText = "Último registro";
            this.tsbUltimo.Click += new System.EventHandler(this.tsbUltimo_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(23, 22);
            this.tsbModificar.Text = "toolStripButton5";
            this.tsbModificar.ToolTipText = "Modificar registro";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton6";
            this.tsbNuevo.ToolTipText = "Nuevo registro";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBorrar.Image")));
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(23, 22);
            this.tsbBorrar.Text = "toolStripButton7";
            this.tsbBorrar.ToolTipText = "Eliminar Registro";
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Enabled = false;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(23, 22);
            this.tsbGuardar.Text = "toolStripButton8";
            this.tsbGuardar.ToolTipText = "Guardar cambios";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Enabled = false;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "toolStripButton9";
            this.tsbCancelar.ToolTipText = "Cancelar cambios";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "toolStripButton10";
            this.tsbBuscar.ToolTipText = "Buscar registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Cliente:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(125, 37);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.ReadOnly = true;
            this.txtIDCliente.Size = new System.Drawing.Size(129, 20);
            this.txtIDCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Documento *:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DataSource = this.tipoDocumentoBindingSource;
            this.cmbTipoDocumento.DisplayMember = "Descripcion";
            this.cmbTipoDocumento.Enabled = false;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(376, 35);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(129, 21);
            this.cmbTipoDocumento.TabIndex = 4;
            this.cmbTipoDocumento.ValueMember = "IDTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dSAplicacionComercialBindingSource;
            // 
            // dSAplicacionComercialBindingSource
            // 
            this.dSAplicacionComercialBindingSource.DataSource = this.dSAplicacionComercial;
            this.dSAplicacionComercialBindingSource.Position = 0;
            // 
            // dSAplicacionComercial
            // 
            this.dSAplicacionComercial.DataSetName = "DSAplicacionComercial";
            this.dSAplicacionComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(618, 36);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(129, 20);
            this.txtDocumento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documento *:";
            // 
            // txtNombresContacto
            // 
            this.txtNombresContacto.Location = new System.Drawing.Point(125, 72);
            this.txtNombresContacto.Name = "txtNombresContacto";
            this.txtNombresContacto.ReadOnly = true;
            this.txtNombresContacto.Size = new System.Drawing.Size(264, 20);
            this.txtNombresContacto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombres *:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellidos *:";
            // 
            // txtApellidosContacto
            // 
            this.txtApellidosContacto.Location = new System.Drawing.Point(479, 70);
            this.txtApellidosContacto.Name = "txtApellidosContacto";
            this.txtApellidosContacto.ReadOnly = true;
            this.txtApellidosContacto.Size = new System.Drawing.Size(268, 20);
            this.txtApellidosContacto.TabIndex = 10;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(125, 108);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.ReadOnly = true;
            this.txtNombreComercial.Size = new System.Drawing.Size(622, 20);
            this.txtNombreComercial.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre Comercial:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(125, 144);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(622, 20);
            this.txtDireccion.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dirección:";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(125, 183);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.ReadOnly = true;
            this.txtTelefono1.Size = new System.Drawing.Size(264, 20);
            this.txtTelefono1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Teléfono 1:";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(479, 183);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.ReadOnly = true;
            this.txtTelefono2.Size = new System.Drawing.Size(268, 20);
            this.txtTelefono2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Teléfono 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Aniversario:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(125, 226);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(264, 20);
            this.txtCorreo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Correo:";
            // 
            // dtpAniversario
            // 
            this.dtpAniversario.Enabled = false;
            this.dtpAniversario.Location = new System.Drawing.Point(481, 226);
            this.dtpAniversario.Name = "dtpAniversario";
            this.dtpAniversario.Size = new System.Drawing.Size(266, 20);
            this.dtpAniversario.TabIndex = 22;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(125, 264);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ReadOnly = true;
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotas.Size = new System.Drawing.Size(622, 55);
            this.txtNotas.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Notas:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 336);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(818, 194);
            this.dgvDatos.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 542);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpAniversario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellidosContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombresContacto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAplicacionComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrimero;
        private System.Windows.Forms.ToolStripButton tsbAnterior;
        private System.Windows.Forms.ToolStripButton tsbSiguiente;
        private System.Windows.Forms.ToolStripButton tsbUltimo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private DSAplicacionComercial dSAplicacionComercial;
        private System.Windows.Forms.BindingSource dSAplicacionComercialBindingSource;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DSAplicacionComercialTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombresContacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidosContacto;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpAniversario;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}