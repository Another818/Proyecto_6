using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsProvincias
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_Provincia;
        string sProvincia;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de las propiedades
        public int pICod_Provincia
        {
        get { return iCod_Provincia; }
        set { iCod_Provincia = value; }
        }
        #endregion
        #region Métodos constructores de la clase
        // Constructor sin parámetros
        public string pSProvincia
        {
        get { return sProvincia; }
        set { sProvincia = value; }
        }
        // Constructor con parámetros
        public clsProvincias()
        {
        pICod_Provincia = 0;
        sProvincia = "";
        }
        public clsProvincias(int iId, string sPro)
        {
        pICod_Provincia = iId;
        sProvincia = sPro;
        }
        #endregion

    }
}
