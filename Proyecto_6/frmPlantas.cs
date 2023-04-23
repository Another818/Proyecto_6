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
    public partial class frmPlantas : Form
    {

        #region Variables del formulario

        //A para uno nuevo, M para modificar, b para buscar, E espera.
        string myEstado = "";
        //
        clsPlantas myPlanta = new clsPlantas();
        //
        clsTiposPlantas myTipoPlanta = new clsTiposPlantas();
        //Creo una variable para las consultas de SQL
        string sCadenaSQL = "";

        #endregion

        #region Constructor del formulario
        public frmPlantas()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        #region EventoLoad

        private void frmPlantas_Load(object sender, EventArgs e)
        {
            myEstado = "E";
            SetearControles();
            ControlarBotones();
            CargarGrilla("", "");
            clsDatos.CargarCombo(cboTipoPlanta, "TIPOS_PLANTAS", "Nombre", "Cod_Tipo_Planta");
        }

        #endregion

        #region Evento Botones

        #region Evento click de botón agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            myEstado = "A";
            SetearControles();
            ControlarBotones();
            Limpiar_Controles();
        }
        #endregion

        #region Evento click de boton editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            myEstado = "M";
            SetearControles();
            ControlarBotones();
        }
        #endregion

        #region Evento click de boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            myEstado = "B";
            SetearControles();
            ControlarBotones();
            txtbBuscar.Focus();
        }

        #endregion

        #region Evento click de boton borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Paso los datos del pais seleccionada a la clase
            Grilla_A_Objeto();
            // Pido confirmacion para proceder a la eliminacion
            DialogResult myRespuesta = MessageBox.Show("Desea eliminar la Planta " + myPlanta.pSDescripcion,
                "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Si la respuesta es si,
            if (myRespuesta == DialogResult.Yes)
            {

                // Almaceno la consulta SQL
                sCadenaSQL = "delete PLANTAS where Cod_Planta = " + myPlanta.pICod_Planta;
                // Ejecuto la consulta
                clsDatos.GetSql(sCadenaSQL);



                myEstado = "E";
                SetearControles();
                ControlarBotones();
                CargarGrilla("", "");
            }

            // todo nombre del pais de lo que escribio el usuario en el textbox
            myPlanta.pSDescripcion = txtbNombrePlanta.Text;
            myPlanta.pDPrecio = Convert.ToInt32(txtbPrecio.Text);
            myPlanta.pIStock = Convert.ToInt32(txtbStock.Text);
        }
        #endregion

        #region Evento click de boton aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (myEstado)
            {
                // Si estoy creando un nuevo pais 
                case "A":
                    // Llamo al metodo que pasa los datos de los controles a la clase
                    Controles_A_Objeto();
                    // Armo la cadena con el insert
                    sCadenaSQL = "insert into PLANTAS(Descripcion, Precio, Stock, Cod_Tipo_Planta) values ('" + myPlanta.pSDescripcion + "',"
                        + myPlanta.pDPrecio + ","
                        + myPlanta.pIStock + "," + myPlanta.pMyTipoPlanta.pICod_Tipo_Planta + ")";
                    // Ejecuto la consulta
                    clsDatos.GetSql(sCadenaSQL);
                    // llamo al evento click del boton cancelar para recargar el formulario
                    btnCancelar.PerformClick();
                    break;

                case "B":
                    CargarGrilla(Convert.ToString(myPlanta.pICod_Planta), "Cod_Planta");
                    myEstado = "E";
                    SetearControles();
                    ControlarBotones();
                    break;

                case "M":
                    // Como es una modificacion, tengo que hacer un update a la tabla
                    // Paso los datos de los controles  a los objetos
                    Controles_A_Objeto();
                    // Creo la consulta SQL para editar los datos
                    sCadenaSQL = "update PLANTAS set Descripcion = '" + myPlanta.pSDescripcion
                       + "', Precio = '" + myPlanta.pDPrecio
                       + "', Stock = '" + myPlanta.pIStock
                       + "', Cod_Tipo_Planta = " + myPlanta.pMyTipoPlanta.pICod_Tipo_Planta
                       + " where Cod_Planta = " + myPlanta.pICod_Planta;

                    //Ejecuta la consulta
                    clsDatos.GetSql(sCadenaSQL);
                    // Reinicio elo formulario
                    myEstado = "E";
                    SetearControles();
                    ControlarBotones();
                    CargarGrilla("", "");



                    break;

            }
        }
        #endregion

        #region Evento click de boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            myEstado = "E";
            SetearControles();
            ControlarBotones();
            CargarGrilla("", "");
            Grilla_A_Objeto();
            Objeto_A_Controles();
        }
        #endregion

        #region Botón imprimir
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

                foreach (DataGridViewColumn col in dgvPlantas.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Century Schoolbook", 14, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width + 60;

                    if (col.Index < dgvPlantas.ColumnCount - 1)
                    {
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvPlantas.RowCount) * DGV_ALTO);
                    }
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 45;

                foreach (DataGridViewRow row in dgvPlantas.Rows)
                {
                    if (row.Index == dgvPlantas.RowCount) break;
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
        #endregion

        #region Evento click de boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #endregion

        #region Evento de los controles

        private void txtbBuscar_TextChanged(object sender, EventArgs e)
        {
            //Llamo al metodo y carga la grilla y le paso los parametros de busqueda
            CargarGrilla(txtbBuscar.Text, "Nombre_de_Planta");
        }

        #endregion

        #region Evento selection changed

        private void dgvPlantas_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            Grilla_A_Objeto();
            // Paso los datos del objeto a los controles
            Objeto_A_Controles();
        }

        #endregion

        #endregion

        #region Metodos

        #region Métodos que setea los controles del formulario
        private void SetearControles()
        {
            switch (myEstado)
            {
                case "A":
                    txtbNombrePlanta.Enabled = true;
                    txtbStock.Enabled = true;
                    txtbPrecio.Enabled = true;
                    cboTipoPlanta.Enabled = true;
                    dgvPlantas.Height = 400;
                    dgvPlantas.Enabled = false;
                    gbBusqueda.Visible = false;
                    break;

                case "M":
                    txtbNombrePlanta.Enabled = true;
                    txtbStock.Enabled = true;
                    txtbPrecio.Enabled = true;
                    cboTipoPlanta.Enabled = true;
                    dgvPlantas.Height = 400;
                    dgvPlantas.Enabled = false;
                    gbBusqueda.Visible = false;
                    break;

                case "B":
                    txtbNombrePlanta.Enabled = false;
                    txtbStock.Enabled = false;
                    txtbPrecio.Enabled = false;
                    cboTipoPlanta.Enabled = false;
                    dgvPlantas.Height = 250;
                    dgvPlantas.Enabled = true;
                    gbBusqueda.Visible = true;
                    break;

                case "E":

                    txtbNombrePlanta.Enabled = false;
                    txtbStock.Enabled = false;
                    txtbPrecio.Enabled = false;
                    cboTipoPlanta.Enabled = false;
                    dgvPlantas.Height = 400;
                    dgvPlantas.Enabled = true;
                    gbBusqueda.Visible = false;

                    break;

            }
        }
        #endregion

        #region Método que carga la grilla de las plantas

        private void CargarGrilla(string Buscar, string Campo)
        {
            //Variable que guarda la cadena para SQL
            string sMyCadenaSQL = "";
            //Si no estoy buscando
            if (Buscar == "")
            {
                sMyCadenaSQL = "select * from Vista_Plantas";
            }
            //Si estoy buscando
            else
            {
                sMyCadenaSQL = "select * from Vista_Plantas where " + Campo + " like '" + Buscar + "%' order by " + Campo;
            }

            //Llamamos al metodo para cargar los datos en el origen de la grilla 
            // pasando los parametros de la consuelta. G.
            DataTable mDtTable = new DataTable();
            mDtTable = clsDatos.GetSql(sMyCadenaSQL);
            // Evito que el dgv genere columnas automaticas
            dgvPlantas.AutoGenerateColumns = false;
            //Asigno los datos que me devuelve el método GetSql a la grilla de3l formulario. G.
            dgvPlantas.DataSource = mDtTable;
            //Cuento la cantidad de filas de la grilla
            int Filas = dgvPlantas.Rows.Count;
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
                    btnAgregar.Visible = false;
                    btnEditar.Visible = false;
                    btnBuscar.Visible = false;
                    btnBorrar.Visible = false;
                    btnSalir.Visible = false;
                    btnImprimir.Visible = false;
                    // Muestro los botones
                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;


                    break;
                //Si el formulario esta en espera 
                case "E":
                    // Muestro los botones  innecesarios 
                    btnAgregar.Visible = true;
                    btnEditar.Visible = true;
                    btnBuscar.Visible = true;
                    btnBorrar.Visible = true;
                    btnSalir.Visible = true;
                    btnImprimir.Visible = true;
                    // Oculto los botones
                    btnAceptar.Visible = false;
                    btnCancelar.Visible = false;
                    break;

            }

        }

        #endregion

        #region Metodo que pasa los datos de la grilla al objeto

        private void Grilla_A_Objeto()
        {
            // Paso los datos de la fila actual al objeto
            myPlanta.pICod_Planta = Convert.ToInt32(dgvPlantas.CurrentRow.Cells["Cod_Planta"].Value);
            myPlanta.pSDescripcion = Convert.ToString(dgvPlantas.CurrentRow.Cells["Nombre_de_Planta"].Value);
            myPlanta.pIStock = Convert.ToInt32(dgvPlantas.CurrentRow.Cells["Stock"].Value);
            myPlanta.pDPrecio = Convert.ToInt32(dgvPlantas.CurrentRow.Cells["Precio"].Value);
            // Paso los datos de la fila actual al objeto myBarrio
            myTipoPlanta.pICod_Tipo_Planta = Convert.ToInt32(dgvPlantas.CurrentRow.Cells["Cod_Tipo_Planta"].Value);
            myTipoPlanta.pSNombre = Convert.ToString(dgvPlantas.CurrentRow.Cells["Tipos_de_Plantas"].Value);
            myPlanta.pMyTipoPlanta = myTipoPlanta;
        }

        #endregion

        #region Metodo que pasa los datos del objeto a los controles

        private void Objeto_A_Controles()
        {
            // Paso el nombre de la provincia guardado en el objeto al control
            txtbNombrePlanta.Text = myPlanta.pSDescripcion;
            txtbPrecio.Text = Convert.ToString(myPlanta.pDPrecio);
            txtbStock.Text = Convert.ToString(myPlanta.pIStock);
            // Selecciono el nombre del barrio en el combo
            cboTipoPlanta.SelectedValue = myPlanta.pMyTipoPlanta.pICod_Tipo_Planta;
        }

        #endregion

        #region Metodo que limpia los controles del formulario

        private void Limpiar_Controles()
        {
            // borrolo que este escrito en el textbox
            txtbNombrePlanta.Text = "";
            txtbStock.Text = "";
            txtbPrecio.Text = "";
            cboTipoPlanta.SelectedIndex = -1;
        }

        #endregion

        #region Método que controla los controles
        private void Controles_A_Objeto()
        {
            // Lleno el objeto mypais
            myTipoPlanta.pICod_Tipo_Planta = Convert.ToInt32(cboTipoPlanta.SelectedValue);
            myTipoPlanta.pSNombre = cboTipoPlanta.Text;


            // Pregunto a 1 variable que esta haciendo el usuario 
            switch (myEstado)
            {
                //si esta haciendo un alta
                case "A":
                    // No necesito el Id y lo pongo en 0 
                    myPlanta.pICod_Planta = 0;
                    break;
                // Si esta modificando 
                case "M":
                    // Tomo el Id provincia de la grilla 
                    myPlanta.pICod_Planta = Convert.ToInt32(dgvPlantas.CurrentRow.Cells["Cod_Planta"].Value);

                    break;
            }
            // tomo el nombre de la provincia de lo que escribió el usuario en el texbox
            myPlanta.pSDescripcion = txtbNombrePlanta.Text;
            myPlanta.pDPrecio = Convert.ToDouble(txtbPrecio.Text);
            myPlanta.pIStock = Convert.ToInt32(txtbStock.Text);
            // Le asigno el país a la provincia
            myPlanta.pMyTipoPlanta = myTipoPlanta;

        }


        #endregion

        #endregion
        

    }
}
