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
    public partial class FrmConsultaArt : Form
    {
        public int IdArticulo = 0;
        public FrmConsultaArt()
        {
            InitializeComponent();
        }

        private void FrmConsultaArt_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            FillGridByCode();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            FillGridByName();
        }

        private void dtgArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdArticulo = Convert.ToInt32(dtgArticulos[0, dtgArticulos.CurrentRow.Index].Value);
            this.Close();
        }

        private void dtgArticulos_DataSourceChanged(object sender, EventArgs e)
        {
            lbRegistros.Text = "Registros: " + dtgArticulos.RowCount;
        }

        private void FillGrid()
        {
            var lista = (from a in ContenedorRepo.GetRepoArticulos().ConsultArticulos()
                         select new
                         {
                             ID = a.ID,
                             Codigo = a.Codigo,
                             Nombre = a.NombreArticulo,
                             Descripcion = a.Descripcion,
                             Precio = "RD$ " + a.Precio,
                             Proveedor = a.tblProveedore.NombreProveedor
                         }).ToList();

            dtgArticulos.DataSource = lista;
            dtgArticulos.Columns[0].Visible = false;
        }

        private void FillGridByCode()
        {
            var lista = (from a in ContenedorRepo.GetRepoArticulos().ConsultArticuloByCode(txtCodigo.Text)
                         select new
                         {
                             ID = a.ID,
                             Codigo = a.Codigo,
                             Nombre = a.NombreArticulo,
                             Descripcion = a.Descripcion,
                             Precio = "RD$ " + a.Precio,
                             Proveedor = a.tblProveedore.NombreProveedor
                         }).ToList();

            dtgArticulos.DataSource = lista;
            dtgArticulos.Columns[0].Visible = false;
        }

        private void FillGridByName()
        {
            var lista = (from a in ContenedorRepo.GetRepoArticulos().ConsultArticuloByName(txtNombre.Text)
                         select new
                         {
                             ID = a.ID,
                             Codigo = a.Codigo,
                             Nombre = a.NombreArticulo,
                             Descripcion = a.Descripcion,
                             Precio = "RD$ " + a.Precio,
                             Proveedor = a.tblProveedore.NombreProveedor
                         }).ToList();

            dtgArticulos.DataSource = lista;
            dtgArticulos.Columns[0].Visible = false;
        }

    }
}
