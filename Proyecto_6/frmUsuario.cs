using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_6
{
    public partial class frmUsuario : Form
    {

        #region Variables del formulario

        //A para agregar, M para modificar, b para buscar, E espera.
        string myEstado = "";
        //Utilizo la clase Usuario
        clsUsuarios myUsuario = new clsUsuarios();
        //Creo una variable para las consultas de SQL
        string sCadenaSQL = "";

        #endregion

        #region Constructor del formulario
        public frmUsuario()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        #region EventoLoad
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            myEstado = "E";
            ControlarBotones();
            SetearControles();
            CargarGrilla("", "");
            Grilla_A_Objeto();
            Objeto_A_Controles();
        }
        #endregion

        #region Evento Botones

        #region Evento click de botón agregar
        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            myEstado = "A";
            SetearControles();
            Limpiar_Controles();
            ControlarBotones();
        }
        #endregion

        #region Evento click de boton aceptar
        private void btnAceptarCli_Click(object sender, EventArgs e)
        {
            switch (myEstado)
            {
                // Si estoy creando un nuevo pais 
                case "A":
                    // Llamo al metodo que pasa los datos de los controles a la clase
                    Controles_A_Objeto();
                    // Armo la cadena con el insert
                    sCadenaSQL = "insert into USUARIO(Nombre, Contrasenia, Creacion, Cant_Ingresadas) values ('" + myUsuario.pSNombre + "', '"
                       + myUsuario.pSContrasenia + "', '" 
                       + DateTime.Now.Date + "', "
                       + 0 + ")";
                    // Ejecuto la consulta
                    clsDatos.GetSql(sCadenaSQL);
                    // llamo al evento click del boton cancelar para recargar el formulario
                    btnCancelar.PerformClick();
                    break;

                case "I":
                    if (myUsuario.pSContrasenia == txtbContra.Text) 
                    {
                        int cant = myUsuario.pICant_Ingresadas + 1;
                        sCadenaSQL = "update USUARIO set Cant_Ingresadas = '" + cant 
                            + "', Ulti_Ingresada = '" + DateTime.Now.Date
                            + "' where ID = " + myUsuario.pIID;

                        clsDatos.GetSql(sCadenaSQL);
                        // llamo al evento click del boton cancelar para recargar el formulario
                        btnCancelar.PerformClick();
                        dgvUsuario.Refresh();

                        frmMenú myForm = new frmMenú();
                        myForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña equivocada, vuelva a intentar!");
                    }

                    break;

                

            }
        }
        #endregion

        #region Evento click de boton Ingresar

        private void btnIngresarCli_Click(object sender, EventArgs e)
        {
            myEstado = "I";
            SetearControles();
            Limpiar_Controles();
            ControlarBotones();
            Grilla_A_Objeto();
            Objeto_A_Controles();
        }

        #endregion

        #region Evento click de boton borrar

        #endregion

        #region Evento click de boton cancelar
        private void btnCancelarCli_Click(object sender, EventArgs e)
        {
            myEstado = "E";
            ControlarBotones();
            SetearControles();
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


        #region Evento selection changed
        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            // Paso los datos de la grilla al objeto
            Grilla_A_Objeto();
            // Paso los datos del objeto a los controles
            Objeto_A_Controles();
        }
        #endregion

        #endregion

        #region Métodos
        
        #region Método que carga la grilla de los clientes

        private void CargarGrilla(string Buscar, string Campo)
        {
            //Variable que guarda la cadena para SQL
            string sMyCadenaSQL = "";
            //Si no estoy buscando
            if (Buscar == "")
            {
                sMyCadenaSQL = "select * from Vista_Usuario";
            }
            //Si estoy buscando
            else
            {
                sMyCadenaSQL = "select * from Vista_Usuario where " + Campo + " like '" + Buscar + "%' order by " + Campo;
            }

            //Llamamos al metodo para cargar los datos en el origen de la grilla 
            // pasando los parametros de la consuelta. G.
            DataTable mDtTable = new DataTable();
            mDtTable = clsDatos.GetSql(sMyCadenaSQL);
            // Evito que el dgv genere columnas automaticas
            dgvUsuario.AutoGenerateColumns = false;
            //Asigno los datos que me devuelve el método GetSql a la grilla del formulario.
            dgvUsuario.DataSource = mDtTable;
            //Cuento la cantidad de filas de la grilla
            int Filas = dgvUsuario.Rows.Count;
        }

        #endregion

        #region Métodos que setea los controles del formulario
        private void SetearControles()
        {
            switch (myEstado)
            {
                case "I":
                    txtbUser.Enabled = false;
                    txtbContra.Enabled = true;
                    txtbContra.Visible = true;
                    lblContra.Visible = true;
                    txtbContra.Location = new Point(279, 43);
                    lblContra.Location = new Point(199, 46);
                    txtbFecha.Visible = false;
                    lblFecha.Visible = false;

                    break;

                case "A":
                    txtbUser.Enabled = true;
                    txtbContra.Enabled = true;
                    txtbContra.Visible = true;
                    lblContra.Visible = true;
                    txtbContra.Location = new Point(279, 43);
                    lblContra.Location = new Point(199, 46);
                    txtbFecha.Visible = false;
                    lblFecha.Visible = false;
                    break;


                case "E":
                    lblFecha.Visible = true;
                    txtbFecha.Visible = true;
                    gbxUsuario.Visible = true;
                    txtbContra.Visible = false;
                    lblContra.Visible = false;
                    txtbFecha.Enabled = false;
                    txtbUser.Enabled = false;
                    dgvUsuario.Height = 182;
                    dgvUsuario.Width = 429;
                    gbxUsuario.Width = 429;
                    gbxUsuario.Height = 105;
                    dgvUsuario.Enabled = true;

                    break;

            }
        }
        #endregion

        #region Método que controla el comportamiento de los botones
        private void ControlarBotones()
        {

            switch (myEstado)
            {
                // Si esta haciendo un alta,una modificacion o buscando
                case "A":
                    //Oculto los botones innecesarios
                    btnAgregar.Visible = true;
                    btnIngresar.Visible = false;
                    btnSalir.Visible = false;
                    btnAgregar.Location = new Point(12, 12);
                    // Muestro los botones
                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;


                    break;

                case "I":
                    //Oculto los botones innecesarios
                    btnAgregar.Visible = false;
                    btnIngresar.Visible = false;
                    btnSalir.Visible = false;
                    btnIngresar.Location = new Point(12, 12);
                    // Muestro los botones
                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;

                    break;
                //Si el formulario esta en espera 
                case "E":
                    // Muestro los botones  innecesarios 
                    btnAgregar.Visible = true;
                    btnIngresar.Visible = true;
                    btnSalir.Visible = true;
                    btnAgregar.Location = new Point(93, 12);
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
            myUsuario.pIID = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["ID"].Value);
            myUsuario.pSNombre = Convert.ToString(dgvUsuario.CurrentRow.Cells["Nombre"].Value);
            myUsuario.pDCreacion = Convert.ToDateTime(dgvUsuario.CurrentRow.Cells["Creacion"].Value);
            myUsuario.pSContrasenia = Convert.ToString(dgvUsuario.CurrentRow.Cells["Contrasenia"].Value);
            myUsuario.pICant_Ingresadas = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["Cant_Ingresadas"].Value);
        }

        #endregion

        #region Metodo que pasa los datos del objeto a los controles

        private void Objeto_A_Controles()
        {
            // Paso el nombre de la provincia guardado en el objeto al control
            txtbUser.Text = Convert.ToString(myUsuario.pSNombre);
            txtbFecha.Text = Convert.ToString(myUsuario.pDCreacion);
        }

        #endregion

        #region Metodo que limpia los controles del formulario

        private void Limpiar_Controles()
        {
            // borrolo que este escrito en el textbox
            txtbUser.Text = "";
            txtbFecha.Text = "";
        }

        #endregion

        #region Método que controla los controles
        private void Controles_A_Objeto()
        {

            myUsuario.pSNombre = txtbUser.Text;
            myUsuario.pSContrasenia = txtbContra.Text;

            // Pregunto a 1 variable que esta haciendo el usuario 
            switch (myEstado)
            {
                //si esta haciendo un alta
                case "A":
                    // No necesito el Id y lo pongo en 0 
                    myUsuario.pIID = 0;
                    break;
                
            }
            // tomo el nombre de la provincia de lo que escribió el usuario en el texbox

        }


        #endregion



        #endregion
    }
}
