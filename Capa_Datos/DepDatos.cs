using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class DepDatos
    {
        AdministradorDeCamposEntities db = new AdministradorDeCamposEntities();

        public void agregarDep(Departamento dep)
        {
            db.Departamento.Add(dep);
            db.SaveChanges();
        }
        public List<Departamento> mostrarDep()
        {
            return db.Departamento.ToList();
        }
        public void editarDep(Departamento dep)
        {
            var busqueda = from Departamento in db.Departamento where Departamento.ID == dep.ID select Departamento;
            Departamento departamento = busqueda.First();
            departamento.Nombre = dep.Nombre;
            departamento.Siglas = dep.Siglas;

            db.SaveChanges();
        }
        public void borrarDep(Departamento dep)
        {
            var busqueda = from Departamento in db.Departamento where Departamento.ID == dep.ID select Departamento;
            Departamento departamento = busqueda.First();
            db.Departamento.Remove(departamento);
            db.SaveChanges();
        }
    }
}
