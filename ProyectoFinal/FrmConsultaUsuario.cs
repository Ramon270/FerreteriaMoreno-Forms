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
    public partial class FrmConsultaUsuario : Form
    {

        public int IdUsuario;
        public FrmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void FrmConsultaUsuario_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            FillGridByNombre();
        }

        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUsuario = Convert.ToInt32(dtgUsuarios[0, dtgUsuarios.CurrentRow.Index].Value);
            this.Close();
        }

        private void dtgUsuarios_DataSourceChanged(object sender, EventArgs e)
        {
            lbRegistros.Text = "Registros: " + dtgUsuarios.RowCount;
        }

        private void FillGrid()
        {
            var list = (from u in ContenedorRepo.GetRepoUsuarios().ConsultaUsuarios()
                        select new
                        {
                            ID = u.ID,
                            Username = u.UserName,
                            CedulaEmpleado = u.tblEmpleado.Cedula
                        }).ToList();

            dtgUsuarios.DataSource = list;
            dtgUsuarios.Columns[0].Visible = false;
        }

        private void FillGridByNombre()
        {
            var list = (from u in ContenedorRepo.GetRepoUsuarios().ConsultaUsuariosByName(txtUsername.Text)
                        select new
                        {
                            ID = u.ID,
                            Username = u.UserName,
                            Password = u.Contrasena,
                            CedulaEmpleado = u.tblEmpleado.Cedula
                        }).ToList();

            dtgUsuarios.DataSource = list;
            dtgUsuarios.Columns[0].Visible = false;
        }
    }
}
