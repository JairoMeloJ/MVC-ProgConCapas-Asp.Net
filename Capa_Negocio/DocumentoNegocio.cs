using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class DocumentoNegocio
    {
        DocDatos datos = new DocDatos();

        public void agregarDoc(Documentos doc)
        {
            doc.Secuencia = datos.editarDoc(doc);
            datos.agregarDoc(doc);
        }
        public List<Documentos> mostrarDoc()
        {
            return datos.mostrarDoc().ToList();
        }
    }
}
