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
    public partial class FrmArticulo : Form
    {
        tblArticulo obj;
       
        public FrmArticulo()
        {
            InitializeComponent();
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultaArt fca = new FrmConsultaArt();
            fca.ShowDialog();

            if (fca.IdArticulo > 0)
            {
                LoadFormArticulo(fca.IdArticulo);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validacion campos vacios
            if ( txtCodigo.Text == "" || txtNombreArt.Text == "" || txtDescripcion.Text == ""
                || txtPrecio.Text == "" || cmbProveedores.SelectedIndex == 0 )
            {
                MessageBox.Show("¡Se deben llenar todos los campos!");
                return;
            }


            try
            {
                Convert.ToDecimal(txtPrecio.Text);
            }

            catch
            {
                MessageBox.Show("El precio debe ser un numero");
                return;
            }
            
          

            //Proceso para insertar
            if (obj == null)
            {
                //Validacion codigo repetido
                if (ContenedorRepo.GetRepoArticulos().ComprobarCodigo(txtCodigo.Text.ToUpper()) == true)
                {
                    MessageBox.Show("El código ya se encuentra registrado");
                    return;
                }

                Insert();
                MessageBox.Show("Artículo Insertado");
                Limpiar();
            }

            //Proceso para actualizar informacion
            else
            {
                //Validacion codigo repetido
                if (ContenedorRepo.GetRepoArticulos().ComprobarCodigo(txtCodigo.Text.ToUpper(),obj.ID) == true)
                {
                    MessageBox.Show("El código ya se encuentra registrado");
                    return;
                }
                UpdateA();
                MessageBox.Show("Cambios realizados en la información del artículo");
                Limpiar();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro?", btnEliminar.Text, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Borrar();
                    MessageBox.Show("Articulo eliminado");
                    Limpiar();
                }
            }
        }

        //Metodo para llenar el combo box Proveedores
        private void FillCombo()
        {
            var lista = (from p in ContenedorRepo.GetRepoProveedores().ConsultProveedores()
                         select p).ToList();

            var objA = new tblProveedore { ID = 0, NombreProveedor = "Seleccione" };
            lista.Insert(0, objA);

            cmbProveedores.DataSource = lista;
            cmbProveedores.DisplayMember = "NombreProveedor";
            cmbProveedores.ValueMember = "ID";
        }

        //Metodo para llenar el formulario con la informacion del articulo seleccionado
        private void LoadFormArticulo(int IdArticulo)
        {
           
             obj = ContenedorRepo.GetRepoArticulos().ConsultArticuloByID(IdArticulo);

            txtCodigo.Text = obj.Codigo;
            txtNombreArt.Text = obj.NombreArticulo;
            cmbProveedores.SelectedValue = obj.IDproveedor;
            txtPrecio.Text = Convert.ToString(obj.Precio);
            txtDescripcion.Text = obj.Descripcion;
        }

        //Metodo para limpiar el formulario
        private void Limpiar()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
            }
            obj = null;
        }

        //Metodo para insertar un nuevo articulo
        private void Insert()
        {
            obj = new tblArticulo();
            obj.Codigo = txtCodigo.Text.ToUpper();
            obj.NombreArticulo = txtNombreArt.Text.ToUpper();
            obj.IDproveedor = Convert.ToInt32(cmbProveedores.SelectedValue);
            obj.Precio = Convert.ToDecimal(txtPrecio.Text);
            obj.Descripcion = txtDescripcion.Text;

            ContenedorRepo.GetRepoArticulos().InsertArticulo(obj);
        }

        //Metodo para actualizar informacion del articulo seleccionado
        private void UpdateA()
        {
            obj.Codigo = txtCodigo.Text.ToUpper();
            obj.NombreArticulo = txtNombreArt.Text.ToUpper();
            obj.IDproveedor = Convert.ToInt32(cmbProveedores.SelectedValue);
            obj.Precio = Convert.ToDecimal(txtPrecio.Text);
            obj.Descripcion = txtDescripcion.Text;

            ContenedorRepo.GetRepoArticulos().UpdateArticulo(obj);
        }

        //Metodo para eliminar el articulo seleccionado
        private void Borrar()
        {
            ContenedorRepo.GetRepoArticulos().DeleteArticulo(obj);
        }
    }
}
