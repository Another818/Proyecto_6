using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsFormasPago
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_FormaPago;
        string sDescripcion;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de las propiedades
        public int pICod_FormaPago
        {
            get { return iCod_FormaPago; }
            set { iCod_FormaPago = value; }
        }
        #endregion
        #region Métodos constructores de la clase
        // Constructor sin parámetros
        public string pSDescripcion
        {
            get { return sDescripcion; }
            set { sDescripcion = value; }
        }
        // Constructor con parámetros
        public clsFormasPago()
        {
            pICod_FormaPago = 0;
            sDescripcion = "";
        }
        public clsFormasPago(int iId, string sDesc)
        {
            pICod_FormaPago = iId;
            sDescripcion = sDesc;
        }
        #endregion

    }
}
