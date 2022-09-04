using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CNegocio.Repositorios
{
    public class RepoProveedores
    {
        DataClasses1DataContext context;
        public RepoProveedores()
        {
            ContextRefresh();
        }

        //Metodo para insertar proveedores
        public void InsertProveedor(tblProveedore prove)
        {
            ContextRefresh();
            prove.IDestado = 1;
            context.tblProveedores.InsertOnSubmit(prove);
            context.SubmitChanges();
        }

        //Metodo para consultar todos los proveedores
        public List<tblProveedore> ConsultProveedores()
        {
            ContextRefresh();
            var result = (from p in context.tblProveedores
                          where p.IDestado == 1
                          select p).ToList();

            return result;
        }

        //Metodo para consultar proveedores por su codigo
        public List<tblProveedore> ConsultProveedorByCode(string codigo)
        {
            ContextRefresh();
            var result = (from p in context.tblProveedores
                       where p.Codigo.Contains(codigo) && p.IDestado == 1
                       select p).ToList();

            return result;
        }

        //Metodo para consultar proveedores por ID
        public tblProveedore ConsultProveedorByID(int id)
        {
            ContextRefresh();
            var obj = (from p in context.tblProveedores
                       where p.ID == id
                       select p).SingleOrDefault();

            return obj;
        }

        //Metodo para eliminar proveedor (cambiar estado)
        public void DeleteProveedor(tblProveedore prove)
        {
            ContextRefresh();
            var obj = (from p in context.tblProveedores
                       where p.ID == prove.ID
                       select p).SingleOrDefault();
            obj.IDestado = 2;
            context.SubmitChanges();
        }

        //Metodo para modificar informacion proveedor
        public void UpdateProveedor(tblProveedore prove)
        {
            ContextRefresh();

            var obj = (from p in context.tblProveedores
                       where p.ID == prove.ID
                       select p).SingleOrDefault();

            obj.Codigo = prove.Codigo;
            obj.NombreProveedor = prove.NombreProveedor;
            obj.IDciudad = prove.IDciudad;
            obj.Telefono = prove.Telefono;
            obj.Direccion = prove.Direccion;

            context.SubmitChanges();
        }

        //Metodo para comprobar codigo
        public bool ComprobarCodigo(string codigo, int IdProve = 0)
        {
            ContextRefresh();
            bool result;
            if (IdProve == 0)
            {
                result = context.tblProveedores.ToList().Exists(x => x.Codigo == codigo);

            }

            else
            {
                result = context.tblProveedores.ToList().Exists(x => x.Codigo == codigo && x.ID != IdProve);
            }

            return result;
        }

        private void ContextRefresh()
        {
            context = new DataClasses1DataContext();
        }
    }
}
