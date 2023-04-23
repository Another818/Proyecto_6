namespace Proyecto_6
{
    partial class frmAFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAFactura));
            this.dgvFClientes = new System.Windows.Forms.DataGridView();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Condicion_Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFPlantas = new System.Windows.Forms.DataGridView();
            this.Cod_Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plantas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cboFormasPago = new System.Windows.Forms.ComboBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.txtbCondicionIva = new System.Windows.Forms.TextBox();
            this.lblCondicionIva = new System.Windows.Forms.Label();
            this.txtbCuit = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.gbPlantas = new System.Windows.Forms.GroupBox();
            this.txtbCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarPlanta = new System.Windows.Forms.Button();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtbBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPlantas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.gbPlantas.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.gbxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFClientes
            // 
            this.dgvFClientes.AllowUserToAddRows = false;
            this.dgvFClientes.AllowUserToDeleteRows = false;
            this.dgvFClientes.AllowUserToResizeColumns = false;
            this.dgvFClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvFClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Cliente,
            this.Apellido,
            this.Nombre,
            this.Cuit,
            this.Cod_Condicion_Iva,
            this.Descripcion,
            this.Saldo});
            this.dgvFClientes.GridColor = System.Drawing.Color.LightCoral;
            this.dgvFClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvFClientes.MultiSelect = false;
            this.dgvFClientes.Name = "dgvFClientes";
            this.dgvFClientes.ReadOnly = true;
            this.dgvFClientes.RowHeadersVisible = false;
            this.dgvFClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFClientes.Size = new System.Drawing.Size(587, 231);
            this.dgvFClientes.TabIndex = 0;
            this.dgvFClientes.SelectionChanged += new System.EventHandler(this.dgvAFacturas_SelectionChanged);
            // 
            // Cod_Cliente
            // 
            this.Cod_Cliente.DataPropertyName = "Cod_Cliente";
            this.Cod_Cliente.HeaderText = "Código";
            this.Cod_Cliente.Name = "Cod_Cliente";
            this.Cod_Cliente.ReadOnly = true;
            this.Cod_Cliente.Width = 55;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            this.Cuit.Width = 75;
            // 
            // Cod_Condicion_Iva
            // 
            this.Cod_Condicion_Iva.DataPropertyName = "Cod_Condicion_Iva";
            this.Cod_Condicion_Iva.HeaderText = "Código Iva";
            this.Cod_Condicion_Iva.Name = "Cod_Condicion_Iva";
            this.Cod_Condicion_Iva.ReadOnly = true;
            this.Cod_Condicion_Iva.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Condición Iva";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // dgvFPlantas
            // 
            this.dgvFPlantas.AllowUserToAddRows = false;
            this.dgvFPlantas.AllowUserToDeleteRows = false;
            this.dgvFPlantas.AllowUserToResizeColumns = false;
            this.dgvFPlantas.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvFPlantas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFPlantas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Planta,
            this.Plantas,
            this.Stock,
            this.Precio});
            this.dgvFPlantas.GridColor = System.Drawing.Color.Salmon;
            this.dgvFPlantas.Location = new System.Drawing.Point(12, 259);
            this.dgvFPlantas.MultiSelect = false;
            this.dgvFPlantas.Name = "dgvFPlantas";
            this.dgvFPlantas.ReadOnly = true;
            this.dgvFPlantas.RowHeadersVisible = false;
            this.dgvFPlantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFPlantas.Size = new System.Drawing.Size(509, 146);
            this.dgvFPlantas.TabIndex = 1;
            this.dgvFPlantas.SelectionChanged += new System.EventHandler(this.dgvAFacturas2_SelectionChanged);
            // 
            // Cod_Planta
            // 
            this.Cod_Planta.DataPropertyName = "Cod_Planta";
            this.Cod_Planta.HeaderText = "Código";
            this.Cod_Planta.Name = "Cod_Planta";
            this.Cod_Planta.ReadOnly = true;
            this.Cod_Planta.Width = 75;
            // 
            // Plantas
            // 
            this.Plantas.DataPropertyName = "Descripcion";
            this.Plantas.HeaderText = "Plantas";
            this.Plantas.Name = "Plantas";
            this.Plantas.ReadOnly = true;
            this.Plantas.Width = 130;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 120;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(0, 568);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 48);
            this.panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(539, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(458, 13);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvResumen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Codigo,
            this.Cantidad,
            this.NombrePlanta,
            this.PrecioPlanta,
            this.SubTotal});
            this.dgvResumen.GridColor = System.Drawing.Color.Salmon;
            this.dgvResumen.Location = new System.Drawing.Point(12, 411);
            this.dgvResumen.MultiSelect = false;
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.RowHeadersVisible = false;
            this.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumen.Size = new System.Drawing.Size(578, 151);
            this.dgvResumen.TabIndex = 4;
            this.dgvResumen.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvResumen_RowsAdded);
            this.dgvResumen.SelectionChanged += new System.EventHandler(this.dgvResumen_SelectionChanged);
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Width = 70;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_Planta";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // NombrePlanta
            // 
            this.NombrePlanta.DataPropertyName = "Descripcion";
            this.NombrePlanta.HeaderText = "Descripción";
            this.NombrePlanta.Name = "NombrePlanta";
            this.NombrePlanta.ReadOnly = true;
            // 
            // PrecioPlanta
            // 
            this.PrecioPlanta.DataPropertyName = "Precio";
            this.PrecioPlanta.HeaderText = "Precio";
            this.PrecioPlanta.Name = "PrecioPlanta";
            this.PrecioPlanta.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "Sub. Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cboFormasPago);
            this.gbCliente.Controls.Add(this.lblFormaPago);
            this.gbCliente.Controls.Add(this.txtbCondicionIva);
            this.gbCliente.Controls.Add(this.lblCondicionIva);
            this.gbCliente.Controls.Add(this.txtbCuit);
            this.gbCliente.Controls.Add(this.lblCUIT);
            this.gbCliente.Controls.Add(this.txtbNombre);
            this.gbCliente.Controls.Add(this.txtbApellido);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblApellido);
            this.gbCliente.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(605, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(281, 231);
            this.gbCliente.TabIndex = 5;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // cboFormasPago
            // 
            this.cboFormasPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormasPago.FormattingEnabled = true;
            this.cboFormasPago.Location = new System.Drawing.Point(106, 182);
            this.cboFormasPago.Name = "cboFormasPago";
            this.cboFormasPago.Size = new System.Drawing.Size(145, 26);
            this.cboFormasPago.TabIndex = 27;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(9, 185);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(99, 18);
            this.lblFormaPago.TabIndex = 26;
            this.lblFormaPago.Text = "Forma de Pago:";
            // 
            // txtbCondicionIva
            // 
            this.txtbCondicionIva.Enabled = false;
            this.txtbCondicionIva.Location = new System.Drawing.Point(106, 147);
            this.txtbCondicionIva.Name = "txtbCondicionIva";
            this.txtbCondicionIva.ReadOnly = true;
            this.txtbCondicionIva.Size = new System.Drawing.Size(145, 25);
            this.txtbCondicionIva.TabIndex = 25;
            // 
            // lblCondicionIva
            // 
            this.lblCondicionIva.AutoSize = true;
            this.lblCondicionIva.Location = new System.Drawing.Point(6, 150);
            this.lblCondicionIva.Name = "lblCondicionIva";
            this.lblCondicionIva.Size = new System.Drawing.Size(94, 18);
            this.lblCondicionIva.TabIndex = 24;
            this.lblCondicionIva.Text = "Condición Iva:";
            // 
            // txtbCuit
            // 
            this.txtbCuit.Enabled = false;
            this.txtbCuit.Location = new System.Drawing.Point(74, 110);
            this.txtbCuit.Name = "txtbCuit";
            this.txtbCuit.ReadOnly = true;
            this.txtbCuit.Size = new System.Drawing.Size(134, 25);
            this.txtbCuit.TabIndex = 15;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(6, 113);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(42, 18);
            this.lblCUIT.TabIndex = 14;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Enabled = false;
            this.txtbNombre.Location = new System.Drawing.Point(74, 72);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.ReadOnly = true;
            this.txtbNombre.Size = new System.Drawing.Size(126, 25);
            this.txtbNombre.TabIndex = 13;
            // 
            // txtbApellido
            // 
            this.txtbApellido.Enabled = false;
            this.txtbApellido.Location = new System.Drawing.Point(74, 27);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.ReadOnly = true;
            this.txtbApellido.Size = new System.Drawing.Size(126, 25);
            this.txtbApellido.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 18);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 30);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 18);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido:";
            // 
            // gbPlantas
            // 
            this.gbPlantas.Controls.Add(this.txtbCantidad);
            this.gbPlantas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlantas.Location = new System.Drawing.Point(605, 259);
            this.gbPlantas.Name = "gbPlantas";
            this.gbPlantas.Size = new System.Drawing.Size(281, 146);
            this.gbPlantas.TabIndex = 6;
            this.gbPlantas.TabStop = false;
            this.gbPlantas.Text = "Cant. Plantas";
            // 
            // txtbCantidad
            // 
            this.txtbCantidad.Location = new System.Drawing.Point(74, 58);
            this.txtbCantidad.Name = "txtbCantidad";
            this.txtbCantidad.Size = new System.Drawing.Size(115, 36);
            this.txtbCantidad.TabIndex = 3;
            this.txtbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregarPlanta
            // 
            this.btnAgregarPlanta.Image = global::Proyecto_6.Properties.Resources.plus_304947_960_7201;
            this.btnAgregarPlanta.Location = new System.Drawing.Point(527, 259);
            this.btnAgregarPlanta.Name = "btnAgregarPlanta";
            this.btnAgregarPlanta.Size = new System.Drawing.Size(63, 50);
            this.btnAgregarPlanta.TabIndex = 2;
            this.btnAgregarPlanta.UseVisualStyleBackColor = true;
            this.btnAgregarPlanta.Click += new System.EventHandler(this.btnAgregarPlanta_Click);
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.txtbTotal);
            this.gbTotal.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.Location = new System.Drawing.Point(605, 411);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(282, 151);
            this.gbTotal.TabIndex = 7;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // txtbTotal
            // 
            this.txtbTotal.BackColor = System.Drawing.Color.RosyBrown;
            this.txtbTotal.Enabled = false;
            this.txtbTotal.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTotal.Location = new System.Drawing.Point(74, 57);
            this.txtbTotal.Multiline = true;
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(136, 65);
            this.txtbTotal.TabIndex = 0;
            this.txtbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Proyecto_6.Properties.Resources.eliminar;
            this.btnBorrar.Location = new System.Drawing.Point(527, 331);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 50);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.txtbBusqueda);
            this.gbxBusqueda.Controls.Add(this.lblBusqueda);
            this.gbxBusqueda.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBusqueda.Location = new System.Drawing.Point(12, 411);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(578, 151);
            this.gbxBusqueda.TabIndex = 9;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(61, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(30, 73);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(78, 20);
            this.lblBusqueda.TabIndex = 0;
            this.lblBusqueda.Text = "Busqueda:";
            // 
            // txtbBusqueda
            // 
            this.txtbBusqueda.Location = new System.Drawing.Point(114, 73);
            this.txtbBusqueda.Name = "txtbBusqueda";
            this.txtbBusqueda.Size = new System.Drawing.Size(134, 28);
            this.txtbBusqueda.TabIndex = 1;
            this.txtbBusqueda.TextChanged += new System.EventHandler(this.txtbBuscarCli_TextChanged);
            // 
            // frmAFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 616);
            this.Controls.Add(this.gbxBusqueda);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.gbPlantas);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarPlanta);
            this.Controls.Add(this.dgvFPlantas);
            this.Controls.Add(this.dgvFClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Factura";
            this.Load += new System.EventHandler(this.frmAFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFPlantas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbPlantas.ResumeLayout(false);
            this.gbPlantas.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFClientes;
        private System.Windows.Forms.DataGridView dgvFPlantas;
        private System.Windows.Forms.Button btnAgregarPlanta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtbCuit;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtbCondicionIva;
        private System.Windows.Forms.Label lblCondicionIva;
        private System.Windows.Forms.GroupBox gbPlantas;
        private System.Windows.Forms.TextBox txtbCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plantas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Condicion_Iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cboFormasPago;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.TextBox txtbBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
    }
}