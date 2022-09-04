using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CData;

namespace CNegocio.Repositorios
{
    public class RepoEmpleados
    {
        DataClasses1DataContext context;
        public RepoEmpleados()
        {
            ContextRefresh();
        }

        //Metodo para insertar empleados
        public void InsertEmpleado(tblEmpleado empleado)
        {
            ContextRefresh();
            empleado.IDestado = 1;
            empleado.FechaRegistro = DateTime.Now;
            context.tblEmpleados.InsertOnSubmit(empleado);
            context.SubmitChanges();
        }

        //Metodo para consultar todos los empleados
        public List<tblEmpleado> ConsultaEmpleados()
        {
            ContextRefresh();
            var result = (from e in context.tblEmpleados
                          where e.IDestado == 1
                          select e).ToList();

            return result;
        }

        //Metodo para consultar empleados por su cedula
        public List<tblEmpleado> ConsultaEmpleadoByCedula(string cedula)
        {
            ContextRefresh();
            var result = (from e in context.tblEmpleados
                          where e.Cedula.Contains(cedula) && e.IDestado == 1
                          select e).ToList();

            return result;
        }

        //Metodo para consultar empleados por codigo
        public List<tblEmpleado> ConsultaEmpleadoByCode(string codigo)
        {
            ContextRefresh();
            var result = (from e in context.tblEmpleados
                          where e.Codigo.Contains(codigo) && e.IDestado == 1
                          select e).ToList();

            return result;
        }

        //Metodo para consultar empleados por ID
        public tblEmpleado ConsultaEmpleadoByID(int IdEmpleado)
        {
            ContextRefresh();
            var obj = (from e in context.tblEmpleados
                       where e.ID == IdEmpleado
                       select e).SingleOrDefault();

            return obj;
        }

        //Metodo para eliminar empleado (cambiar estado)
        public void DeleteEmpleado(tblEmpleado empleado)
        {
            ContextRefresh();
            var obj = (from e in context.tblEmpleados
                       where e.ID == empleado.ID
                       select e).SingleOrDefault();

            obj.IDestado = 2;
            context.SubmitChanges();
        }

        //Metodo para modificar informacion empleado
        public void UpdateEmpleado(tblEmpleado empleado)
        {
            ContextRefresh();

            var obj = (from e in context.tblEmpleados
                       where e.ID == empleado.ID
                       select e).SingleOrDefault();

            obj.Codigo = empleado.Codigo;
            obj.Nombre = empleado.Nombre;
            obj.Apellidos = empleado.Apellidos;
            obj.Cedula = empleado.Cedula;
            obj.Direccion = empleado.Direccion;
            obj.Sexo = empleado.Sexo;
            obj.FechaNacimiento = empleado.FechaNacimiento;
            obj.Telefono = empleado.Telefono;
            obj.IDciudad = empleado.IDciudad;
            obj.IDposicion = empleado.IDposicion;

            context.SubmitChanges();
        }

        //Metodo para comprobar codigo
        public bool ComprobarCodigo(string codigo, int IdEmpleado = 0)
        {
            ContextRefresh();
            bool result;
            if (IdEmpleado == 0)
            {
                result = context.tblEmpleados.ToList().Exists(x => x.Codigo == codigo);

            }

            else
            {
                result = context.tblEmpleados.ToList().Exists(x => x.Codigo == codigo && x.ID != IdEmpleado);
            }

            return result;
        }

        //Metodo para comprobar cedula
        public bool ComprobarCedula(string cedula, int IdEmpleado = 0)
        {
            ContextRefresh();
            bool result;
            if (IdEmpleado == 0)
            {
                result = context.tblEmpleados.ToList().Exists(x => x.Cedula == cedula);

            }

            else
            {
                result = context.tblEmpleados.ToList().Exists(x => x.Cedula == cedula && x.ID != IdEmpleado);
            }

            return result;
        }

        private void ContextRefresh()
        {
            context = new DataClasses1DataContext();
        }
    }
}
