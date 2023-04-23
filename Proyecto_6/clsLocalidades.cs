using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsLocalidades
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_Localidad;
        string sLocalidad;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de las propiedades
        public int pICod_Localidad
        {
            get { return iCod_Localidad; }
            set { iCod_Localidad = value; }
        }
        #endregion
        #region Métodos constructores de la clase
        // Constructor sin parámetros
        public string pSLocalidad
        {
            get { return sLocalidad; }
            set { sLocalidad = value; }
        }
        // Constructor con parámetros
        public clsLocalidades()
        {
            pICod_Localidad = 0;
            sLocalidad = "";
        }
        public clsLocalidades(int iId, string sNom)
        {
            pICod_Localidad = iId;
            sLocalidad = sNom;
        }
        #endregion

    }
}
