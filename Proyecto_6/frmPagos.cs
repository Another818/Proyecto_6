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
    public partial class frmPagos : Form
    {
        #region Variables del formulario

        //A para uno nuevo, M para modificar, b para buscar, E espera.
        string myEstado = "";
        //
        clsClientes myCliente = new clsClientes();
        //
        clsFacturas myFactura = new clsFacturas();
        //Creo una variable para las consultas de SQL
        string sCadenaSQL = "";
        string sCadenaSQL2 = "";

        #endregion

        #region Constructor del formulario
        public frmPagos()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        #region EventoLoad

        private void frmPagos_Load(object sender, EventArgs e)
        {
            myEstado = "E";
            SetearControles();
            ControlarBotones();
            CargarGrilla("", "");
            CargarGrilla2("", "");
        }

        #endregion

        #region Evento Botones

        #region Evento click de boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            myEstado = "B";
            SetearControles();
            ControlarBotones();
            txtbBuscar.Focus();
        }

        #endregion

        #region Evento click de boton aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (myEstado)
            {

                case "B":
                    CargarGrilla(Convert.ToString(myCliente.pICod_Cliente), "Cod_Cliente");
                    myEstado = "E";
                    SetearControles();
                    ControlarBotones();
                    break;

                case "S":
                    // Como es una modificacion, tengo que hacer un update a la tabla
                    // Paso los datos de los controles  a los objetos
                    Controles_A_Objeto();
                    Grilla_A_Objeto();
                    Grilla_A_Objeto2();
                    // Creo la consulta SQL para editar los datos
                    int resSaldoF = Convert.ToInt32(myFactura.pDTotal) - Convert.ToInt32(myFactura.pDPagado);

                    if (Convert.ToInt32(txtbPagos.Text) >= myFactura.pDSaldo)
                    {

                        sCadenaSQL2 = "update FACTURAS set Saldo = " + 0
                        + ", Pagado = " + (myFactura.pIPago + myFactura.pDPagado)
                        + " where Nro_Factura = " + myFactura.pINro_Factura;
                        clsDatos.GetSql(sCadenaSQL2);

                        txtbVuelto.Text = Convert.ToString(resSaldoF - myFactura.pIPago).Replace('-', ' ');
                    }
                    else
                    {
                        sCadenaSQL2 = "update FACTURAS set Saldo = " + (resSaldoF - myFactura.pIPago)
                        + ", Pagado = " + (myFactura.pIPago + myFactura.pDPagado)
                        + " where Nro_Factura = " + myFactura.pINro_Factura;
                        clsDatos.GetSql(sCadenaSQL2);

                    }
                    
                    int Filas = dgvFacturas.Rows.Count;
                    int f;

                    //Ejecuta la consulta
                    
                    // For para acumular el saldo
                    CargarGrilla2(Convert.ToString(myCliente.pICod_Cliente), "Cod_Cliente");
                    int acumulador = 0;
                    int SaldoC = 0;
                    for (f = 1; f <= Filas; f++)
                    {
                        int Total = Convert.ToInt32(dgvFacturas.Rows[f-1].Cells[2].Value);
                        acumulador = acumulador + Total;
                        SaldoC = acumulador;
                        if (SaldoC > 0)
                        {
                            sCadenaSQL = "update CLIENTES set Saldo = " + SaldoC
                                + ", Deudor = " + 1
                                + " where Cod_Cliente = " + myCliente.pICod_Cliente;

                            clsDatos.GetSql(sCadenaSQL);
                        }
                        else 
                        {
                            sCadenaSQL = "update CLIENTES set Saldo = " + SaldoC
                                + ", Deudor = " + 0
                                + " where Cod_Cliente = " + myCliente.pICod_Cliente;

                            clsDatos.GetSql(sCadenaSQL);
                        }
                        
                    }
                    // Reinicio elo formulario
                    myEstado = "E";
                    SetearControles();
                    ControlarBotones();
                    CargarGrilla("", "");
                    CargarGrilla2("", "");



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
            CargarGrilla2("", "");
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

                foreach (DataGridViewColumn col in dgvPagos.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Century Schoolbook", 14, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width + 60;

                    if (col.Index < dgvPagos.ColumnCount - 1)
                    {
                        ep.Graphics.DrawLine(Pens.Gray, left - 5, top, left - 5, top + 43 + (dgvPagos.RowCount) * DGV_ALTO);
                    }
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top + 40, ep.MarginBounds.Right - left, 3);
                top += 45;

                foreach (DataGridViewRow row in dgvPagos.Rows)
                {
                    if (row.Index == dgvPagos.RowCount) break;
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

        #region Eventos Changed

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagos.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                myEstado = "S";
                SetearControles();
                ControlarBotones();
                // Paso los datos de la grilla al objeto
                Grilla_A_Objeto();
                // Paso los datos del objeto a los controles
                Objeto_A_Controles();
                if (myCliente.pICod_Cliente == 0)
                {
                    CargarGrilla2(Convert.ToString(1), "Cod_Cliente");
                }
                else if (myCliente.pICod_Cliente >= 1)
                {
                    CargarGrilla2(Convert.ToString(myCliente.pICod_Cliente), "Cod_Cliente");
                }
            }
        }

        private void dgvPagos_SelectionChanged(object sender, EventArgs e)
        {
            //paso los datos del objeto a los  controles 
            Grilla_A_Objeto();
        }
        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        { 
            //paso los datos de la grilla al objeto
            Grilla_A_Objeto2();
            //paso los datos del objeto a los  controles 
            Objeto_A_Controles();
            //
        }

        private void txtbBuscarCli_TextChanged(object sender, EventArgs e)
        {
            //Llamo al metodo y carga la grilla y le paso los parametros de busqueda
            CargarGrilla(txtbBuscar.Text, "Apellido");

        }

        #endregion

        #endregion

        #region Metodos

        #region Métodos que setea los controles del formulario
        private void SetearControles()
        {
            switch (myEstado)
            {

                case "S":
                    txtbPagos.Enabled = true;
                    dgvPagos.Height = 225;
                    dgvFacturas.Height = 238;
                    dgvFacturas.Top = 255;
                    dgvFacturas.Left = 12;
                    gbxBusqueda.Visible = false;
                    gbxMonto.Visible = true;
                    gbVuelto.Visible = true;
                    dgvFacturas.Visible = true;
                    dgvPagos.Enabled = false;
                    break;

                case "B":
                    txtbPagos.Enabled = false;
                    dgvPagos.Height = 320;
                    txtbBuscar.Enabled = true;
                    dgvPagos.Enabled = true;
                    break;

                case "E":

                    txtbPagos.Enabled = false;
                    txtbBuscar.Enabled = false;
                    dgvPagos.Height = 320;
                    gbxBusqueda.Visible = true;
                    dgvFacturas.Visible = false;
                    gbxMonto.Visible = false;
                    gbVuelto.Visible = false;
                    dgvPagos.Enabled = true;

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
                sMyCadenaSQL = "select * from Vista_Pagos";
            }
            //Si estoy buscando
            else
            {
                sMyCadenaSQL = "select * from Vista_Pagos where " + Campo + " like '" + Buscar + "%' order by " + Campo;
            }

            //Llamamos al metodo para cargar los datos en el origen de la grilla 
            // pasando los parametros de la consuelta. G.
            DataTable mDtTable = new DataTable();
            mDtTable = clsDatos.GetSql(sMyCadenaSQL);
            // Evito que el dgv genere columnas automaticas
            dgvPagos.AutoGenerateColumns = false;
            //Asigno los datos que me devuelve el método GetSql a la grilla de3l formulario. G.
            dgvPagos.DataSource = mDtTable;
            //Cuento la cantidad de filas de la grilla
            int Filas = dgvPagos.Rows.Count;
        }
        private void CargarGrilla2(string Buscar, string Campo)
        {
            //Variable que guarda la cadena para SQL
            string sMyCadenaSQL = "";
            //Si no estoy buscando
            if (Buscar == "")
            {
                sMyCadenaSQL = "select * from FACTURAS AS FA where FA.Cod_Cliente = " + myCliente.pICod_Cliente;
            }
            //Si estoy buscando
            else
            {

                sMyCadenaSQL = "select * from FACTURAS AS FA where FA." + Campo + " = " + Buscar; 
            }

            //Llamamos al metodo para cargar los datos en el origen de la grilla 
            // pasando los parametros de la consuelta. G.
            DataTable mDtTable = new DataTable();
            mDtTable = clsDatos.GetSql(sMyCadenaSQL);
            // Evito que el dgv genere columnas automaticas
            dgvFacturas.AutoGenerateColumns = false;
            //Asigno los datos que me devuelve el método GetSql a la grilla de3l formulario. G.
            dgvFacturas.DataSource = mDtTable;
            //Cuento la cantidad de filas de la grilla
            int Filas = dgvFacturas.Rows.Count;
        }

        #endregion

        #region Método que controla el comportamiento de los botones
        private void ControlarBotones()
        {

            switch (myEstado)
            {
                // Si esta haciendo un alta,una modificacion o buscando
                case "B":
                case "S":
                    //Oculto los botones innecesarios
                    btnBuscar.Visible = false;
                    btnSalir.Visible = false;
                    btnImprimir.Visible = false;
                    // Muestro los botones
                    btnAceptar.Visible = true;
                    btnCancelar.Visible = true;


                    break;
                //Si el formulario esta en espera 
                case "E":
                    // Muestro los botones  innecesarios
                    btnBuscar.Visible = true;
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
            myCliente.pDSaldo = Convert.ToDouble(dgvPagos.CurrentRow.Cells["Saldo_Cliente"].Value);
            myCliente.pICod_Cliente = Convert.ToInt32(dgvPagos.CurrentRow.Cells["Cod_Cliente"].Value);
            
            
        }
        private void Grilla_A_Objeto2()
        {
            myFactura.pDTotal = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["Total"].Value);
            myFactura.pINro_Factura = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["Nro_Factura"].Value);
            myFactura.pDPagado = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["Pagado"].Value);
            myFactura.pDSaldo = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["Saldo"].Value);
        }

        #endregion

        #region Metodo que pasa los datos del objeto a los controles

        private void Objeto_A_Controles()
        {
            // Paso el nombre de la provincia guardado en el objeto al control
            txtbPagos.Text = Convert.ToString(myFactura.pDSaldo);
        }

        #endregion

        #region Metodo que limpia los controles del formulario

        private void Limpiar_Controles()
        {
            // Borro lo que este escrito en el textbox
            txtbPagos.Text = "";
            txtbBuscar.Text = "";
        }

        #endregion

        #region Método que controla los controles
        private void Controles_A_Objeto()
        {
            myFactura.pIPago = Convert.ToInt32(txtbPagos.Text);

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
                    // Tomo el Id cliente de la grilla 
                    myCliente.pICod_Cliente = Convert.ToInt32(dgvPagos.CurrentRow.Cells["Cod_Cliente"].Value);

                    break;
            }
            // tomo el nombre de la provincia de lo que escribió el usuario en el texbox
            //myCliente.pDSaldo = Convert.ToDouble(txtbPagos.Text);
        }


        #endregion

        #endregion

    }
}
