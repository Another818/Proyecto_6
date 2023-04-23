namespace Proyecto_6
{
    partial class frmPlantas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantas));
            this.lblNombrePlanta = new System.Windows.Forms.Label();
            this.lblTipoPlanta = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtbStock = new System.Windows.Forms.TextBox();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.txtbNombrePlanta = new System.Windows.Forms.TextBox();
            this.cboTipoPlanta = new System.Windows.Forms.ComboBox();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.txtbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvPlantas = new System.Windows.Forms.DataGridView();
            this.Cod_Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_de_Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Tipo_Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipos_de_Plantas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombrePlanta
            // 
            this.lblNombrePlanta.AutoSize = true;
            this.lblNombrePlanta.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlanta.Location = new System.Drawing.Point(6, 20);
            this.lblNombrePlanta.Name = "lblNombrePlanta";
            this.lblNombrePlanta.Size = new System.Drawing.Size(134, 20);
            this.lblNombrePlanta.TabIndex = 11;
            this.lblNombrePlanta.Text = "Nombre de planta:";
            // 
            // lblTipoPlanta
            // 
            this.lblTipoPlanta.AutoSize = true;
            this.lblTipoPlanta.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlanta.Location = new System.Drawing.Point(9, 153);
            this.lblTipoPlanta.Name = "lblTipoPlanta";
            this.lblTipoPlanta.Size = new System.Drawing.Size(108, 20);
            this.lblTipoPlanta.TabIndex = 20;
            this.lblTipoPlanta.Text = "Tipo de planta:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(9, 112);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 20);
            this.lblStock.TabIndex = 19;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(6, 63);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(54, 20);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtbStock
            // 
            this.txtbStock.Location = new System.Drawing.Point(66, 112);
            this.txtbStock.Name = "txtbStock";
            this.txtbStock.Size = new System.Drawing.Size(163, 24);
            this.txtbStock.TabIndex = 17;
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.Location = new System.Drawing.Point(66, 63);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.Size = new System.Drawing.Size(163, 24);
            this.txtbPrecio.TabIndex = 16;
            // 
            // txtbNombrePlanta
            // 
            this.txtbNombrePlanta.Location = new System.Drawing.Point(146, 20);
            this.txtbNombrePlanta.Name = "txtbNombrePlanta";
            this.txtbNombrePlanta.Size = new System.Drawing.Size(163, 24);
            this.txtbNombrePlanta.TabIndex = 15;
            // 
            // cboTipoPlanta
            // 
            this.cboTipoPlanta.FormattingEnabled = true;
            this.cboTipoPlanta.Location = new System.Drawing.Point(123, 153);
            this.cboTipoPlanta.Name = "cboTipoPlanta";
            this.cboTipoPlanta.Size = new System.Drawing.Size(163, 25);
            this.cboTipoPlanta.TabIndex = 14;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.txtbBuscar);
            this.gbBusqueda.Controls.Add(this.lblBuscar);
            this.gbBusqueda.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(13, 290);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(557, 127);
            this.gbBusqueda.TabIndex = 13;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda:";
            // 
            // txtbBuscar
            // 
            this.txtbBuscar.Location = new System.Drawing.Point(79, 56);
            this.txtbBuscar.Name = "txtbBuscar";
            this.txtbBuscar.Size = new System.Drawing.Size(177, 26);
            this.txtbBuscar.TabIndex = 0;
            this.txtbBuscar.TextChanged += new System.EventHandler(this.txtbBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(8, 59);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(68, 23);
            this.lblBuscar.TabIndex = 10;
            this.lblBuscar.Text = "Buscar:";
            // 
            // dgvPlantas
            // 
            this.dgvPlantas.AllowUserToAddRows = false;
            this.dgvPlantas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvPlantas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Planta,
            this.Nombre_de_Planta,
            this.Precio,
            this.Stock,
            this.Cod_Tipo_Planta,
            this.Tipos_de_Plantas});
            this.dgvPlantas.GridColor = System.Drawing.Color.LightCoral;
            this.dgvPlantas.Location = new System.Drawing.Point(12, 13);
            this.dgvPlantas.MultiSelect = false;
            this.dgvPlantas.Name = "dgvPlantas";
            this.dgvPlantas.ReadOnly = true;
            this.dgvPlantas.RowHeadersVisible = false;
            this.dgvPlantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlantas.Size = new System.Drawing.Size(558, 242);
            this.dgvPlantas.TabIndex = 12;
            this.dgvPlantas.SelectionChanged += new System.EventHandler(this.dgvPlantas_SelectionChanged);
            // 
            // Cod_Planta
            // 
            this.Cod_Planta.DataPropertyName = "Cod_Planta";
            this.Cod_Planta.HeaderText = "Código";
            this.Cod_Planta.Name = "Cod_Planta";
            this.Cod_Planta.ReadOnly = true;
            // 
            // Nombre_de_Planta
            // 
            this.Nombre_de_Planta.DataPropertyName = "Nombre_de_Planta";
            this.Nombre_de_Planta.HeaderText = "Nombre Planta";
            this.Nombre_de_Planta.Name = "Nombre_de_Planta";
            this.Nombre_de_Planta.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Cod_Tipo_Planta
            // 
            this.Cod_Tipo_Planta.DataPropertyName = "Cod_Tipo_Planta";
            this.Cod_Tipo_Planta.HeaderText = "Cod_Tipo_Planta";
            this.Cod_Tipo_Planta.Name = "Cod_Tipo_Planta";
            this.Cod_Tipo_Planta.ReadOnly = true;
            this.Cod_Tipo_Planta.Visible = false;
            // 
            // Tipos_de_Plantas
            // 
            this.Tipos_de_Plantas.DataPropertyName = "Tipos_de_Plantas";
            this.Tipos_de_Plantas.HeaderText = "Tipo Planta";
            this.Tipos_de_Plantas.Name = "Tipos_de_Plantas";
            this.Tipos_de_Plantas.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(0, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 53);
            this.panel1.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(835, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 31);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(722, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 31);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(525, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(444, 14);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(254, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(173, 14);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 31);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(92, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 31);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(11, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombrePlanta);
            this.groupBox1.Controls.Add(this.cboTipoPlanta);
            this.groupBox1.Controls.Add(this.lblTipoPlanta);
            this.groupBox1.Controls.Add(this.txtbNombrePlanta);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.txtbPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.txtbStock);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(576, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 244);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // frmPlantas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.dgvPlantas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPlantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Plantas";
            this.Load += new System.EventHandler(this.frmPlantas_Load);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePlanta;
        private System.Windows.Forms.Label lblTipoPlanta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtbStock;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.TextBox txtbNombrePlanta;
        private System.Windows.Forms.ComboBox cboTipoPlanta;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.TextBox txtbBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvPlantas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_de_Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Tipo_Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipos_de_Plantas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}