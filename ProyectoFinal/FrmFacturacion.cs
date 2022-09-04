using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CData;
using CNegocio;
using CNegocio.Repositorios;

namespace ProyectoFinal
{
    public partial class FrmFacturacion : Form
    {
        tblFactura objFact;
        List<tblDetalle> listDetalle = new List<tblDetalle>();
        decimal total = 0;
        public FrmFacturacion()
        {
            InitializeComponent();
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void btnColocar_Click(object sender, EventArgs e)
        {
            tblDetalle Detalle = new tblDetalle();
            var art = ContenedorRepo.GetRepoArticulos().ConsultArticuloByID(Convert.ToInt32(cmbArticulo.SelectedValue));

            //Validaciones
            if (cmbArticulo.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            else if(nudCantidad.Value > art.Cantidad || nudCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad seleccionada es 0 o hay suficientes existencias");
                return;
            }

            else
            {
                //listDetalle = new List<tblDetalle>();

                Detalle.IDarticulo = art.ID;
                Detalle.PrecioArt = art.Precio;
                Detalle.CantidadArt = Convert.ToInt32(nudCantidad.Value);

                total = total +  Convert.ToDecimal(art.Precio) * Convert.ToInt32(nudCantidad.Value);

                listDetalle.Add(Detalle);

                lbxDetalle.Items.Add("Artículo: " + art.NombreArticulo + "   Precio: " + Convert.ToString(art.Precio)
                + "   Cantidad: " + Convert.ToString(nudCantidad.Value));

                nudCantidad.Value = 0;
                cmbArticulo.SelectedIndex = 0;

                lbTotal.Text = "RD$: " + Convert.ToString(total);

            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //Validaciones

            if (txtCodigo.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Se deben llenar el campo de Código y Nombre Facturado");
                return;
            }

            if(listDetalle == null)
            {
                MessageBox.Show("No hay artículos seleccionados");
                return;
            }

            if (objFact == null)
            {
                //Comprobar codigo existente
                if (ContenedorRepo.GetRepoFacturas().ComprobarFactura(txtCodigo.Text.ToUpper()) == true) 
                {
                    MessageBox.Show("El código ya se encuentra registrado");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("¿Desea confirmar la factura?", "Confirmar", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    objFact = new tblFactura();
                    objFact.Codigo = txtCodigo.Text.ToUpper();
                    objFact.NombreFacturado = txtNombre.Text.ToUpper();

                    ContenedorRepo.GetRepoFacturas().InsertFactura(objFact);

                    var LastFactura = ContenedorRepo.GetRepoFacturas().ReturnFactura();

                    ContenedorRepo.GetRepoFacturas().InsertDetalle(LastFactura.ID, listDetalle);

                    Limpiar();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea cancelar la factura?", "Cancelar", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        private void LoadCombo()
        {
            var objA = new tblArticulo { ID = 0, NombreArticulo = "Seleccione" };

            var lista = (from a in ContenedorRepo.GetRepoArticulos().ConsultArticulos()
                         select a).ToList();

            lista.Insert(0, objA);

            cmbArticulo.DataSource = lista;
            cmbArticulo.DisplayMember = "NombreArticulo";
            cmbArticulo.ValueMember = "ID";

            lbTotal.Text = "RD$: ";
        }

        private void Limpiar()
        {
            lbxDetalle.Items.Clear();
            objFact = null;
            listDetalle.Clear();
            nudCantidad.Value = 0;
            cmbArticulo.SelectedIndex = 0;
            lbTotal.Text = "RD$: 0";
            total = 0;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
