using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CData;
using CNegocio;
using CNegocio.Repositorios;

namespace ProyectoFinal
{
    public partial class FrmDetalle : Form
    {
        public int IDfactura = 0;
        public FrmDetalle()
        {
            InitializeComponent();
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            var lista = (from d in ContenedorRepo.GetRepoFacturas().ConsultaDetalle(IDfactura)
                         select new
                         {
                             Articulo = d.tblArticulo.NombreArticulo,
                             Precio = d.PrecioArt,
                             Cantidad = d.CantidadArt,
                             Factura = d.tblFactura.Codigo
                         }).ToList();

            dtgDetalle.DataSource = lista;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea anular la factura?", "Anular", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ContenedorRepo.GetRepoFacturas().EliminarFactura(IDfactura);
                this.Close();
            }
        }
    }
}
