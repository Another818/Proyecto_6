using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsPlantas
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_Planta;
        string sDescripcion;
        clsTiposPlantas myTipoPlanta;
        double dPrecio;
        int iStock;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de todas las propiedades
        public int pICod_Planta
        {
            get { return iCod_Planta; }
            set { iCod_Planta = value; }
        }
        public string pSDescripcion
        {
            get { return sDescripcion; }
            set { sDescripcion = value; }
        }
        internal clsTiposPlantas pMyTipoPlanta
        {
            get { return myTipoPlanta; }
            set { myTipoPlanta = value; }
        }
        public double pDPrecio
        {
            get { return dPrecio; }
            set { dPrecio = value; }
        }
        public int pIStock
        {
            get { return iStock; }
            set { iStock = value; }
        }
        #endregion
        #region Métodos Constructores
        // Método constructor sin parámetros
        public clsPlantas()
        {
            pICod_Planta = 0;
            pSDescripcion = "";
            pMyTipoPlanta = null;
            pDPrecio = 0;
            pIStock = 0;
        }
        // Método constructor con parámetros
        public clsPlantas(int iId, string sDesc, clsTiposPlantas cTip, double dPre, int iSto)
        {
            pICod_Planta = iId;
            pSDescripcion = sDesc;
            pMyTipoPlanta = cTip;
            pDPrecio = dPre;
            pIStock = iSto;
        }
        #endregion

    }
}
