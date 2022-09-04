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
    public partial class FrmConsultaEmpleado : Form
    {
        public int IdEmpleado;
        public FrmConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void FrmConsultaEmpleado_Load(object sender, EventArgs e)
        {
            FillGrid();
        }


        private void FillGrid()
        {
            var lista = (from e in ContenedorRepo.GetRepoEmpleados().ConsultaEmpleados()
                         select new
                         {
                            ID = e.ID,
                            Codigo = e.Codigo,
                            Posicion = e.tblPosicione.NombrePosicion,
                            Nombre = e.Nombre,
                            Apellidos = e.Apellidos,
                            Cedula = e.Cedula,
                            Sexo = e.Sexo,
                            FechaNacimiento = e.FechaNacimiento,
                            Ciudad = e.tblCiudade.NombreCiudad,
                            Direccion = e.Direccion,
                            Telefono = e.Telefono,
                            FechaRegistro = e.FechaRegistro
                         }).ToList();

            dtgEmpleados.DataSource = lista;
            dtgEmpleados.Columns[0].Visible = false;
        }

        private void FillGridByCedula()
        {
            var lista = (from e in ContenedorRepo.GetRepoEmpleados().ConsultaEmpleadoByCedula(txtCedula.Text)
                         select new
                         {
                             ID = e.ID,
                             Codigo = e.Codigo,
                             Posicion = e.tblPosicione.NombrePosicion,
                             Nombre = e.Nombre,
                             Apellidos = e.Apellidos,
                             Cedula = e.Cedula,
                             Sexo = e.Sexo,
                             FechaNacimiento = e.FechaNacimiento,
                             Ciudad = e.tblCiudade.NombreCiudad,
                             Direccion = e.Direccion,
                             Telefono = e.Telefono,
                             FechaRegistro = e.FechaRegistro
                         }).ToList();

            dtgEmpleados.DataSource = lista;
            dtgEmpleados.Columns[0].Visible = false;
        }

        private void FillGridByCodigo()
        {
            var lista = (from e in ContenedorRepo.GetRepoEmpleados().ConsultaEmpleadoByCode(txtCodigo.Text)
                         select new
                         {
                             ID = e.ID,
                             Codigo = e.Codigo,
                             Posicion = e.tblPosicione.NombrePosicion,
                             Nombre = e.Nombre,
                             Apellidos = e.Apellidos,
                             Cedula = e.Cedula,
                             Sexo = e.Sexo,
                             FechaNacimiento = e.FechaNacimiento,
                             Ciudad = e.tblCiudade.NombreCiudad,
                             Direccion = e.Direccion,
                             Telefono = e.Telefono,
                             FechaRegistro = e.FechaRegistro
                         }).ToList();

            dtgEmpleados.DataSource = lista;
            dtgEmpleados.Columns[0].Visible = false;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            FillGridByCedula();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            FillGridByCodigo();
        }

        private void dtgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdEmpleado = Convert.ToInt32(dtgEmpleados[0, dtgEmpleados.CurrentRow.Index].Value);
            this.Close();
        }

        private void dtgEmpleados_DataSourceChanged(object sender, EventArgs e)
        {
            lbRegistros.Text = "Registros: " + dtgEmpleados.RowCount;
        }
    }
}
