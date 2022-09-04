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
    public partial class FrmConsultaInv : Form
    {
        public int IdArticulo = 0;
        public FrmConsultaInv()
        {
            InitializeComponent();
        }

        private void FrmConsultaInv_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            var lista = (from a in ContenedorRepo.GetRepoArticulos().ConsultArticulos()
                         select new
                         {
                             ID = a.ID,
                             Codigo = a.Codigo,
                             Nombre = a.NombreArticulo,
                             Precio = "RD$ " + a.Precio,
                             Cantidad = a.Cantidad,
                             Proveedor = a.tblProveedore.NombreProveedor
                         }).ToList();

            dtgInventario.DataSource = lista;
            dtgInventario.Columns[0].Visible = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            FillGridByCode();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            FillGridByName();
        }

        private void FillGridByCode()
        {
            var lista = (from a in ContenedorRepo.GetRepoArticulos().ConsultArticuloByCode(txtCodigo.Text)
                         select new
                         {
                             ID = a.ID,
                             Codigo = a.Codigo,
                             Nombre = a.NombreArticulo,
                             Precio = "RD$ " + a.Precio,
                             Cantidad = a.Cantidad,
                             Proveedor = a.tblProveedore.NombreProveedor
                         }).ToList();

            dtgInventario.DataSource = lista;
            dtgInventario.Columns[0].Visible = false;
        }

        private void FillGridByName()
        {
            var lista = (from a in ContenedorRepo.GetRepoArticulos().ConsultArticuloByName(txtNombre.Text)
                         select new
                         {
                             ID = a.ID,
                             Codigo = a.Codigo,
                             Nombre = a.NombreArticulo,
                             Precio = "RD$ " + a.Precio,
                             Cantidad = a.Cantidad,
                             Proveedor = a.tblProveedore.NombreProveedor
                         }).ToList();

            dtgInventario.DataSource = lista;
            dtgInventario.Columns[0].Visible = false;
        }

        private void dtgInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdArticulo = Convert.ToInt32(dtgInventario[0, dtgInventario.CurrentRow.Index].Value);
            this.Close();
        }
    }
}
