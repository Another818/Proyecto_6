using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsClientes
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iCod_Cliente;
        string sApellido;
        string sNombre;
        clsCalles myCalle;
        string sAltura;
        clsBarrios myBarrio;
        clsLocalidades myLocalidad;
        clsProvincias myProvincia;
        clsCondicionesIva myCondicionIva;
        string sTelefono;
        string sCuit;
        int iDeudor;
        string sEmail;
        double dSaldo;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de todas las propiedades
        public int pICod_Cliente
        {
        get { return iCod_Cliente; }
        set { iCod_Cliente = value; }
        }
        public string pSApellido
        {
        get { return sApellido; }
        set { sApellido = value; }
        }
        public string pSNombre
        {
        get { return sNombre; }
        set { sNombre = value; }
        }
        internal clsCalles pMyCalle
        {
        get { return myCalle; }
        set { myCalle = value; }
        }
        public string pSAltura
        {
        get { return sAltura; }
        set { sAltura = value; }
        }
        internal clsBarrios pMyBarrio
        {
        get { return myBarrio; }
        set { myBarrio = value; }
        }
        internal clsLocalidades pMyLocalidad
        {
        get { return myLocalidad; }
        set { myLocalidad = value; }
        }
        internal clsProvincias pMyProvincia
        {
        get { return myProvincia; }
        set { myProvincia = value; }
        }
        public string pSTelefono
        {
        get { return sTelefono; }
        set { sTelefono = value; }
        }
        internal clsCondicionesIva pMyCondicionesIva
        {
        get { return myCondicionIva; }
        set { myCondicionIva = value; }
        }
        public string pSCuit
        {
        get { return sCuit; }
        set { sCuit = value; }
        }
        public int pIDeudor
        {
        get { return iDeudor; }
        set { iDeudor = value; }
        }
        public string pSEmail
        {
        get { return sEmail; }
        set { sEmail = value; }
        }
        public double pDSaldo
        {
            get { return dSaldo; }
            set { dSaldo = value; }
        }
        #endregion
        #region Métodos Constructores
        // Método constructor sin parámetros
        public clsClientes()
        {
        pICod_Cliente = 0;
        pSApellido = "";
        pSNombre = "";
        pMyCalle = null;
        pSAltura = "";
        pMyBarrio = null;
        pMyLocalidad = null;
        pMyProvincia = null;
        pSTelefono = "";
        pMyCondicionesIva = null;
        pSCuit = "";
        pIDeudor = 0;
        pSEmail = "";
        pDSaldo = 0;
        }
        // Método constructor con parámetros
        public clsClientes(int iId, string sApe, string sNom, clsCalles cCe, 
        string sAlt, clsBarrios cBa, clsLocalidades cLoc, clsProvincias cPro, string sTel, 
        clsCondicionesIva cCi, string sCuit, int iDeu, string sEmail, double dSal)
        {
        pICod_Cliente = iId;
        pSApellido = sApe;
        pSNombre = sNom;
        pMyCalle = cCe;
        pSAltura = sAlt;
        pMyBarrio = cBa;
        pMyLocalidad = cLoc;
        pMyProvincia = cPro;
        pSTelefono = sTel;
        pMyCondicionesIva = cCi;
        pSCuit = sCuit;
        pIDeudor = iDeu;
        pSEmail = sEmail;
        pDSaldo = dSal;

        }
        #endregion

    }
}
