using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_6
{
    class clsFacturas
    {
        #region Propiedades de la clase
        // Propiedades de la clase
        int iNro_Factura;
        int iClave;
        double dSaldo;
        double dPagado;
        double dTotal;
        int ipago;
        DateTime dFecha;
        clsFormasPago myFormaPago;
        clsClientes myCliente;
        #endregion
        #region Encapsulado de las propiedades
        // Encapsulado de todas las propiedades
        public int pINro_Factura
        {
        get { return iNro_Factura; }
        set { iNro_Factura = value; }
        }
        public int pIClave
        {
            get { return iClave; }
            set { iClave = value; }
        }
        public double pDSaldo
        {
            get { return dSaldo; }
            set { dSaldo = value; }
        }
        public double pDTotal
        {
            get { return dTotal; }
            set { dTotal = value; }
        }
        public int pIPago
        {
            get { return ipago; }
            set { ipago = value; }
        }
        public double pDPagado
        {
            get { return dPagado; }
            set { dPagado = value; }
        }
        public DateTime pDFecha
        {
        get { return dFecha; }
        set { dFecha = value; }
        }
        internal clsFormasPago pMyFormaPago
        {
        get { return myFormaPago; }
        set { myFormaPago = value; }
        }
        internal clsClientes pMyCliente
        {
        get { return myCliente; }
        set { myCliente = value; }
        }
        #endregion
        #region Métodos Constructores
        // Método constructor sin parámetros
        public clsFacturas()
        {
        pINro_Factura = 0;
        pIClave = 0;
        pDFecha = pDFecha;
        pDPagado = 0;
        pDSaldo = 0;
        pDTotal = 0;
        ipago = 0;
        pMyFormaPago = null;
        pMyCliente = null;
        }
        // Método constructor con parámetros
        public clsFacturas(int iId, int iCla, DateTime dFa , clsFormasPago cFP, double dPa, double dSa, double dTo, int iPa, clsClientes cCli)
        {
        pINro_Factura = iId;
        pIClave = iCla;
        pDFecha = dFa;
        pMyFormaPago = cFP;
        pDPagado = dPa;
        pDSaldo = dSa;
        pDTotal = dTo;
        ipago = iPa;
        pMyCliente = cCli;
        }
        #endregion

    }
}
