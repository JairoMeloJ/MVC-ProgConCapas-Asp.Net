using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class EmpDatos
    {
        AdministradorDeCamposEntities db = new AdministradorDeCamposEntities();

        public void agregarEmp(Empleados emp)
        {
            db.Empleados.Add(emp);
            db.SaveChanges();
        }
        public void editarEmp(Empleados emp)
        {
            var busqueda = from Empleados in db.Empleados where Empleados.ID == emp.ID select Empleados;
            Empleados empleado = busqueda.First();
            empleado.Nombre = emp.Nombre;
            empleado.Correo = emp.Correo;
            empleado.Cargo = emp.Cargo;
            db.SaveChanges();
        }
        public List<Empleados> mostrarEmp()
        {
            return db.Empleados.ToList();
        }
        public void borrarEmp(Empleados emp)
        {
            var busqueda = from Empleados in db.Empleados where Empleados.ID == emp.ID select Empleados;
            Empleados empleado = busqueda.First();
            db.Empleados.Remove(empleado);
            db.SaveChanges();
        }
    }
}
