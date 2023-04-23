using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsTiposPlantas
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_Tipo_Planta;
        string sNombre;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de las propiedades
        public int pICod_Tipo_Planta
        {
            get { return iCod_Tipo_Planta; }
            set { iCod_Tipo_Planta = value; }
        }
        #endregion
        #region Métodos constructores de la clase
        // Constructor sin parámetros
        public string pSNombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }
        // Constructor con parámetros
        public clsTiposPlantas()
        {
            pICod_Tipo_Planta = 0;
            sNombre = "";
        }
        public clsTiposPlantas(int iId, string sNom)
        {
            pICod_Tipo_Planta = iId;
            sNombre = sNom;
        }
        #endregion

    }
}
