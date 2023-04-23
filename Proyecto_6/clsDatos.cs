using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Management;

namespace Proyecto_6
{
    class clsDatos
    {
        #region Metodo para cargar la consulta SQL en DataAdapter

        public static DataTable GetSql(string mySql)
        {
            // Constante que almacena el nombre del servidor
            const string sServidor = "LAPTOP7953";
            // Cadena de conexion
            string SqlCadConexion = "Data Source=" + sServidor + ";Initial Catalog=VIVERO_5_P;Integrated Security=True";
            // Indicamos que conexión usaremos para Sql.
            SqlConnection Con = new SqlConnection(SqlCadConexion);
            //DataTable para retorno
            DataTable myDataTable = new DataTable();
            //Abro la conexión a la base de datos
            Con.Open();
            //Declaro el comando y le pasos los parámetros            
            SqlCommand cmd = new SqlCommand(mySql, Con);
            // Declaro el Adaptador y lo instancio
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //Paso los datos de la consulta al DataAdapter
            adapter.Fill(myDataTable);
            //Cierro la Conexión
            Con.Close();
            //Retornar DataTable
            return myDataTable;
        }
        #endregion

        #region Metodo para cargar la consulta SQL en DataAdapter

        public static int GetSql2(string mySql)
        {
            int myDato = 0;
            // Constante que almacena el nombre del servidor
            const string sServidor = "LAPTOP7953";
            // Cadena de conexion
            string SqlCadConexion = "Data Source=" + sServidor + ";Initial Catalog=VIVERO_5_P;Integrated Security=True";
            // Indicamos que conexión usaremos para Sql.
            SqlConnection Con = new SqlConnection(SqlCadConexion);
            //Abro la conexión a la base de datos
            Con.Open();
            //Declaro el comando y le pasos los parámetros            
            SqlCommand cmd = new SqlCommand(mySql, Con);
            // Declaro el Adaptador y lo instancio
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                
                myDato = Convert.ToInt32(reader["Saldo"]);

            }
            Con.Close();
            return myDato;
        }
        #endregion

        #region Metodo para cargar la consulta SQL en DataAdapter

        public static int GetSql3(string mySql)
        {
            int myDato = 0;
            // Constante que almacena el nombre del servidor
            const string sServidor = "LAPTOP7953";
            // Cadena de conexion
            string SqlCadConexion = "Data Source=" + sServidor + ";Initial Catalog=VIVERO_5_P;Integrated Security=True";
            // Indicamos que conexión usaremos para Sql.
            SqlConnection Con = new SqlConnection(SqlCadConexion);
            //Abro la conexión a la base de datos
            Con.Open();
            //Declaro el comando y le pasos los parámetros            
            SqlCommand cmd = new SqlCommand(mySql, Con);
            // Declaro el Adaptador y lo instancio
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                myDato = Convert.ToInt32(reader["Accumulated"]);

            }
            Con.Close();
            return myDato;
        }
        #endregion


        #region Método que carga los combos
        public static void CargarCombo(ComboBox NombreCombo, string NombreTabla, string CampoAMostrar, string IdDeTabla)
        {
            // Creo la tabla 
            DataTable myDataTable = new DataTable();
            // Llamo al método que lee la base de datos y cargo las filas a la tabla
            myDataTable = GetSql("SELECT * FROM " + NombreTabla + " ORDER BY " + CampoAMostrar);
            // Asigno los valores recibidos de la consulta al combo
            NombreCombo.DisplayMember = CampoAMostrar;
            NombreCombo.ValueMember = IdDeTabla;
            NombreCombo.DataSource = myDataTable;
        }
        #endregion
    }
}
