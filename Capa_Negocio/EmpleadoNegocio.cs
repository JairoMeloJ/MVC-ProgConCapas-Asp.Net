using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class EmpleadoNegocio
    {
        EmpDatos datos = new EmpDatos();
        public List<Empleados> ListarDatos()
        {
            return datos.mostrarEmp().ToList();
        }
        public void GuardarDatos(Empleados emp)
        {
            datos.agregarEmp(emp);
        }
        public void EditarDatos(Empleados emp)
        {
            datos.editarEmp(emp);
        }
        public void BorrarDatos(Empleados emp)
        {
            datos.borrarEmp(emp);
        }
    }
}
