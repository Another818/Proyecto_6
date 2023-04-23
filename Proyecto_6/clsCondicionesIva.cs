using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsCondicionesIva
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_Condicion_Iva;
        string sDescripcion;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de las propiedades
        public int pICod_Condicion_Iva
        {
            get { return iCod_Condicion_Iva; }
            set { iCod_Condicion_Iva = value; }
        }
        public string pSDescripcion
        {
            get { return sDescripcion; }
            set { sDescripcion = value; }
        }
        #endregion
        #region Métodos constructores de la clase
        // Constructor sin parámetros
        public clsCondicionesIva()
        {
            pICod_Condicion_Iva = 0;
            sDescripcion = "";
        }
        // Constructor con parámetros
        public clsCondicionesIva(int iId, string sDesc)
        {
            pICod_Condicion_Iva = iId;
            sDescripcion = sDesc;
        }
        #endregion
    }
}
