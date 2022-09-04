using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CNegocio.Repositorios
{
    public class RepoUsuarios
    {
        DataClasses1DataContext context;
        public RepoUsuarios()
        {
            ContextRefresh();
        }

        public void InsertUser(tblUsuario usuario)
        {
            ContextRefresh();
            usuario.IDestado = 1;
            context.tblUsuarios.InsertOnSubmit(usuario);
            context.SubmitChanges();
        }

        public List<tblUsuario> ConsultaUsuarios()
        {
            var result = (from u in context.tblUsuarios
                          where u.IDestado == 1
                          select u).ToList();

            return result;
        }

        public List<tblUsuario> ConsultaUsuariosByName(string username)
        {
            var result = (from u in context.tblUsuarios
                          where u.UserName.Contains(username) && u.IDestado == 1
                          select u).ToList();

            return result;
        }

        public tblUsuario BuscarUsuario(string usuario)
        {
            ContextRefresh();
            var result = context.tblUsuarios.ToList().Find(x => x.UserName == usuario && x.IDestado == 1);

            return result;
        }

        public tblUsuario ConsultaUsuarioById(int IdUsuario)
        {
            var obj = (from u in context.tblUsuarios
                       where u.ID == IdUsuario
                       select u).SingleOrDefault();

            return obj;
        }

        public void DeleteUser(tblUsuario usuario)
        {
            ContextRefresh();
            var obj = (from u in context.tblUsuarios
                       where u.ID == usuario.ID
                       select u).SingleOrDefault();

            obj.IDestado = 2;
            context.SubmitChanges();
        }

        public void UpdateUser(tblUsuario usuario)
        {
            ContextRefresh();

            var obj = (from u in context.tblUsuarios
                       where u.ID == usuario.ID
                       select u).SingleOrDefault();

            obj.UserName = usuario.UserName;
            obj.Contrasena = usuario.Contrasena;

            context.SubmitChanges();

        }

        public bool ConsultarUser(string Username, int IdUsuario = 0)
        {
            ContextRefresh();
            bool result;

            if (IdUsuario == 0)
            {
                result = context.tblUsuarios.ToList().Exists(x => x.UserName == Username && x.IDestado == 1);

            }

            else
            {
                result = context.tblUsuarios.ToList().Exists(x => x.UserName == Username && x.ID != IdUsuario && x.IDestado == 1);
            }

            return result;
        }

        private void ContextRefresh()
        {
            context = new DataClasses1DataContext();
        }
    }
}
