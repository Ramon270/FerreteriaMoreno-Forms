using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CNegocio.Repositorios
{
    public static class ContenedorRepo
    {
        public static RepoCiudades GetRepoCiudades()
        {
            return new RepoCiudades();
        }

        public static RepoProveedores GetRepoProveedores()
        {
            return new RepoProveedores();
        }

        public static RepoArticulos GetRepoArticulos()
        {
            return new RepoArticulos();
        }

        public static RepoPosiciones GetRepoPosiciones()
        {
            return new RepoPosiciones();
        }

        public static RepoEmpleados GetRepoEmpleados()
        {
            return new RepoEmpleados();
        }

        public static RepoUsuarios GetRepoUsuarios()
        {
            return new RepoUsuarios();
        }

        public static RepoFacturas GetRepoFacturas()
        {
            return new RepoFacturas();
        }
    }
}
