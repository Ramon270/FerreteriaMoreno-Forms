using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CNegocio.Repositorios
{
    public class RepoPosiciones
    {
        DataClasses1DataContext context;

        public RepoPosiciones()
        {
            ContextRefresh();
        }

        public List<tblPosicione> ConsultaPosiciones()
        {
            ContextRefresh();
            var result = (from p in context.tblPosiciones
                          select p).ToList();

            return result;
        }
        private void ContextRefresh()
        {
            context = new DataClasses1DataContext();
        }
    }
}
