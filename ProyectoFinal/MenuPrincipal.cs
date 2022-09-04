using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor fp = new FrmProveedor();
            fp.ShowDialog();
        }

        private void consultarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaProve fcp = new FrmConsultaProve();
            fcp.ShowDialog();
        }

        private void consultaDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaArt fca = new FrmConsultaArt();
            fca.ShowDialog();
        }

        private void gestiónDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulo fa = new FrmArticulo();
            fa.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaInv fci = new FrmConsultaInv();
            fci.ShowDialog();
        }

        private void despacharReabastecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario fi = new FrmInventario();
            fi.ShowDialog();
        }

        private void consultarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaEmpleado fce = new FrmConsultaEmpleado();
            fce.ShowDialog();
        }

        private void gestionarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado fe = new FrmEmpleado();
            fe.ShowDialog();
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaUsuario fcu = new FrmConsultaUsuario();
            fcu.ShowDialog();
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios fu = new FrmUsuarios();
            fu.ShowDialog();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturacion ff = new FrmFacturacion();
            ff.ShowDialog();
        }

        private void consultarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaFact fcf = new FrmConsultaFact();
            fcf.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
