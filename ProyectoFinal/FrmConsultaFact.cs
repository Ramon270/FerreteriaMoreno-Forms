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
    public partial class FrmConsultaFact : Form
    {

        public FrmConsultaFact()
        {
            InitializeComponent();
        }

        private void FrmConsultaFact_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            var lista = (from f in ContenedorRepo.GetRepoFacturas().ConsultaFactura()
                         select new
                         {
                             ID = f.ID,
                             Codigo = f.Codigo,
                             Facturado = f.NombreFacturado,
                             Fecha = f.Fecha,
                         }).ToList();

            dtgFacturas.DataSource = lista;
            dtgFacturas.Columns[0].Visible = false;
        }

        private void FillGridByCode()
        {
            var lista = (from f in ContenedorRepo.GetRepoFacturas().ConsultaFacturaByCode(txtCodigo.Text)
                         select new
                         {
                             ID = f.ID,
                             Codigo = f.Codigo,
                             Facturado = f.NombreFacturado,
                             Fecha = f.Fecha,
                         }).ToList();

            dtgFacturas.DataSource = lista;
            dtgFacturas.Columns[0].Visible = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            FillGridByCode();
        }

        private void dtgFacturas_DataSourceChanged(object sender, EventArgs e)
        {
            lbRegistros.Text = "Registros: " + dtgFacturas.RowCount;
        }

        private void dtgFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmDetalle fd = new FrmDetalle();

            fd.IDfactura = Convert.ToInt32(dtgFacturas[0, dtgFacturas.CurrentRow.Index].Value);
            fd.ShowDialog();
            FillGrid();
        }
    }
}
