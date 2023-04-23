using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsCalles
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_Calle;
        string sCalle;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de las propiedades
        public int pICod_Calle
        {
            get { return iCod_Calle; }
            set { iCod_Calle = value; }
        }
        #endregion
        #region Métodos constructores de la clase
        // Constructor sin parámetros
        public string pSCalle
        {
            get { return sCalle; }
            set { sCalle = value; }
        }
        // Constructor con parámetros
        public clsCalles()
        {
            pICod_Calle = 0;
            sCalle = "";
        }
        public clsCalles(int iId, string sCall)
        {
            pICod_Calle = iId;
            sCalle = sCall;
        }
        #endregion

    }
}
