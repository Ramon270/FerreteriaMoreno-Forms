using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using CData;
using CNegocio;
using CNegocio.Repositorios;

namespace ProyectoFinal
{
    public partial class FrmProveedor : Form
    {
        tblProveedore obj;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        //Metodo para llenar el combo box de ciudades
        private void FillCombo()
        {
            var lista = ContenedorRepo.GetRepoCiudades().ConsultaCiudades();
            var objP = new tblCiudade { ID = 0, NombreCiudad = "Seleccione" };
            lista.Insert(0, objP);

            cmbCiudades.DataSource = lista;
            cmbCiudades.DisplayMember = "NombreCiudad";
            cmbCiudades.ValueMember = "ID";
        }

        //Metodo para el boton guardar
        private void InsertProve()
        {
            obj.Codigo = txtCodigo.Text;
            obj.NombreProveedor = txtNombreProv.Text;
            obj.IDciudad = Convert.ToInt32(cmbCiudades.ValueMember);
            obj.Telefono = txtTelefono.Text;
            obj.Direccion = txtDireccion.Text;

            ContenedorRepo.GetRepoProveedores().InsertProveedor(obj);
        }

        //Metodo para limpiar el Formulario 
        private void Limpiar()
        {
            foreach (Control c in this.Controls)
            {
                if ((c is TextBox) || (c is MaskedTextBox))
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

        //Metodo para llenar el formulario con un registro seleccionado
        private void LoadFormProve(int Idprov)
        {
            obj = ContenedorRepo.GetRepoProveedores().ConsultProveedorByID(Idprov);

            txtCodigo.Text = obj.Codigo;
            txtNombreProv.Text = obj.NombreProveedor;
            cmbCiudades.SelectedValue = obj.IDciudad;
            txtTelefono.Text = obj.Telefono;
            txtDireccion.Text = obj.Direccion;
        }
        
        //Metodo para insertar un nuevo Proveedor 
        private void Insert()
        {
            obj = new tblProveedore();
            obj.Codigo = (txtCodigo.Text.ToUpper());
            obj.NombreProveedor = (txtNombreProv.Text.ToUpper());
            obj.IDciudad = Convert.ToInt32(cmbCiudades.SelectedValue);
            obj.Telefono = txtTelefono.Text;
            obj.Direccion = txtDireccion.Text;

            ContenedorRepo.GetRepoProveedores().InsertProveedor(obj);
        }

        //Metodo para guardar la nueva informacion del Proveedor seleccionado
        private void UpdateP()
        {
            obj.Codigo = txtCodigo.Text.ToUpper();
            obj.NombreProveedor = (txtNombreProv.Text.ToUpper());
            obj.IDciudad = Convert.ToInt32(cmbCiudades.SelectedValue);
            obj.Telefono = txtTelefono.Text;
            obj.Direccion = txtDireccion.Text;

            ContenedorRepo.GetRepoProveedores().UpdateProveedor(obj);
        }

        //Metodo para eliminar (Cambiar estado) del Proveedor seleccionado
        private void Borrar()
        {
            ContenedorRepo.GetRepoProveedores().DeleteProveedor(obj);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultaProve fcp = new FrmConsultaProve();
            fcp.ShowDialog();

            if (fcp.IDproveedor > 0)
            {
                LoadFormProve(fcp.IDproveedor);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validacion campos vacios
            
            if (txtCodigo.Text == "" || txtNombreProv.Text == "" || txtDireccion.Text == ""
                || txtTelefono.Text == "" || cmbCiudades.SelectedIndex == 0)
            {
                MessageBox.Show("¡Se deben llenar todos los campos!");
                return;
            }

            //Proceso para insertar

            if (obj == null)
            {
                //Validacion codigo repetido
                if (ContenedorRepo.GetRepoProveedores().ComprobarCodigo(txtCodigo.Text) == true)
                {
                    MessageBox.Show("El código ya se encuentra registrado");
                    return;
                }

                Insert();
                MessageBox.Show("Proveedor Insertado");
                Limpiar();
            }

            //Proceso para modificar

            else 
            {
                //Validacion codigo repetido
                if (ContenedorRepo.GetRepoProveedores().ComprobarCodigo(txtCodigo.Text, obj.ID) == true)
                {
                    MessageBox.Show("El código ya se encuentra registrado");
                    return;
                }

                UpdateP();
                MessageBox.Show("Cambios realizados en la información del proveedor");
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
                    MessageBox.Show("Proveedor eliminado");
                    Limpiar();
                }
            }
        }
    }
}
