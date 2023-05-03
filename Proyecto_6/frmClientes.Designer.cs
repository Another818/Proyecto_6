namespace Proyecto_6
{
    partial class frmClientes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deudor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Condicion_Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblDeudor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.txtbCuit = new System.Windows.Forms.TextBox();
            this.txtbAltura = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalirCli = new System.Windows.Forms.Button();
            this.btnAceptarCli = new System.Windows.Forms.Button();
            this.btnCancelarCli = new System.Windows.Forms.Button();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.btnBorrarCli = new System.Windows.Forms.Button();
            this.btnEditarCli = new System.Windows.Forms.Button();
            this.btnAgregarCli = new System.Windows.Forms.Button();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.lblBarrios = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtbBuscar = new System.Windows.Forms.TextBox();
            this.clbDeudor = new System.Windows.Forms.CheckedListBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblCondicionIva = new System.Windows.Forms.Label();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.cboCondicionIva = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboCalle = new System.Windows.Forms.ComboBox();
            this.txtbSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Cliente,
            this.Apellido,
            this.Nombre,
            this.Telefono,
            this.Cuit,
            this.Saldo,
            this.Deudor,
            this.Email,
            this.Cod_Condicion_Iva,
            this.Descripcion,
            this.Cod_Provincia,
            this.Provincia,
            this.Cod_Localidad,
            this.Localidad,
            this.Cod_Barrio,
            this.Barrio,
            this.Cod_Calle,
            this.Calle,
            this.Altura});
            this.dgvClientes.GridColor = System.Drawing.Color.LightSalmon;
            this.dgvClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(821, 353);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // Cod_Cliente
            // 
            this.Cod_Cliente.DataPropertyName = "Cod_Cliente";
            this.Cod_Cliente.HeaderText = "Código";
            this.Cod_Cliente.Name = "Cod_Cliente";
            this.Cod_Cliente.ReadOnly = true;
            this.Cod_Cliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cod_Cliente.Width = 70;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Apellido.Width = 110;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 110;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            this.Cuit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Deudor
            // 
            this.Deudor.DataPropertyName = "Deudor";
            this.Deudor.HeaderText = "Deudor";
            this.Deudor.Name = "Deudor";
            this.Deudor.ReadOnly = true;
            this.Deudor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cod_Condicion_Iva
            // 
            this.Cod_Condicion_Iva.DataPropertyName = "Cod_Condicion_Iva";
            this.Cod_Condicion_Iva.HeaderText = "Cod_Condicion";
            this.Cod_Condicion_Iva.Name = "Cod_Condicion_Iva";
            this.Cod_Condicion_Iva.ReadOnly = true;
            this.Cod_Condicion_Iva.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cod_Condicion_Iva.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Condición Iva";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cod_Provincia
            // 
            this.Cod_Provincia.DataPropertyName = "Cod_Provincia";
            this.Cod_Provincia.HeaderText = "Cod_Provincia";
            this.Cod_Provincia.Name = "Cod_Provincia";
            this.Cod_Provincia.ReadOnly = true;
            this.Cod_Provincia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cod_Provincia.Visible = false;
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Provincia.Visible = false;
            // 
            // Cod_Localidad
            // 
            this.Cod_Localidad.DataPropertyName = "Cod_Localidad";
            this.Cod_Localidad.HeaderText = "Cod_Localidad";
            this.Cod_Localidad.Name = "Cod_Localidad";
            this.Cod_Localidad.ReadOnly = true;
            this.Cod_Localidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cod_Localidad.Visible = false;
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            this.Localidad.ReadOnly = true;
            this.Localidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Localidad.Visible = false;
            // 
            // Cod_Barrio
            // 
            this.Cod_Barrio.DataPropertyName = "Cod_Barrio";
            this.Cod_Barrio.HeaderText = "Cod_Barrio";
            this.Cod_Barrio.Name = "Cod_Barrio";
            this.Cod_Barrio.ReadOnly = true;
            this.Cod_Barrio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cod_Barrio.Visible = false;
            // 
            // Barrio
            // 
            this.Barrio.DataPropertyName = "Barrio";
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Barrio.Visible = false;
            // 
            // Cod_Calle
            // 
            this.Cod_Calle.DataPropertyName = "Cod_Calle";
            this.Cod_Calle.HeaderText = "Cod_Calle";
            this.Cod_Calle.Name = "Cod_Calle";
            this.Cod_Calle.ReadOnly = true;
            this.Cod_Calle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cod_Calle.Visible = false;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "Calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Calle.Visible = false;
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "Altura";
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Altura.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 20);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(236, 24);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(60, 18);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(236, 68);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(42, 18);
            this.lblCUIT.TabIndex = 4;
            this.lblCUIT.Text = "CUIT:";
            // 
            // lblDeudor
            // 
            this.lblDeudor.AutoSize = true;
            this.lblDeudor.Location = new System.Drawing.Point(8, 299);
            this.lblDeudor.Name = "lblDeudor";
            this.lblDeudor.Size = new System.Drawing.Size(55, 18);
            this.lblDeudor.TabIndex = 5;
            this.lblDeudor.Text = "Deudor:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 112);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(236, 112);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 18);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "Altura:";
            // 
            // txtbApellido
            // 
            this.txtbApellido.Location = new System.Drawing.Point(73, 17);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.Size = new System.Drawing.Size(126, 25);
            this.txtbApellido.TabIndex = 1;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(73, 65);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(126, 25);
            this.txtbNombre.TabIndex = 2;
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Location = new System.Drawing.Point(298, 21);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(124, 25);
            this.txtbTelefono.TabIndex = 3;
            // 
            // txtbCuit
            // 
            this.txtbCuit.Location = new System.Drawing.Point(283, 65);
            this.txtbCuit.Name = "txtbCuit";
            this.txtbCuit.Size = new System.Drawing.Size(139, 25);
            this.txtbCuit.TabIndex = 4;
            // 
            // txtbAltura
            // 
            this.txtbAltura.Location = new System.Drawing.Point(288, 109);
            this.txtbAltura.Name = "txtbAltura";
            this.txtbAltura.Size = new System.Drawing.Size(134, 25);
            this.txtbAltura.TabIndex = 6;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(56, 109);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(138, 25);
            this.txtbEmail.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnSalirCli);
            this.panel1.Controls.Add(this.btnAceptarCli);
            this.panel1.Controls.Add(this.btnCancelarCli);
            this.panel1.Controls.Add(this.btnBuscarCli);
            this.panel1.Controls.Add(this.btnBorrarCli);
            this.panel1.Controls.Add(this.btnEditarCli);
            this.panel1.Controls.Add(this.btnAgregarCli);
            this.panel1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 512);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 71);
            this.panel1.TabIndex = 15;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(1015, 22);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 32);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalirCli
            // 
            this.btnSalirCli.Location = new System.Drawing.Point(1116, 22);
            this.btnSalirCli.Name = "btnSalirCli";
            this.btnSalirCli.Size = new System.Drawing.Size(75, 32);
            this.btnSalirCli.TabIndex = 6;
            this.btnSalirCli.Text = "Salir";
            this.btnSalirCli.UseVisualStyleBackColor = true;
            this.btnSalirCli.Click += new System.EventHandler(this.btnSalirCli_Click);
            // 
            // btnAceptarCli
            // 
            this.btnAceptarCli.Location = new System.Drawing.Point(701, 22);
            this.btnAceptarCli.Name = "btnAceptarCli";
            this.btnAceptarCli.Size = new System.Drawing.Size(75, 32);
            this.btnAceptarCli.TabIndex = 4;
            this.btnAceptarCli.Text = "Aceptar";
            this.btnAceptarCli.UseVisualStyleBackColor = true;
            this.btnAceptarCli.Click += new System.EventHandler(this.btnAceptarCli_Click);
            // 
            // btnCancelarCli
            // 
            this.btnCancelarCli.Location = new System.Drawing.Point(782, 22);
            this.btnCancelarCli.Name = "btnCancelarCli";
            this.btnCancelarCli.Size = new System.Drawing.Size(75, 32);
            this.btnCancelarCli.TabIndex = 5;
            this.btnCancelarCli.Text = "Cancelar";
            this.btnCancelarCli.UseVisualStyleBackColor = true;
            this.btnCancelarCli.Click += new System.EventHandler(this.btnCancelarCli_Click);
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(366, 22);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(75, 32);
            this.btnBuscarCli.TabIndex = 3;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // btnBorrarCli
            // 
            this.btnBorrarCli.Location = new System.Drawing.Point(256, 22);
            this.btnBorrarCli.Name = "btnBorrarCli";
            this.btnBorrarCli.Size = new System.Drawing.Size(75, 32);
            this.btnBorrarCli.TabIndex = 2;
            this.btnBorrarCli.Text = "Borrar";
            this.btnBorrarCli.UseVisualStyleBackColor = true;
            this.btnBorrarCli.Click += new System.EventHandler(this.btnBorrarCli_Click);
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.Location = new System.Drawing.Point(147, 22);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(75, 32);
            this.btnEditarCli.TabIndex = 1;
            this.btnEditarCli.Text = "Editar";
            this.btnEditarCli.UseVisualStyleBackColor = true;
            this.btnEditarCli.Click += new System.EventHandler(this.btnEditarCli_Click);
            // 
            // btnAgregarCli
            // 
            this.btnAgregarCli.Location = new System.Drawing.Point(40, 22);
            this.btnAgregarCli.Name = "btnAgregarCli";
            this.btnAgregarCli.Size = new System.Drawing.Size(75, 32);
            this.btnAgregarCli.TabIndex = 0;
            this.btnAgregarCli.Text = "Agregar";
            this.btnAgregarCli.UseVisualStyleBackColor = true;
            this.btnAgregarCli.Click += new System.EventHandler(this.btnAgregarCli_Click);
            // 
            // cboBarrios
            // 
            this.cboBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(63, 194);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(126, 26);
            this.cboBarrios.TabIndex = 9;
            // 
            // lblBarrios
            // 
            this.lblBarrios.AutoSize = true;
            this.lblBarrios.Location = new System.Drawing.Point(6, 194);
            this.lblBarrios.Name = "lblBarrios";
            this.lblBarrios.Size = new System.Drawing.Size(55, 18);
            this.lblBarrios.TabIndex = 16;
            this.lblBarrios.Text = "Barrios:";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lblBuscar);
            this.gbBusqueda.Controls.Add(this.txtbBuscar);
            this.gbBusqueda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(12, 383);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(821, 98);
            this.gbBusqueda.TabIndex = 18;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(25, 43);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(52, 18);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtbBuscar
            // 
            this.txtbBuscar.Location = new System.Drawing.Point(83, 43);
            this.txtbBuscar.Name = "txtbBuscar";
            this.txtbBuscar.Size = new System.Drawing.Size(136, 25);
            this.txtbBuscar.TabIndex = 0;
            this.txtbBuscar.TextChanged += new System.EventHandler(this.txtbBuscarCli_TextChanged);
            // 
            // clbDeudor
            // 
            this.clbDeudor.BackColor = System.Drawing.Color.Silver;
            this.clbDeudor.CheckOnClick = true;
            this.clbDeudor.FormattingEnabled = true;
            this.clbDeudor.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.clbDeudor.Location = new System.Drawing.Point(69, 290);
            this.clbDeudor.Name = "clbDeudor";
            this.clbDeudor.Size = new System.Drawing.Size(66, 44);
            this.clbDeudor.TabIndex = 13;
            this.clbDeudor.SelectedIndexChanged += new System.EventHandler(this.clbDeudor_SelectedIndexChanged);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(236, 154);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 18);
            this.lblLocalidad.TabIndex = 20;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(6, 154);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(69, 18);
            this.lblProvincia.TabIndex = 21;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(236, 194);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(41, 18);
            this.lblCalle.TabIndex = 22;
            this.lblCalle.Text = "Calle:";
            // 
            // lblCondicionIva
            // 
            this.lblCondicionIva.AutoSize = true;
            this.lblCondicionIva.Location = new System.Drawing.Point(6, 241);
            this.lblCondicionIva.Name = "lblCondicionIva";
            this.lblCondicionIva.Size = new System.Drawing.Size(94, 18);
            this.lblCondicionIva.TabIndex = 23;
            this.lblCondicionIva.Text = "Condición Iva:";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(304, 151);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(118, 26);
            this.cboLocalidad.TabIndex = 8;
            this.cboLocalidad.SelectedIndexChanged += new System.EventHandler(this.cboLocalidad_SelectedIndexChanged);
            // 
            // cboCondicionIva
            // 
            this.cboCondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicionIva.FormattingEnabled = true;
            this.cboCondicionIva.Location = new System.Drawing.Point(106, 238);
            this.cboCondicionIva.Name = "cboCondicionIva";
            this.cboCondicionIva.Size = new System.Drawing.Size(123, 26);
            this.cboCondicionIva.TabIndex = 11;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(77, 151);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(116, 26);
            this.cboProvincia.TabIndex = 7;
            // 
            // cboCalle
            // 
            this.cboCalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCalle.FormattingEnabled = true;
            this.cboCalle.Location = new System.Drawing.Point(277, 191);
            this.cboCalle.Name = "cboCalle";
            this.cboCalle.Size = new System.Drawing.Size(138, 26);
            this.cboCalle.TabIndex = 10;
            // 
            // txtbSaldo
            // 
            this.txtbSaldo.Location = new System.Drawing.Point(286, 234);
            this.txtbSaldo.Name = "txtbSaldo";
            this.txtbSaldo.Size = new System.Drawing.Size(136, 25);
            this.txtbSaldo.TabIndex = 12;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(236, 241);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 18);
            this.lblSaldo.TabIndex = 27;
            this.lblSaldo.Text = "Saldo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtbSaldo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.cboCalle);
            this.groupBox1.Controls.Add(this.lblCUIT);
            this.groupBox1.Controls.Add(this.cboProvincia);
            this.groupBox1.Controls.Add(this.lblDeudor);
            this.groupBox1.Controls.Add(this.cboCondicionIva);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.cboLocalidad);
            this.groupBox1.Controls.Add(this.lblAltura);
            this.groupBox1.Controls.Add(this.lblCondicionIva);
            this.groupBox1.Controls.Add(this.txtbApellido);
            this.groupBox1.Controls.Add(this.lblCalle);
            this.groupBox1.Controls.Add(this.txtbNombre);
            this.groupBox1.Controls.Add(this.lblProvincia);
            this.groupBox1.Controls.Add(this.txtbTelefono);
            this.groupBox1.Controls.Add(this.lblLocalidad);
            this.groupBox1.Controls.Add(this.txtbCuit);
            this.groupBox1.Controls.Add(this.clbDeudor);
            this.groupBox1.Controls.Add(this.txtbAltura);
            this.groupBox1.Controls.Add(this.txtbEmail);
            this.groupBox1.Controls.Add(this.cboBarrios);
            this.groupBox1.Controls.Add(this.lblBarrios);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(839, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 362);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 584);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMB Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblDeudor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.TextBox txtbCuit;
        private System.Windows.Forms.TextBox txtbAltura;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalirCli;
        private System.Windows.Forms.Button btnAceptarCli;
        private System.Windows.Forms.Button btnCancelarCli;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Button btnBorrarCli;
        private System.Windows.Forms.Button btnEditarCli;
        private System.Windows.Forms.Button btnAgregarCli;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label lblBarrios;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtbBuscar;
        private System.Windows.Forms.CheckedListBox clbDeudor;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblCondicionIva;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.ComboBox cboCondicionIva;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboCalle;
        private System.Windows.Forms.TextBox txtbSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Condicion_Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
    }
}

