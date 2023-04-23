using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_6
{
    class clsRol
    {
        #region Propiedades de clase
        //Propiedades de clase
        int iIdRol;
        string sDescripcion;
        int iActivo;
        DateTime dFechaRegistro;
        #endregion

        #region Encapsulamiento de las propiedades
        public int pIIdRol
        {
            get { return iIdRol; }
            set { iIdRol = value; }

        }

        public string pSDescripcion
        {
            get { return sDescripcion; }
            set { sDescripcion = value; }

        }

        public int pIActivo
        {
            get { return iActivo; }
            set { iActivo = value; }
        }

        public DateTime pDFechaRegistro
        {
            get { return dFechaRegistro; }
            set { dFechaRegistro = value; }

        }
        #endregion

        #region Métodos constructores
        //Método constructor sin párametros
        public clsRol()
        {
            pIIdRol = 0;
            pSDescripcion = "";
            pIActivo = 0;
            pDFechaRegistro = DateTime.Now;

        }
        #endregion
    }
}
