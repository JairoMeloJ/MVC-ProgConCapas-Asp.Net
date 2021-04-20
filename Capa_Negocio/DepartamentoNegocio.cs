using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class DepartamentoNegocio
    {
        DepDatos datos = new DepDatos();
        public List<Departamento> listarDatos()
        {
            return datos.mostrarDep().ToList();
        }
        public void guardarDatos(Departamento dep)
        {
            datos.agregarDep(dep);
        }
        public void editarDatos(Departamento dep)
        {
            datos.editarDep(dep);
        }
        public void borrarDatos(Departamento dep)
        {
            datos.borrarDep(dep);
        }
    }
}
