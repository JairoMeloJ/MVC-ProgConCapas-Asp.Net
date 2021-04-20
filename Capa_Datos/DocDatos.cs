using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class DocDatos
    {
        AdministradorDeCamposEntities db = new AdministradorDeCamposEntities();

        public void agregarDoc(Documentos doc)
        {
            db.Documentos.Add(doc);
            doc.fecha = DateTime.Now.Year.ToString();
            db.SaveChanges();
        }
        public string editarDoc(Documentos doc)
        {
            int contador = db.Documentos.Count() + 1;

            var Origen = from Departamento in db.Departamento where Departamento.Nombre == doc.DepartamentoOrigen select Departamento;
            var Destino = from Departamento in db.Departamento where Departamento.Nombre == doc.DepartamentoDestino select Departamento;

            Departamento DepartamentoOrigen = Origen.First();
            Departamento DepartamentoDestino = Destino.First();

            return $"{DateTime.Now.Year} - {DepartamentoOrigen.Siglas} - {DepartamentoDestino.Siglas} - {contador}";
        }
        public List<Documentos> mostrarDoc()
        {
            return db.Documentos.ToList();
        }
    }
}
