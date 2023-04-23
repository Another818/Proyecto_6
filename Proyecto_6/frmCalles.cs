using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_6
{
    public partial class frmCalles : Form
    {
        #region Variables del formulario

        //A para uno nuevo, M para modificar, b para buscar, E espera.
        string myEstado = "";
        //
        clsCalles myCalles = new clsCalles();
        //Creo una variable para las consultas de SQL
        string sCadenaSQL = "";

        #endregion

        #region Constructor del formulario
        public frmCalles()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        #region EventoLoad

        private void frmCalles_Load(object sender, EventArgs e)
        {
            myEstado = "E";
            SetearControles();
            ControlarBotones();
            CargarGrilla("", "");
            Grilla_A_Objeto();
            Objeto_A_Controles();
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
            DialogResult myRespuesta = MessageBox.Show("Desea eliminar la calle: " + myCalles.pSCalle,
                "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Si la respuesta es si,
            if (myRespuesta == DialogResult.Yes)
            {

                // Almaceno la consulta SQL
                sCadenaSQL = "delete CALLES where Cod_Calle = " + myCalles.pICod_Calle;
                // Ejecuto la consulta
                clsDatos.GetSql(sCadenaSQL);



                myEstado = "E";
                SetearControles();
                ControlarBotones();
                CargarGrilla("", "");
            }

            // todo nombre del pais de lo que escribio el usuario en el textbox
            myCalles.pSCalle = txtbCalles.Text;
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
                    sCadenaSQL = "insert into CALLES(Calle) values ('" + myCalles.pSCalle + "')";
                    // Ejecuto la consulta
                    clsDatos.GetSql(sCadenaSQL);
                    // llamo al evento click del boton cancelar para recargar el formulario
                    btnCancelar.PerformClick();
                    break;

                case "B":
                    CargarGrilla(Convert.ToString(myCalles.pICod_Calle), "Cod_Calle");
                    myEstado = "E";
                    SetearControles();
                    ControlarBotones();
                    break;

                case "M":
                    // Como es una modificacion, tengo que hacer un update a la tabla
                    // Paso los datos de los controles  a los objetos
                    Controles_A_Objeto();
                    // Creo la consulta SQL para editar los datos
                    sCadenaSQL = "update CALLES set Calle = '" + myCalles.pSCalle
                       + "' where Cod_Calle = " + myCalles.pICod_Calle;

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
            CargarGrilla(txtbBuscar.Text, "Calle");
        }

        #endregion

        #region Evento selection changed

        private void dgvCalles_SelectionChanged(object sender, EventArgs e)
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
                    txtbCalles.Enabled = true;
                    dgvCalles.Height = 400;
                    dgvCalles.Enabled = false;
                    gbBusqueda.Visible = false;
                    break;

                case "M":
                    txtbCalles.Enabled = true;
                    dgvCalles.Height = 400;
                    dgvCalles.Enabled = false;
                    gbBusqueda.Visible = false;
                    break;

                case "B":
                    txtbCalles.Enabled = false;
                    dgvCalles.Height = 270;
                    dgvCalles.Enabled = true;
                    gbBusqueda.Visible = true;
                    break;

                case "E":
                    txtbCalles.Enabled = false;
                    dgvCalles.Height = 400;
                    dgvCalles.Enabled = true;
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
                sMyCadenaSQL = "select * from Vista_Calles";
            }
            //Si estoy buscando
            else
            {
                sMyCadenaSQL = "select * from Vista_Calles where " + Campo + " like '" + Buscar + "%' order by " + Campo;
            }

            //Llamamos al metodo para cargar los datos en el origen de la grilla 
            // pasando los parametros de la consuelta. G.
            DataTable mDtTable = new DataTable();
            mDtTable = clsDatos.GetSql(sMyCadenaSQL);
            // Evito que el dgv genere columnas automaticas
            dgvCalles.AutoGenerateColumns = false;
            //Asigno los datos que me devuelve el método GetSql a la grilla de3l formulario. G.
            dgvCalles.DataSource = mDtTable;
            //Cuento la cantidad de filas de la grilla
            int Filas = dgvCalles.Rows.Count;
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
            myCalles.pICod_Calle = Convert.ToInt32(dgvCalles.CurrentRow.Cells["Cod_Calle"].Value);
            myCalles.pSCalle = Convert.ToString(dgvCalles.CurrentRow.Cells["Calle"].Value);
            
        }

        #endregion

        #region Metodo que pasa los datos del objeto a los controles

        private void Objeto_A_Controles()
        {
            // Paso el nombre de la provincia guardado en el objeto al control
            txtbCalles.Text = myCalles.pSCalle;
        }

        #endregion

        #region Metodo que limpia los controles del formulario

        private void Limpiar_Controles()
        {
            // borrolo que este escrito en el textbox
            txtbCalles.Text = "";
        }

        #endregion

        #region Método que controla los controles
        private void Controles_A_Objeto()
        {

            // Pregunto a 1 variable que esta haciendo el usuario 
            switch (myEstado)
            {
                //si esta haciendo un alta
                case "A":
                    // No necesito el Id y lo pongo en 0 
                    myCalles.pICod_Calle = 0;
                    break;
                // Si esta modificando 
                case "M":
                    // Tomo el Id provincia de la grilla 
                    myCalles.pICod_Calle = Convert.ToInt32(dgvCalles.CurrentRow.Cells["Cod_Calle"].Value);

                    break;
            }
            // tomo el nombre de la provincia de lo que escribió el usuario en el texbox
            myCalles.pSCalle = txtbCalles.Text;

        }


        #endregion

        #endregion
    }
}
