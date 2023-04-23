using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Proyecto_6
{
    public partial class frmClientes : Form
    {
        #region Variables del formulario

        //A para agregar, M para modificar, b para buscar, E espera.
        string myEstado = "";
        //creo el objeto de la clases barrios
        clsBarrios myBarrio = new clsBarrios();
        // Creo el objeto de la clases provincias
        clsProvincias myProvincia = new clsProvincias();
        // Creo el objeto de la clases localidades
        clsLocalidades myLocalidad = new clsLocalidades();
        // Creo el objeto de la clases facturas
        clsFacturas myFactura = new clsFacturas();
        // Creo el objeto de la clases calles
        clsCalles myCalle = new clsCalles();
        // Creo el objeto de la clase clientes
        clsClientes myCliente = new clsClientes();
        // Creo el objeto de la clase Condiciones Iva
        clsCondicionesIva myCondicionIva = new clsCondicionesIva();
        //Creo una variable para las consultas de SQL
        string sCadenaSQL = "";

        #endregion

        #region Constructor del formulario
        public frmClientes()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        #region EventoLoad
        private void frmClientes_Load(object sender, EventArgs e)
        {
            myEstado = "E";
            SetearControles();
            ControlarBotones();
            CargarGrilla("", "");
            clsDatos.CargarCombo(cboBarrios, "BARRIOS", "Barrio", "Cod_Barrio");
            clsDatos.CargarCombo(cboCalle, "CALLES", "Calle", "Cod_Calle");
            clsDatos.CargarCombo(cboCondicionIva, "CONDICIONES_IVA", "Descripcion", "Cod_Condicion_Iva");
            clsDatos.CargarCombo(cboLocalidad, "LOCALIDADES", "Localidad", "Cod_Localidad");
            clsDatos.CargarCombo(cboProvincia, "PROVINCIAS", "Provincia", "Cod_Provincia");
        }
        #endregion

        #region Evento Botones

        #region Evento click de botón agregar
        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            myEstado = "A";
            SetearControles();
            ControlarBotones();
            Limpiar_Controles();
        }
        #endregion

        #region Evento click de boton editar
        private void btnEditarCli_Click(object sender, EventArgs e)
        {
            myEstado = "M";
            SetearControles();
            ControlarBotones();
        }
        #endregion

        #region Evento click de boton buscar
        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            myEstado = "B";
            SetearControles();
            ControlarBotones();
            txtbBuscar.Focus();
        }
        #endregion

        #region Evento click de boton borrar
        private void btnBorrarCli_Click(object sender, EventArgs e)
        {
            // Paso los datos del pais seleccionada a la clase
            Grilla_A_Objeto();
            // Pido confirmacion para proceder a la eliminacion
            DialogResult myRespuesta = MessageBox.Show("Desea eliminar la persona " + myCliente.pSApellido + ", " + myCliente.pSNombre,
                "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Si la respuesta es si,
            if (myRespuesta == DialogResult.Yes)
            {

                // Almaceno la consulta SQL
                sCadenaSQL = "delete CLIENTES where Cod_Cliente = " + myCliente.pICod_Cliente; 
                
                // Ejecuto la consulta
                clsDatos.GetSql(sCadenaSQL);



                myEstado = "E";
                SetearControles();
                ControlarBotones();
                CargarGrilla("", "");
            }

            // Todo dato que escribe el usuario en los controles se guardan en los objetos
            myCliente.pSNombre = txtbNombre.Text;
            myCliente.pSApellido = txtbApellido.Text;
        }
        #endregion

        #region Evento click de boton aceptar
        private void btnAceptarCli_Click(object sender, EventArgs e)
        {
            switch (myEstado)
            {
                // Agregó un nuevo cliente
                case "A":
                    // Llamo al metodo que pasa los datos de los controles a la clase
                    Controles_A_Objeto();
                    // Armo la cadena con el insert
                    sCadenaSQL = "insert into CLIENTES(Apellido, Nombre, Cuit, Saldo, Deudor, Telefono, Altura, Email, Cod_Barrio, Cod_Calle, Cod_Localidad, Cod_Condicion_Iva, Cod_Provincia) values ('" + myCliente.pSApellido + "','"
                        + myCliente.pSNombre + "','"
                        + myCliente.pSCuit + "'," + myCliente.pDSaldo + "," + myCliente.pIDeudor + ",'" + myCliente.pSTelefono + "','"
                        + myCliente.pSAltura + "','" + myCliente.pSEmail + "'," + myCliente.pMyBarrio.pICod_Barrio + ", " + myCliente.pMyCalle.pICod_Calle + ", " + myCliente.pMyLocalidad.pICod_Localidad 
                        + ", " + myCliente.pMyCondicionesIva.pICod_Condicion_Iva + ", " + myCliente.pMyProvincia.pICod_Provincia + ")";
                    // Ejecuto la consulta
                    clsDatos.GetSql(sCadenaSQL);
                    // llamo al evento click del boton cancelar para recargar el formulario
                    btnCancelarCli.PerformClick();
                    break;

                case "B":
                    CargarGrilla(Convert.ToString(myCliente.pICod_Cliente), "Cod_Cliente");
                    myEstado = "E";
                    SetearControles();
                    ControlarBotones();
                    break;

                case "M":
                    // Como es una modificacion, tengo que hacer un update a la tabla
                    // Paso los datos de los controles  a los objetos
                    Controles_A_Objeto();
                    // Creo la consulta SQL para editar los datos
                    sCadenaSQL = "update CLIENTES set Apellido = '" + myCliente.pSApellido 
                       + "', Nombre = '" + myCliente.pSNombre
                       + "', Cuit = '" + myCliente.pSCuit
                       + "', Deudor = " + myCliente.pIDeudor
                       + ", Saldo = " + myCliente.pDSaldo
                       + ", Telefono = '" + myCliente.pSTelefono
                       + "', Altura = '" + myCliente.pSAltura
                       + "', Email = '" + myCliente.pSEmail
                       + "', Cod_Barrio = " + myCliente.pMyBarrio.pICod_Barrio
                       + ", Cod_Calle = " + myCliente.pMyCalle.pICod_Calle
                       + ", Cod_Localidad = " + myCliente.pMyLocalidad.pICod_Localidad
                       + ", Cod_Condicion_Iva = " + myCliente.pMyCondicionesIva.pICod_Condicion_Iva
                       + ", Cod_Provincia = " + myCliente.pMyProvincia.pICod_Provincia
                       + " where Cod_Cliente = " + myCliente.pICod_Cliente;

                    //Ejecuta la consulta
                    clsDatos.GetSql(sCadenaSQL);
                    // Reinicio el  formulario
                    myEstado = "E";
                    SetearControles();
                    ControlarBotones();
                    CargarGrilla("", "");



                    break;

            }
        }
        #endregion

        #region Evento click de boton cancelar
        private void btnCancelarCli_Click(object sender, EventArgs e)
        {
            myEstado = "E";
            SetearControles();
            ControlarBotones();
            CargarGrilla("", "");
            Grilla_A_Objeto();
            Objeto_A_Controles();
        }
        #endregion

        #region Evento click de boton salir
        private void btnSalirCli_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #endregion

        #region Evento de los controles

        private void txtbBuscarCli_TextChanged(object sender, EventArgs e)
        {
            //Llamo al metodo y carga la grilla y le paso los parametros de busqueda
            CargarGrilla(txtbBuscar.Text, "Apellido");
            
        }


        #endregion

        #region Evento selection changed
        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            Grilla_A_Objeto();
            // Paso los datos del objeto a los controles
            Objeto_A_Controles();
        }
        #endregion

        #endregion

        #region Métodos
        #region Métodos que setea los controles del formulario
        private void SetearControles()
        {

            switch (myEstado)
            {
                case "A":
                    txtbNombre.Enabled = true;
                    txtbApellido.Enabled = true;
                    txtbCuit.Enabled = true;
                    txtbTelefono.Enabled = true;
                    txtbEmail.Enabled = true;
                    txtbAltura.Enabled = true;
                    txtbSaldo.Enabled = true;
                    clbDeudor.Enabled = true;
                    cboBarrios.Enabled = true;
                    cboCalle.Enabled = true;
                    cboLocalidad.Enabled = true;
                    cboCondicionIva.Enabled = true;
                    cboProvincia.Enabled = true;
                    dgvClientes.Height = 470;
                    dgvClientes.Enabled = false;
                    gbBusqueda.Visible = false;
                    break;

                case "M":
                    txtbNombre.Enabled = true;
                    txtbApellido.Enabled = true;
                    txtbCuit.Enabled = true;
                    txtbTelefono.Enabled = true;
                    txtbEmail.Enabled = true;
                    txtbSaldo.Enabled = true;
                    txtbAltura.Enabled = true;
                    clbDeudor.Enabled = true;
                    cboBarrios.Enabled = true;
                    cboCalle.Enabled = true;
                    cboLocalidad.Enabled = true;
                    cboCondicionIva.Enabled = true;
                    cboProvincia.Enabled = true;
                    dgvClientes.Height = 470;
                    dgvClientes.Enabled = false;
                    gbBusqueda.Visible = false;
                    break;

                case "B":
                    txtbNombre.Enabled = false;
                    txtbApellido.Enabled = false;
                    txtbCuit.Enabled = false;
                    txtbSaldo.Enabled = false;
                    txtbEmail.Enabled = false;
                    txtbAltura.Enabled = false;
                    txtbTelefono.Enabled = false;
                    clbDeudor.Enabled = false;
                    cboBarrios.Enabled = false;
                    cboCalle.Enabled = false;
                    cboLocalidad.Enabled = false;
                    cboCondicionIva.Enabled = false;
                    cboLocalidad.Enabled = false;
                    dgvClientes.Height = 353;
                    dgvClientes.Enabled = true;
                    gbBusqueda.Visible = true;
                    break;

                case "E":

                    txtbNombre.Enabled = false;
                    txtbApellido.Enabled = false;
                    txtbCuit.Enabled = false;
                    txtbEmail.Enabled = false;
                    txtbAltura.Enabled = false;
                    txtbSaldo.Enabled = false;
                    txtbTelefono.Enabled = false;
                    clbDeudor.Enabled = false;
                    cboBarrios.Enabled = false;
                    cboCalle.Enabled = false;
                    cboLocalidad.Enabled = false;
                    cboCondicionIva.Enabled = false;
                    cboProvincia.Enabled = false;
                    dgvClientes.Height = 470;
                    dgvClientes.Enabled = true;
                    gbBusqueda.Visible = false;

                    break;

            }
        }


        #endregion

        #region Método que carga la grilla de los clientes

        private void CargarGrilla(string Buscar, string Campo)
        {
            //Variable que guarda la cadena para SQL
            string sMyCadenaSQL = "";
            //Si no estoy buscando
            if (Buscar == "")
            {
                sMyCadenaSQL = "select * from Vista_Cliente";
            }
            //Si estoy buscando
            else
            {
                sMyCadenaSQL = "select * from Vista_Cliente where " + Campo + " like '" + Buscar + "%' order by " + Campo;
            }

            //Llamamos al metodo para cargar los datos en el origen de la grilla 
            // pasando los parametros de la consuelta. G.
            DataTable mDtTable = new DataTable();
            mDtTable = clsDatos.GetSql(sMyCadenaSQL);
            // Evito que el dgv genere columnas automaticas
            dgvClientes.AutoGenerateColumns = false;
            //Asigno los datos que me devuelve el método GetSql a la grilla del formulario.
            dgvClientes.DataSource = mDtTable;
            //Cuento la cantidad de filas de la grilla
            int Filas = dgvClientes.Rows.Count;
        }

        #endregion

        #region Método que controla el comportamiento de los botones
        private void ControlarBotones()
        {

            switch (myEstado)
            {
                // Si esta haciendo un alta,una modificacion o buscando
                case "A":
                case "B":
                case "M":
                    //Oculto los botones innecesarios
                    btnAgregarCli.Visible = false;
                    btnEditarCli.Visible = false;
                    btnBuscarCli.Visible = false;
                    btnBorrarCli.Visible = false;
                    btnSalirCli.Visible = false;
                    btnImprimir.Visible = false;
                    // Muestro los botones
                    btnAceptarCli.Visible = true;
                    btnCancelarCli.Visible = true;


                    break;
                //Si el formulario esta en espera 
                case "E":
                    // Muestro los botones  innecesarios 
                    btnAgregarCli.Visible = true;
                    btnEditarCli.Visible = true;
                    btnBuscarCli.Visible = true;
                    btnBorrarCli.Visible = true;
                    btnSalirCli.Visible = true;
                    btnImprimir.Visible = true;
                    // Oculto los botones
                    btnAceptarCli.Visible = false;
                    btnCancelarCli.Visible = false;
                    break;

            }

        }

        #endregion

        #region Metodo que pasa los datos de la grilla al objeto

        private void Grilla_A_Objeto()
        {
            // Paso los datos de la fila actual al objeto
            myCliente.pICod_Cliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Cod_Cliente"].Value);
            myCliente.pSNombre = Convert.ToString(dgvClientes.CurrentRow.Cells["Nombre"].Value);
            myCliente.pSApellido = Convert.ToString(dgvClientes.CurrentRow.Cells["Apellido"].Value);
            myCliente.pSTelefono = Convert.ToString(dgvClientes.CurrentRow.Cells["Telefono"].Value);
            myCliente.pSCuit = Convert.ToString(dgvClientes.CurrentRow.Cells["Cuit"].Value);
            myCliente.pDSaldo = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Saldo"].Value);
            myCliente.pIDeudor = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Deudor"].Value);
            myCliente.pSEmail = Convert.ToString(dgvClientes.CurrentRow.Cells["Email"].Value);
            myCliente.pSAltura = Convert.ToString(dgvClientes.CurrentRow.Cells["Altura"].Value);
            // Paso los datos de la fila actual al objeto myBarrio
            myBarrio.pICod_Barrio = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Cod_Barrio"].Value);
            myBarrio.pSBarrio = Convert.ToString(dgvClientes.CurrentRow.Cells["Barrio"].Value);
            myCliente.pMyBarrio = myBarrio;
            //
            myCalle.pICod_Calle = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Cod_Calle"].Value);
            myCalle.pSCalle = Convert.ToString(dgvClientes.CurrentRow.Cells["Calle"].Value);
            myCliente.pMyCalle = myCalle;
            //
            myLocalidad.pICod_Localidad = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Cod_Localidad"].Value);
            myLocalidad.pSLocalidad = Convert.ToString(dgvClientes.CurrentRow.Cells["Localidad"].Value);
            myCliente.pMyLocalidad = myLocalidad;
            //
            myCondicionIva.pICod_Condicion_Iva = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Cod_Condicion_Iva"].Value);
            myCondicionIva.pSDescripcion = Convert.ToString(dgvClientes.CurrentRow.Cells["Descripcion"].Value);
            myCliente.pMyCondicionesIva = myCondicionIva;
            //
            myProvincia.pICod_Provincia = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Cod_Provincia"].Value);
            myProvincia.pSProvincia = Convert.ToString(dgvClientes.CurrentRow.Cells["Provincia"].Value);
            myCliente.pMyProvincia = myProvincia;

        }

        #endregion

        #region Metodo que pasa los datos del objeto a los controles

        private void Objeto_A_Controles()
        {
            // Paso el nombre de la provincia guardado en el objeto al control
            txtbNombre.Text = myCliente.pSNombre;
            txtbApellido.Text = myCliente.pSApellido;
            //txtbDNIPer.Text = myPersonas.pDNI;
            txtbCuit.Text = myCliente.pSCuit;
            txtbEmail.Text = myCliente.pSEmail;
            txtbTelefono.Text = myCliente.pSTelefono;
            txtbAltura.Text = myCliente.pSAltura;
            txtbSaldo.Text = Convert.ToString(myCliente.pDSaldo);
            // Selecciono el nombre del barrio en el combo
            cboBarrios.SelectedValue = myCliente.pMyBarrio.pICod_Barrio;
            cboCalle.SelectedValue = myCliente.pMyCalle.pICod_Calle;
            cboLocalidad.SelectedValue = myCliente.pMyLocalidad.pICod_Localidad;
            cboCondicionIva.SelectedValue = myCliente.pMyCondicionesIva.pICod_Condicion_Iva;
            cboProvincia.SelectedValue = myCliente.pMyProvincia.pICod_Provincia;
            if (myCliente.pIDeudor == 1)
            {

                clbDeudor.SetItemChecked(0, true);
                clbDeudor.SetItemChecked(1, false);

            }
            else if (myCliente.pIDeudor == 0)
            {
                clbDeudor.SetItemChecked(1, true);
                clbDeudor.SetItemChecked(0, false);

            }


        }

        #endregion

        #region Metodo que limpia los controles del formulario

        private void Limpiar_Controles()
        {
            // borrolo que este escrito en el textbox
            txtbNombre.Text = "";
            txtbApellido.Text = "";
            txtbCuit.Text = "";
            txtbEmail.Text = "";
            txtbTelefono.Text = "";
            txtbAltura.Text = "";
            txtbSaldo.Text = "";
            cboBarrios.SelectedIndex = -1;
            cboCalle.SelectedIndex = -1;
            cboLocalidad.SelectedIndex = -1;
            cboCondicionIva.SelectedIndex = -1;
            cboProvincia.SelectedIndex = -1;
        }

        #endregion

        #region Método que controla los controles
        private void Controles_A_Objeto()
        {
            // Lleno el objeto myclientes
            myBarrio.pICod_Barrio = Convert.ToInt32(cboBarrios.SelectedValue);
            myBarrio.pSBarrio = cboBarrios.Text;
            //
            myCalle.pICod_Calle = Convert.ToInt32(cboCalle.SelectedValue);
            myCalle.pSCalle = cboCalle.Text;
            //
            myLocalidad.pICod_Localidad = Convert.ToInt32(cboLocalidad.SelectedValue);
            myLocalidad.pSLocalidad = cboLocalidad.Text;
            //
            myCondicionIva.pICod_Condicion_Iva = Convert.ToInt32(cboCondicionIva.SelectedValue);
            myCondicionIva.pSDescripcion = cboCondicionIva.Text;
            //
            myProvincia.pICod_Provincia = Convert.ToInt32(cboProvincia.SelectedValue);
            myProvincia.pSProvincia = cboProvincia.Text;


            // Pregunto a 1 variable que esta haciendo el usuario 
            switch (myEstado)
            {
                //si esta haciendo un alta
                case "A":
                    // No necesito el Id y lo pongo en 0 
                    myCliente.pICod_Cliente = 0;
                    break;
                // Si esta modificando 
                case "M":
                    // Tomo el Id provincia de la grilla 
                    myCliente.pICod_Cliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Cod_Cliente"].Value);

                    break;
            }
            // tomo el nombre de la provincia de lo que escribió el usuario en el texbox
            myCliente.pSNombre = txtbNombre.Text;
            myCliente.pSApellido = txtbApellido.Text;
            myCliente.pSEmail = txtbEmail.Text;
            myCliente.pSAltura = txtbAltura.Text;
            myCliente.pSTelefono = txtbTelefono.Text;
            myCliente.pSCuit = txtbCuit.Text;
            myCliente.pDSaldo = Convert.ToInt32(txtbSaldo.Text);
            // Le asigno el país a la provincia
            myCliente.pMyBarrio = myBarrio;
            myCliente.pMyCalle = myCalle;
            myCliente.pMyLocalidad = myLocalidad;
            myCliente.pMyCondicionesIva = myCondicionIva;
            myCliente.pMyProvincia = myProvincia;

        }






        #endregion

        private void clbDeudor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbDeudor.GetItemChecked(0) == true) {
                myCliente.pIDeudor = 1;
            }
            if (clbDeudor.GetItemChecked(1) == true)
            {
                myCliente.pIDeudor = 0;
            }
        } 



        #endregion

        #region botón imprimir

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc };
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate(object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach (DataGridViewColumn col in dgvClientes.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Century Schoolbook", 14, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width + 60;

                    if (col.Index < dgvClientes.ColumnCount - 1)
                    {
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvClientes.RowCount) * DGV_ALTO);
                    }
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 45;

                foreach (DataGridViewRow row in dgvClientes.Rows) 
                {
                    if (row.Index == dgvClientes.RowCount) break;
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Century Schoolbook", 12), Brushes.Black, left, top);
                        left += cell.OwningColumn.Width + 60;
                    }
                    top += DGV_ALTO;
                    ep.Graphics.DrawLine(Pens.Gray, ep.MarginBounds.Left, top, ep.MarginBounds.Right, top);
                }
            };
            ppd.ShowDialog();
        }

        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
        #endregion
}
        