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
    public partial class FrmConsultaProve : Form
    {
        public int IDproveedor = 0;
        public FrmConsultaProve()
        {
            InitializeComponent();
        }

        private void FrmConsultaProve_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            var lista = (from p in ContenedorRepo.GetRepoProveedores().ConsultProveedores()
                         select new
                         {
                             ID = p.ID,
                             Codigo = p.Codigo,
                             Nombre = p.NombreProveedor,
                             Telefono = p.Telefono,
                             Ciudad = p.tblCiudade.NombreCiudad,
                             Direccion = p.Direccion }).ToList();

            dtgProveedores.DataSource = lista;
            dtgProveedores.Columns[0].Visible = false;
        }

        private void FillGridByCode()
        {
            var lista = (from p in ContenedorRepo.GetRepoProveedores().ConsultProveedorByCode(txtCodigo.Text)
                         select new
                         {
                             ID = p.ID,
                             Codigo = p.Codigo,
                             Nombre = p.NombreProveedor,
                             Telefono = p.Telefono,
                             Ciudad = p.tblCiudade.NombreCiudad,
                             Direccion = p.Direccion
                         }).ToList();

            dtgProveedores.DataSource = lista;
            dtgProveedores.Columns[0].Visible = false;
        }

        //Este evento contabiliza los registros del DataGridView y modifica el label en funcion de este
        private void dtgProveedores_DataSourceChanged(object sender, EventArgs e)
        {
            lbRegistros.Text = "Registros: " + dtgProveedores.RowCount;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            FillGridByCode();
        }

        //Este evento almacena el ID del registro seleccionado en la viariable IDproveedor y cierra el formulario
        private void dtgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDproveedor = Convert.ToInt32(dtgProveedores[0, dtgProveedores.CurrentRow.Index].Value);
            this.Close();
        }
    }
}
