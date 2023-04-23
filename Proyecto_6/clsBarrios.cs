using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsBarrios
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_Barrio;
        string sBarrio;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de las propiedades
        public int pICod_Barrio
        {
            get { return iCod_Barrio; }
            set { iCod_Barrio = value; }
        }
        #endregion
        #region Métodos constructores de la clase
        // Constructor sin parámetros
        public string pSBarrio
        {
            get { return sBarrio; }
            set { sBarrio = value; }
        }
        // Constructor con parámetros
        public clsBarrios()
        {
            pICod_Barrio = 0;
            sBarrio = "";
        }
        public clsBarrios(int iId, string sBar)
        {
            pICod_Barrio = iId;
            sBarrio = sBar;
        }
        #endregion

    }
}
