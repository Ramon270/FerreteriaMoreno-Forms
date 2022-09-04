using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CNegocio.Repositorios
{
    public class RepoFacturas
    {
        DataClasses1DataContext context;

        public RepoFacturas()
        {
            ContextRefresh();
        }

        public void InsertFactura(tblFactura factura)
        {
            ContextRefresh();
            factura.Fecha = DateTime.Now;
            factura.IDestado = 3;
            context.tblFacturas.InsertOnSubmit(factura);
            context.SubmitChanges();
        }

        public List<tblFactura> ConsultaFactura()
        {
            ContextRefresh();

            var result = (from f in context.tblFacturas
                          where f.IDestado == 3
                          select f).ToList();

            return result;
        }

        public List<tblFactura> ConsultaFacturaByCode(string codigo)
        {
            ContextRefresh();

            var result = (from f in context.tblFacturas
                          where f.IDestado == 3 && f.Codigo.Contains(codigo)
                          select f).ToList();

            return result;
        }

        public tblFactura ConsultFacturaByID(int IdFactura)
        {
            ContextRefresh();

            var obj = (from f in context.tblFacturas
                       where f.ID == IdFactura
                       select f).SingleOrDefault();

            return obj;
        }

        public tblFactura ReturnFactura()
        {
            ContextRefresh();

            var obj = (from f in context.tblFacturas
                       select f).ToList();

            var UltimaF = obj.Last();

            return UltimaF;
        }

        public void InsertDetalle(int IdFactura, List<tblDetalle> listaDetalle)
        {
            ContextRefresh();

            foreach (var elemento in listaDetalle)
            {
                elemento.IDfactura = IdFactura;
                context.tblDetalles.InsertOnSubmit(elemento);
                context.SubmitChanges();
            }
        }

        public bool ComprobarFactura(string codigo, int IdFactura = 0)
        {
            ContextRefresh();
            bool result;

            if(IdFactura == 0)
            {
                result = context.tblFacturas.ToList().Exists(x => x.Codigo == codigo);
            }

            else
            {
                result = context.tblFacturas.ToList().Exists(x => x.Codigo == codigo && x.ID != IdFactura);
            }

            return result;
        }

        public List<tblDetalle> ConsultaDetalle(int IdFactura)
        {
            ContextRefresh();

            var result = (from d in context.tblDetalles
                          where d.IDfactura == IdFactura
                          select d).ToList();

            return result;
        }

        public void EliminarFactura(int IdFactura)
        {
            ContextRefresh();

            var obj = (from f in context.tblFacturas
                       where f.ID == IdFactura
                       select f).SingleOrDefault();

            obj.IDestado = 4;

            context.SubmitChanges();
        }

        private void ContextRefresh()
        {
            context = new DataClasses1DataContext();
        }
    }

}
