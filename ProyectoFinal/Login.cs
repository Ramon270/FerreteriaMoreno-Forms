using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio;
using CNegocio.Repositorios;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtContra.Text == "")
            {
                MessageBox.Show("El usuario y la contraseña deben llenarse");
                return;
            }

            ObjetosGlobales.ObjUsuario = ContenedorRepo.GetRepoUsuarios().BuscarUsuario(txtUsername.Text);

            if (ObjetosGlobales.ObjUsuario == null)
            {
                MessageBox.Show("El usuario indicado no existe");
                return;
            }

            else if (ObjetosGlobales.ObjUsuario.Contrasena != txtContra.Text)
            {
                MessageBox.Show("La contraseña es incorrecta");
                return;
            }

            else
            {
                if (ObjetosGlobales.ObjUsuario.Contrasena == txtContra.Text)
                {
                    MenuPrincipal menu = new MenuPrincipal();

                    var posicion = (from p in ContenedorRepo.GetRepoEmpleados().ConsultaEmpleados()
                                    where p.ID == ObjetosGlobales.ObjUsuario.IDempleado
                                    select p.IDposicion).SingleOrDefault();

                    switch (posicion)
                    {
                        case 1:
                            {
                                txtContra.Text = "";
                                menu.ShowDialog();
                                break;
                            }

                        case 3:
                            {
                                menu.proveedoresToolStripMenuItem.Enabled = false;
                                menu.facturaciónToolStripMenuItem.Enabled = false;
                                menu.empleadosToolStripMenuItem.Enabled = false;
                                menu.usuariosToolStripMenuItem.Enabled = false;
                                menu.reportesToolStripMenuItem.Enabled = false;
                                txtContra.Text = "";
                                menu.ShowDialog();
                                break;
                            }

                        case 4:
                            {
                                menu.proveedoresToolStripMenuItem.Enabled = false;
                                menu.usuariosToolStripMenuItem.Enabled = false;
                                menu.empleadosToolStripMenuItem.Enabled = false;
                                menu.reportesToolStripMenuItem.Enabled = false;
                                menu.consultaDeArtículosToolStripMenuItem.Enabled = false;
                                menu.gestiónDeArtículosToolStripMenuItem.Enabled = false;
                                menu.despacharReabastecerToolStripMenuItem.Enabled = false;
                                txtContra.Text = "";
                                menu.ShowDialog();
                                break;
                            }

                        case 5:
                            {
                                menu.artículosToolStripMenuItem.Enabled = false;
                                menu.proveedoresToolStripMenuItem.Enabled = false;
                                menu.empleadosToolStripMenuItem.Enabled = false;
                                menu.usuariosToolStripMenuItem.Enabled = false;
                                menu.facturaciónToolStripMenuItem.Enabled = false;
                                txtContra.Text = "";
                                menu.ShowDialog();
                                break;
                            }
                    }
                }
            }
        }

        private void btnCancelat_Click(object sender, EventArgs e)
        {
            txtContra.Text = "";
            txtUsername.Text = "";
        }
    }
}
