namespace Proyecto_6
{
    partial class frmUsuario
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
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Ingresadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulti_Ingresada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbxUsuario = new System.Windows.Forms.GroupBox();
            this.txtbContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtbFecha = new System.Windows.Forms.TextBox();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cant_Ingresadas,
            this.contrasenia,
            this.Nombre,
            this.Creacion,
            this.Ulti_Ingresada});
            this.dgvUsuario.GridColor = System.Drawing.Color.Salmon;
            this.dgvUsuario.Location = new System.Drawing.Point(12, 12);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(429, 182);
            this.dgvUsuario.TabIndex = 0;
            this.dgvUsuario.TabStop = false;
            this.dgvUsuario.SelectionChanged += new System.EventHandler(this.dgvUsuario_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 60;
            // 
            // Cant_Ingresadas
            // 
            this.Cant_Ingresadas.DataPropertyName = "Cant_Ingresadas";
            this.Cant_Ingresadas.HeaderText = "Cant_Ingresadas";
            this.Cant_Ingresadas.Name = "Cant_Ingresadas";
            this.Cant_Ingresadas.ReadOnly = true;
            this.Cant_Ingresadas.Visible = false;
            // 
            // contrasenia
            // 
            this.contrasenia.DataPropertyName = "Contrasenia";
            this.contrasenia.HeaderText = "Contraseña";
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.ReadOnly = true;
            this.contrasenia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.contrasenia.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Creacion
            // 
            this.Creacion.DataPropertyName = "Creacion";
            this.Creacion.HeaderText = "Fecha Creación";
            this.Creacion.Name = "Creacion";
            this.Creacion.ReadOnly = true;
            this.Creacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ulti_Ingresada
            // 
            this.Ulti_Ingresada.DataPropertyName = "Ulti_Ingresada";
            this.Ulti_Ingresada.HeaderText = "Ultima vez ingresada";
            this.Ulti_Ingresada.Name = "Ulti_Ingresada";
            this.Ulti_Ingresada.ReadOnly = true;
            this.Ulti_Ingresada.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 46);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(291, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelarCli_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(230, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(55, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptarCli_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(387, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(54, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalirCli_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(93, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarCli_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(12, 12);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresarCli_Click);
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.Controls.Add(this.txtbContra);
            this.gbxUsuario.Controls.Add(this.lblContra);
            this.gbxUsuario.Controls.Add(this.txtbFecha);
            this.gbxUsuario.Controls.Add(this.txtbUser);
            this.gbxUsuario.Controls.Add(this.lblFecha);
            this.gbxUsuario.Controls.Add(this.lblName);
            this.gbxUsuario.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUsuario.Location = new System.Drawing.Point(12, 200);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Size = new System.Drawing.Size(369, 105);
            this.gbxUsuario.TabIndex = 2;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Usuario";
            // 
            // txtbContra
            // 
            this.txtbContra.Location = new System.Drawing.Point(248, 71);
            this.txtbContra.Name = "txtbContra";
            this.txtbContra.Size = new System.Drawing.Size(125, 22);
            this.txtbContra.TabIndex = 2;
            this.txtbContra.UseSystemPasswordChar = true;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(199, 68);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(74, 15);
            this.lblContra.TabIndex = 4;
            this.lblContra.Text = "Contraseña:";
            // 
            // txtbFecha
            // 
            this.txtbFecha.Location = new System.Drawing.Point(248, 43);
            this.txtbFecha.Multiline = true;
            this.txtbFecha.Name = "txtbFecha";
            this.txtbFecha.Size = new System.Drawing.Size(100, 22);
            this.txtbFecha.TabIndex = 3;
            this.txtbFecha.TabStop = false;
            // 
            // txtbUser
            // 
            this.txtbUser.Location = new System.Drawing.Point(81, 43);
            this.txtbUser.Multiline = true;
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(100, 22);
            this.txtbUser.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(199, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 15);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "UserName:";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 359);
            this.Controls.Add(this.gbxUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUsuario);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox gbxUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbFecha;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtbContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Ingresadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulti_Ingresada;
    }
}