using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CNegocio.Repositorios
{
    public class RepoCiudades
    {
        DataClasses1DataContext context;
        public RepoCiudades()
        {
            ContextReresh();
        }

        public List<tblCiudade> ConsultaCiudades()
        {
            ContextReresh();
            var result = (from c in context.tblCiudades
                          select c).ToList();

            return result;
        }

        private void ContextReresh()
        {
            context = new DataClasses1DataContext();
        }
    }
}
