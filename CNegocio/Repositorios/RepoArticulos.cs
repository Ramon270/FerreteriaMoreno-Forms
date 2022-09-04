using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CNegocio.Repositorios
{
    public class RepoArticulos
    {
        DataClasses1DataContext context;
        public RepoArticulos()
        {
            ContextRefresh();
        }

        //Metodo para insertar articulos
        public void InsertArticulo(tblArticulo articulo)
        {
            ContextRefresh();
            articulo.IDestado = 1;
            articulo.Cantidad = 0;
            context.tblArticulos.InsertOnSubmit(articulo);
            context.SubmitChanges();
        }

        //Metodo para consultar todos los articulos
        public List<tblArticulo> ConsultArticulos()
        {
            ContextRefresh();
            var result = (from a in context.tblArticulos
                          where a.IDestado == 1
                          select a).ToList();

            return result;
        }

        //Metodo para consultar articulos por su codigo
        public List<tblArticulo> ConsultArticuloByCode(string codigo)
        {
            ContextRefresh();
            var result = (from a in context.tblArticulos
                          where a.Codigo.Contains(codigo) && a.IDestado == 1
                          select a).ToList();

            return result;
        }

        //Metodo para consultar articulos por su nombre
        public List<tblArticulo> ConsultArticuloByName(string codigo)
        {
            ContextRefresh();
            var result = (from a in context.tblArticulos
                          where a.NombreArticulo.Contains(codigo) && a.IDestado == 1
                          select a).ToList();

            return result;
        }

        //Metodo para consultar articulo por ID
        public tblArticulo ConsultArticuloByID(int id)
        {
            ContextRefresh();
            var obj = (from a in context.tblArticulos
                       where a.ID == id
                       select a).SingleOrDefault();

            return obj;
        }

        //Metodo para eliminar articulo (cambiar estado)
        public void DeleteArticulo(tblArticulo articulo)
        {
            ContextRefresh();
            var obj = (from a in context.tblArticulos
                       where a.ID == articulo.ID
                       select a).SingleOrDefault();
            obj.IDestado = 2;
            context.SubmitChanges();
        }

        //Metodo para modificar informacion del articulo
        public void UpdateArticulo(tblArticulo articulo)
        {
            ContextRefresh();

            var obj = (from a in context.tblArticulos
                       where a.ID == articulo.ID
                       select a).SingleOrDefault();

            obj.Codigo = articulo.Codigo;
            obj.NombreArticulo = articulo.NombreArticulo;
            obj.IDproveedor = articulo.IDproveedor;
            obj.Precio = articulo.Precio;
            obj.Descripcion = articulo.Descripcion;
            obj.Cantidad = articulo.Cantidad;
            context.SubmitChanges();
        }

        //Metodo para comprobar codigo
        public bool ComprobarCodigo(string codigo, int IdArt = 0)
        {
            ContextRefresh();
            bool result;
            if (IdArt == 0)
            {
                result = context.tblArticulos.ToList().Exists(x => x.Codigo == codigo);
                
            }

            else
            {
                result = context.tblArticulos.ToList().Exists(x => x.Codigo == codigo && x.ID != IdArt);
            }

            return result;
        }

        private void ContextRefresh()
        {
            context = new DataClasses1DataContext();
        }
    }
}
