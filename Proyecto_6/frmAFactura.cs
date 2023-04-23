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
    public partial class frmAFactura : Form
    {
        #region Variables del formulario

        //A para uno nuevo, M para modificar, b para buscar, E espera.
        string myEstado = "";
        //
        clsCondicionesIva myCondicionIva = new clsCondicionesIva();
        //
        clsFormasPago myFormaPago = new clsFormasPago();
        //
        clsClientes myClientes = new clsClientes();
        //
        clsPlantas myPlanta = new clsPlantas();
        //
        clsFacturas myFacturas = new clsFacturas();
        //Creo una variable para las consultas de SQL
        string sCadenaSQL = "";
        string sCadenaSQL2 = "";
        string sCadenaSQL3 = "";

        #endregion

        #region Constructor del formulario
        public frmAFactura()
        {
            InitializeComponent();
        }
        internal static int variableCompartida;
        #endregion

        #region Eventos

        #region EventoLoad

        private void frmAFactura_Load(object sender, EventArgs e)
        {
            myEstado = "A";
            CargarGrilla("", "");
            CargarGrilla1("", "");
            clsDatos.CargarCombo(cboFormasPago, "FORMAS_PAGO", "Descripcion", "Cod_Forma_Pago");
            SetearControles();
            Grilla_A_Objeto();
            Grilla_A_Objeto2();
            Objeto_A_Controles();
        }

        #endregion

        #region Evento Botones

        #region
        private void btnAgregarPlanta_Click(object sender, EventArgs e)
        {
            if (myPlanta.pIStock >= Convert.ToInt32(txtbCantidad.Text))
            {
                int Fila = dgvResumen.Rows.Count;
                dgvResumen.Rows.Add(Fila + 1, myPlanta.pICod_Planta, txtbCantidad.Text, myPlanta.pSDescripcion, myPlanta.pDPrecio, myPlanta.pDPrecio * Convert.ToInt32(txtbCantidad.Text));
                PrimeraFila();
            }
            else
            {
                MessageBox.Show("No hay suficiente Stock!");
            }
        }
        #endregion

        #region Evento click de boton buscar
        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            myEstado = "B";
            SetearControles();
            txtbBusqueda.Focus();
        }
        #endregion

        #region Evento click de boton aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (myEstado)
            {
                case "A":
                    // Llamo al metodo que pasa los datos de los controles a la clase
                    int id = variableCompartida + 1;
                    int Filas = dgvResumen.Rows.Count;
                    int[] TotalF;
                    TotalF = new int[Filas];
                    int f;
                    for (f = 1; f <= Filas; f++)
                    {
                        int Total = Convert.ToInt32(dgvResumen.Rows[f - 1].Cells[5].Value);
                        int suma = Total + TotalF[f - 1];
                        TotalF[f - 1] = suma;
                    }

                    int total = 0;
                    //Switch para hacer el total de hasta 10 plantas.
                    int i;
                    for (i = 1; i <= Filas; i++)
                    {
                        total = total + TotalF[i - 1];
                    }

                    //Controles_A_Objeto();
                    //Armo la cadena con el insert
                    Controles_A_Objeto();
                    sCadenaSQL = "insert into FACTURAS(Nro_Factura, Fecha, Cod_Forma_Pago, Saldo, Total, Pagado, Cod_Cliente) values ("+ id + ",'" 
                           + DateTime.Now.Date + "',"
                           + myFormaPago.pICod_FormaPago + ","
                           + total + ","
                           + total + ","
                           + 0 + ","
                           + myClientes.pICod_Cliente + ")";
                    // Ejecuto la consulta
                    clsDatos.GetSql(sCadenaSQL);

                    sCadenaSQL = @"select MAX(Suma) as Accumulated FROM 
                                 ( select sum(sum(FA.Saldo)) over (order by FA.Saldo DESC) as Suma
                                 from FACTURAS as FA 
                                 where FA.Cod_Cliente = " + myClientes.pICod_Cliente + "group by FA.Saldo ) AS sumas";

                    int SaldoF = clsDatos.GetSql3(sCadenaSQL);

                    sCadenaSQL2 = "update CLIENTES set Saldo = " + SaldoF
                           + " where Cod_Cliente = " + myClientes.pICod_Cliente;

                    sCadenaSQL3 = "update CLIENTES set Deudor = " + 1
                           + " where Cod_Cliente = " + myClientes.pICod_Cliente;
                    //
                    clsDatos.GetSql(sCadenaSQL2);
                    //
                    clsDatos.GetSql(sCadenaSQL3);
                    //llamo al evento click del boton cancelar para recargar el formulario
                    btnCancelar.PerformClick();
                    break;

                case "B":
                    CargarGrilla(Convert.ToString(myClientes.pICod_Cliente), "Cod_Cliente");
                    myEstado = "A";
                    SetearControles();
                    break;
            }
        }
            #endregion

            #region Evento click de boton cancelar
            private void btnCancelar_Click(object sender, EventArgs e)
            {
                switch (myEstado) 
                {
                    case "A":
                        this.Close();
                        break;
                    case "B":
                        myEstado = "A";
                        CargarGrilla("", "");
                        CargarGrilla1("", "");
                        SetearControles();
                        Grilla_A_Objeto();
                        Grilla_A_Objeto2();
                        Objeto_A_Controles();
                    break;
                }
            }
        #endregion

            #region Evento agregado de fila

            private void dgvResumen_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
            {
                // Llamo al metodo que pasa los datos de los controles a la clase
                int Filas = dgvResumen.Rows.Count;
                int[] TotalF;
                TotalF = new int[Filas];
                int f;
                for (f = 1; f <= Filas; f++)
                {
                    int Total = Convert.ToInt32(dgvResumen.Rows[f - 1].Cells[5].Value);
                    int suma = Total + TotalF[f - 1];
                    TotalF[f - 1] = suma;
                }

                int total = 0;
                //Switch para hacer el total de hasta 10 plantas.
                int i;
                for (i = 1; i <= Filas; i++)
                {
                    total = total + TotalF[i - 1];
                }

                txtbTotal.Text = total.ToString();
            }
        #endregion

        #endregion

        #region Evento de los controles

        private void txtbBuscarCli_TextChanged(object sender, EventArgs e)
        {
            //Llamo al metodo y carga la grilla y le paso los parametros de busqueda
            CargarGrilla(txtbBusqueda.Text, "Apellido");

        }


        #endregion

        #region Evento selection changed

        private void dgvAFacturas_SelectionChanged(object sender, EventArgs e)
            {
                // Paso los datos de la grilla al objeto
                Grilla_A_Objeto();
                // Paso los datos del objeto a los controles
                Objeto_A_Controles();
            }

            private void dgvAFacturas2_SelectionChanged(object sender, EventArgs e)
            {
                // Paso los datos de la grilla al objeto
                Grilla_A_Objeto2();
                // Paso los datos del objeto a los controles
                Objeto_A_Controles();
            }
            private void dgvResumen_SelectionChanged(object sender, EventArgs e)
            {
                Grilla_A_Objeto3();
            }

            #endregion

            #endregion

            #region Metodos

            #region Método que carga la grilla de las plantas

            private void PrimeraFila()
            {
                int id = variableCompartida + 1;
                int cantidad = Convert.ToInt32(txtbCantidad.Text);
                int precio = Convert.ToInt32(myPlanta.pDPrecio) * cantidad;
                int stock = myPlanta.pIStock - cantidad;
                sCadenaSQL = "insert into DETALLES_FACTURAS(Cantidad, Precio, Cod_Planta, Nro_Factura) values (" + cantidad + "," + precio
                   + "," + myPlanta.pICod_Planta + "," + id + ")";

                sCadenaSQL2 = "update PLANTAS set Stock = " + stock
                + " where Cod_Planta = " + myPlanta.pICod_Planta;

                // Ejecuto la consulta
                clsDatos.GetSql(sCadenaSQL);
                clsDatos.GetSql(sCadenaSQL2);
                CargarGrilla1("", "");


            }

            private void CargarGrilla(string Buscar, string Campo)
            {
                //Variable que guarda la cadena para SQL
                string sMyCadenaSQL = "";
                //Si no estoy buscando
                if (Buscar == "")
                {
                    sMyCadenaSQL = "select * from Vista_FClientes";
                }
                //Si estoy buscando
                else
                {
                    sMyCadenaSQL = "select * from Vista_FClientes where " + Campo + " like '" + Buscar + "%' order by " + Campo;
                }

                //Llamamos al metodo para cargar los datos en el origen de la grilla 
                // pasando los parametros de la consuelta. G.
                DataTable mDtTable = new DataTable();
                mDtTable = clsDatos.GetSql(sMyCadenaSQL);
                // Evito que el dgv genere columnas automaticas
                dgvFClientes.AutoGenerateColumns = false;
                //Asigno los datos que me devuelve el método GetSql a la grilla del formulario. G.
                dgvFClientes.DataSource = mDtTable;
                //Cuento la cantidad de filas de la grilla
                int Filas = dgvFClientes.Rows.Count;
            }

            #endregion

            #region Método que carga la grilla de las plantas

            private void CargarGrilla1(string Buscar, string Campo)
            {
                //Variable que guarda la cadena para SQL
                string sMyCadenaSQL = "";
                //Si no estoy buscando
                if (Buscar == "")
                {
                    sMyCadenaSQL = "select * from Vista_FPlantas";
                }
                //Si estoy buscando
                else
                {
                    sMyCadenaSQL = "select * from Vista_FPlantas where " + Campo + " like '" + Buscar + "%' order by " + Campo;
                }

                //Llamamos al metodo para cargar los datos en el origen de la grilla
                // pasando los parametros de la consulta. G.
                DataTable mDtTable = new DataTable();
                mDtTable = clsDatos.GetSql(sMyCadenaSQL);
                // Evito que el dgv genere columnas automaticas
                dgvFClientes.AutoGenerateColumns = false;
                //Asigno los datos que me devuelve el método GetSql a la grilla del formulario. G.
                dgvFPlantas.DataSource = mDtTable;
                //Cuento la cantidad de filas de la grilla
                int Filas = dgvFPlantas.Rows.Count;
            }

            #endregion

           

            #region Metodo que pasa los datos de la grilla al objeto

            private void Grilla_A_Objeto()
            {
                // Paso los datos de la fila actual al objeto
                myClientes.pICod_Cliente = Convert.ToInt32(dgvFClientes.CurrentRow.Cells["Cod_Cliente"].Value);
                myClientes.pSApellido = Convert.ToString(dgvFClientes.CurrentRow.Cells["Apellido"].Value);
                myClientes.pSNombre = Convert.ToString(dgvFClientes.CurrentRow.Cells["Nombre"].Value);
                myClientes.pSCuit = Convert.ToString(dgvFClientes.CurrentRow.Cells["Cuit"].Value);
                myCondicionIva.pSDescripcion = Convert.ToString(dgvFClientes.CurrentRow.Cells["Descripcion"].Value);
                myCondicionIva.pICod_Condicion_Iva = Convert.ToInt32(dgvFClientes.CurrentRow.Cells["Cod_Condicion_Iva"].Value);
                
            }

            private void Grilla_A_Objeto2()
            {
                myPlanta.pICod_Planta = Convert.ToInt32(dgvFPlantas.CurrentRow.Cells["Cod_Planta"].Value);
                myPlanta.pSDescripcion = Convert.ToString(dgvFPlantas.CurrentRow.Cells["Plantas"].Value);
                myPlanta.pDPrecio = Convert.ToDouble(dgvFPlantas.CurrentRow.Cells["Precio"].Value);
                myPlanta.pIStock = Convert.ToInt32(dgvFPlantas.CurrentRow.Cells["Stock"].Value);
            }

            private void Grilla_A_Objeto3()
            {
                myFacturas.pIClave = Convert.ToInt32(dgvResumen.CurrentRow.Cells["Clave"].Value);
                myPlanta.pICod_Planta = Convert.ToInt32(dgvResumen.CurrentRow.Cells["Codigo"].Value);

            }

            #endregion

            #region Metodo que pasa los datos del objeto a los controles

            private void Objeto_A_Controles()
            {
                txtbCantidad.Text = Convert.ToString(1);
                txtbApellido.Text = myClientes.pSApellido;
                txtbNombre.Text = myClientes.pSNombre;
                txtbCuit.Text = myClientes.pSCuit;
                txtbCondicionIva.Text = myCondicionIva.pSDescripcion;
                cboFormasPago.SelectedValue = 1;
                
            }
            #endregion

            #region Método que controla los controles
            private void Controles_A_Objeto()
            {
                myFormaPago.pICod_FormaPago = Convert.ToInt32(cboFormasPago.SelectedValue);

            }

            #endregion

            #region Método setear controles
            private void SetearControles()
            {
                switch (myEstado) 
                {
                    case "A":
                        txtbApellido.Enabled = false;
                        txtbNombre.Enabled = false;
                        txtbCantidad.Enabled = true;
                        txtbCondicionIva.Enabled = false;
                        txtbCuit.Enabled = false;
                        cboFormasPago.Enabled = true;
                        gbxBusqueda.Visible = false;
                        dgvResumen.Visible = true;
                    break;
                    
                    case "B":
                        txtbApellido.Enabled = false;
                        txtbNombre.Enabled = false;
                        txtbCantidad.Enabled = true;
                        txtbCondicionIva.Enabled = false;
                        txtbCuit.Enabled = false;
                        cboFormasPago.Enabled = true;
                        gbxBusqueda.Visible = true;
                        dgvResumen.Visible = false;
                        break;
                }
                
            }
            #endregion

            #region
            private void btnEliminar_Click(object sender, EventArgs e)
            {
                int datos = dgvResumen.RowCount;
                int Filas = dgvResumen.CurrentRow.Index;
                // Almaceno la consulta SQL
                sCadenaSQL = "delete DETALLES_FACTURAS where Cod_Planta = " + myPlanta.pICod_Planta;

                if (datos > 1)
                {
                    dgvResumen.Rows.RemoveAt(Filas);
                }
                else 
                {
                    dgvResumen.Rows.Clear();
                    dgvResumen.Refresh();
                }
                


                // Ejecuto la consulta
                clsDatos.GetSql(sCadenaSQL);
            }
        #endregion

        #endregion

        
    }
}
