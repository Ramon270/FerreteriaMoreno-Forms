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
    public partial class FrmUsuarios : Form
    {
        tblUsuario obj;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultaUsuario fcu = new FrmConsultaUsuario();
            fcu.ShowDialog();

            if(fcu.IdUsuario > 0)
            {
                LoadFormUser(fcu.IdUsuario);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtContra.Text == "" || txtUsername.Text == "" || cmbCedula.SelectedIndex == 0)
            {
                MessageBox.Show("¡Se deben llenar todos los campos!");
                return;
            }

            if (obj == null)
            {
                if(ContenedorRepo.GetRepoUsuarios().ConsultarUser(txtUsername.Text) == true)
                {
                    MessageBox.Show("El nombre de usuario ya se encuentra registrado");
                    return;
                }

                Insert();
                MessageBox.Show("Usuario agregado");
                Limpiar();
            }

            else
            {
                if (ContenedorRepo.GetRepoUsuarios().ConsultarUser(txtUsername.Text, obj.ID) == true)
                {
                    MessageBox.Show("El nombre de usuario ya se encuentra registrado");
                    return;
                }

                UpdateU();
                MessageBox.Show("La información fue modificada con éxito");
                Limpiar();
            }
        }

        private void LoadCombo()
        {
            var objC = new tblEmpleado { ID = 0, Cedula = "Seleccione" };
            var lista = ContenedorRepo.GetRepoEmpleados().ConsultaEmpleados();

            lista.Insert(0, objC);

            cmbCedula.DataSource = lista;
            cmbCedula.DisplayMember = "Cedula";
            cmbCedula.ValueMember = "ID";
        }

        private void Borrar()
        {
            ContenedorRepo.GetRepoUsuarios().DeleteUser(obj);
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
            }

            obj = null;
        }

        //Metodo para llenar el formulario con un registro seleccionado
        private void LoadFormUser(int Iduser)
        {
            obj = ContenedorRepo.GetRepoUsuarios().ConsultaUsuarioById(Iduser);

            txtUsername.Text = obj.UserName;
            txtContra.Text = obj.Contrasena;
            cmbCedula.SelectedValue = obj.IDempleado;
        }

        //Metodo para insertar un nuevo Usuario
        private void Insert()
        {
            obj = new tblUsuario();

            obj.UserName = txtUsername.Text;
            obj.Contrasena = txtContra.Text;
            obj.IDempleado = Convert.ToInt32(cmbCedula.SelectedValue);

            ContenedorRepo.GetRepoUsuarios().InsertUser(obj);
        }

        //Metodo para guardar la nueva informacion del Usuario seleccionado
        private void UpdateU()
        {
            obj.UserName = txtUsername.Text;
            obj.Contrasena = txtContra.Text;
            ContenedorRepo.GetRepoUsuarios().UpdateUser(obj);
        }
    }
}
