using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class FrmEmpleado : Form
    {
        tblEmpleado obj;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (obj != null)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro?", btnEliminar.Text, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Borrar();
                    MessageBox.Show("Empleado eliminado");
                    Limpiar();
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones

            //Campos vacios
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellidos.Text == ""
                || txtTelefono.Text == "" || cmbCiudades.SelectedIndex == 0 || cmbPosicion.SelectedIndex ==0
                || txtCedula.Text == "" || txtDireccion.Text == "" )
            {
                MessageBox.Show("¡Se deben llenar todos los campos!");
                return;
            }

            //Validacion Caracteres de cedula
            if(txtCedula.Text.Replace(" ", "").Length < 13)
            {
                MessageBox.Show("¡La cédula no tiene la cantidad de carácteres correcta!");
                return;
            }

            if( (DateTime.Now.Subtract(dtpFechaNace.Value).TotalDays)/ 365 < 18)
            {
                MessageBox.Show("La persona que intenta registrar es menor de edad o la fecha de nacimiento es incorrecta");
                return;
            } 

            //Proceso para insertar
            if (obj == null)
            {
                //Validacion codigo y cedula repetida
                if (ContenedorRepo.GetRepoEmpleados().ComprobarCodigo(txtCodigo.Text) == true)
                {
                    MessageBox.Show("El código ya se encuentra registrado");
                    return;
                }

                if (ContenedorRepo.GetRepoEmpleados().ComprobarCedula(txtCedula.Text) == true)
                {
                    MessageBox.Show("La cédula ya se encuentra registrada");
                    return;
                }

                Insert();
                MessageBox.Show("Empleado Registrado");
                Limpiar();
            }

            //Proceso para actualizar informacion
            else
            {
                //Validacion codigo y cedula repetida
                if (ContenedorRepo.GetRepoEmpleados().ComprobarCodigo(txtCodigo.Text, obj.ID) == true)
                {
                    MessageBox.Show("El código ya se encuentra registrado");
                    return;
                }

                if (ContenedorRepo.GetRepoEmpleados().ComprobarCedula(txtCedula.Text, obj.ID) == true)
                {
                    MessageBox.Show("El código ya se encuentra registrado");
                    return;
                }

                UpdateE();
                MessageBox.Show("Cambios realizados en la información del artículo");
                Limpiar();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultaEmpleado fce = new FrmConsultaEmpleado();
            fce.ShowDialog();

            if (fce.IdEmpleado > 0)
            {
                LoadFormEmpleados(fce.IdEmpleado);
            }
        }


        private void LoadCombo()
        {
            var listC = ContenedorRepo.GetRepoCiudades().ConsultaCiudades();
            var objC = new tblCiudade { ID = 0, NombreCiudad = "Seleccione" };

            listC.Insert(0, objC);
            cmbCiudades.DataSource = listC;
            cmbCiudades.DisplayMember = "NombreCiudad";
            cmbCiudades.ValueMember = "ID";

            var listP = ContenedorRepo.GetRepoPosiciones().ConsultaPosiciones();
            var objP = new tblPosicione { ID = 0, NombrePosicion = "Seleccione" };

            listP.Insert(0, objP);
            cmbPosicion.DataSource = listP;
            cmbPosicion.DisplayMember = "NombrePosicion";
            cmbPosicion.ValueMember = "ID";
        }

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

                else if(c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
            }

            obj = null;
        }

        private void LoadFormEmpleados(int IdEmpleado)
        {
            obj = ContenedorRepo.GetRepoEmpleados().ConsultaEmpleadoByID(IdEmpleado);

            txtCodigo.Text = obj.Codigo;
            txtNombre.Text = obj.Nombre;
            txtApellidos.Text = obj.Apellidos;
            txtCedula.Text =  obj.Cedula;
            txtDireccion.Text = obj.Direccion;
            rbFemenino.Checked = obj.Sexo == 'F' ? true : false;
            rbMasculino.Checked = obj.Sexo == 'M' ? true : false;
            dtpFechaNace.Value = Convert.ToDateTime(obj.FechaNacimiento);
            txtTelefono.Text = obj.Telefono;
            cmbCiudades.SelectedValue = Convert.ToInt32(obj.IDciudad);
            cmbPosicion.SelectedValue = Convert.ToInt32(obj.IDposicion); 
        }


        private void Borrar()
        {
            ContenedorRepo.GetRepoEmpleados().DeleteEmpleado(obj);
        }

        private void Insert()
        {
            obj = new tblEmpleado();

            obj.Codigo = txtCodigo.Text.ToUpper();
            obj.Nombre = txtNombre.Text.ToUpper();
            obj.Apellidos = txtApellidos.Text.ToUpper();
            obj.Cedula = txtCedula.Text;
            obj.Sexo = rbFemenino.Checked == true ? 'F' : 'M';
            obj.IDciudad = Convert.ToInt32(cmbCiudades.SelectedValue);
            obj.IDposicion = Convert.ToInt32(cmbPosicion.SelectedValue);
            obj.Direccion = txtDireccion.Text;
            obj.FechaNacimiento = dtpFechaNace.Value;
            obj.Telefono = txtTelefono.Text;

            ContenedorRepo.GetRepoEmpleados().InsertEmpleado(obj);
        }

        private void UpdateE()
        {
            obj.Codigo = txtCodigo.Text.ToUpper();
            obj.Nombre = txtNombre.Text.ToUpper();
            obj.Apellidos = txtApellidos.Text.ToUpper();
            obj.Cedula = txtCedula.Text;
            obj.Sexo = rbFemenino.Checked == true ? 'F' : 'M';
            obj.IDciudad = Convert.ToInt32(cmbCiudades.SelectedValue);
            obj.IDposicion = Convert.ToInt32(cmbPosicion.SelectedValue);
            obj.Direccion = txtDireccion.Text;
            obj.FechaNacimiento = dtpFechaNace.Value;
            obj.Telefono = txtTelefono.Text;

            ContenedorRepo.GetRepoEmpleados().UpdateEmpleado(obj);
        }
    }
}
