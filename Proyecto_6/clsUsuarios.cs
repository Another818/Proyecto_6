using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_6
{
    class clsUsuarios
    {

        #region Propiedades de la clase
        // Propiedades de la clase
        int iID;
        string sNombre;
        string sContrasenia;
        int iCant_Ingresadas;
        DateTime dUlti_Ingresada;
        DateTime dCreacion;

        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de las propiedades
        public int pIID
        {
            get { return iID; }
            set { iID = value; }
        }

        public string pSNombre
        {
            get { return sNombre; }
            set { sNombre = value; }
        }

        public string pSContrasenia
        {
            get { return sContrasenia; }
            set { sContrasenia = value; }
        }

        public int pICant_Ingresadas 
        {
            get { return iCant_Ingresadas; }
            set { iCant_Ingresadas = value; }
        }

        public DateTime pDUlti_Ingresada
        {
            get { return dUlti_Ingresada; }
            set { dUlti_Ingresada = value; }
        }

        public DateTime pDCreacion
        {
            get { return dCreacion; }
            set { dCreacion = value; }
        }

        #endregion
        #region Métodos constructores de la clase
        // Constructor sin parámetros
        public clsUsuarios()
        {
            pIID = 0;
            pSNombre = "";
            pSContrasenia = "";
            pICant_Ingresadas = 0;
            pDCreacion = pDCreacion;
            pDUlti_Ingresada = pDUlti_Ingresada;
        }

        // Constructor con parámetros
        public clsUsuarios(int iId, string sNom, string sCon, int iCant, DateTime dCre, DateTime dUingre)
        {
            pIID = iId;
            pSNombre = sNom;
            pSContrasenia = sCon;
            pICant_Ingresadas = iCant;
            pDUlti_Ingresada = dUingre;
            pDCreacion = dCre;

        }
        #endregion

    }
}
