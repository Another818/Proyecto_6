using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_6
{
    public partial class frmMenú : Form
    {
        public frmMenú()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierro el formulario
            this.Close();
        }

        private void clientes1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes myForm = new frmClientes();
            myForm.ShowDialog();
        }

        private void plantasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlantas myForm = new frmPlantas();
            myForm.ShowDialog();
        }

        private void tiposDePlantasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTipoPlanta myForm = new frmTipoPlanta();
            myForm.ShowDialog();
        }

        private void condicionesIvaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCondicionesIva myForm = new frmCondicionesIva();
            myForm.ShowDialog();
        }

        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalidades myForm = new frmLocalidades();
            myForm.ShowDialog();
        }

        private void formasDePagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFormasPago myForm = new frmFormasPago();
            myForm.ShowDialog();
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarrios myForm = new frmBarrios();
            myForm.ShowDialog();
        }

        private void callesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalles myForm = new frmCalles();
            myForm.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas myForm = new frmFacturas();
            myForm.ShowDialog();
        }

    }
}
