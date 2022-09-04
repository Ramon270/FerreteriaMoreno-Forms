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
    public partial class FrmInventario : Form
    {
        tblArticulo obj;
        
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultaInv fci = new FrmConsultaInv();
            fci.ShowDialog();

            if (fci.IdArticulo > 0 )
            {
                LoadFormInv(fci.IdArticulo);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (obj == null)
            {
                return;
            }

            else
            {
                UpdateCantidad();
                MessageBox.Show("Cantidad del artículo Modificada");
                Limpiar();
            }
        }
        private void LoadFormInv(int IdArticulo)
        {
            obj = ContenedorRepo.GetRepoArticulos().ConsultArticuloByID(IdArticulo);

            txtCodigo.Text = obj.Codigo;
            txtNombre.Text = obj.NombreArticulo;
            nudDespacho.Maximum = Convert.ToInt32(obj.Cantidad);

        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            nudDespacho.Value = 0;
            nudReabastecer.Value = 0;
            obj = null;
        }

        private void UpdateCantidad()
        {
            obj.Cantidad = obj.Cantidad - Convert.ToInt32(nudDespacho.Value);
            obj.Cantidad = obj.Cantidad + Convert.ToInt32(nudReabastecer.Value);

            ContenedorRepo.GetRepoArticulos().UpdateArticulo(obj);

        }
    }
}
