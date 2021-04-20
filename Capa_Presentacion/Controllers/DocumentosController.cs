using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Negocio;
using Capa_Entidad;


namespace Capa_Presentacion.Controllers
{
    public class DocumentosController : Controller
    {
        DocumentoNegocio docNegocio = new DocumentoNegocio();


        // GET: Documentos/Details/5
        public ActionResult Details()
        {
            return View(docNegocio.mostrarDoc());
        }

        // GET: Documentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Documentos/Create
        [HttpPost]
        public ActionResult Create(Documentos doc)
        {
            try
            {
                // TODO: Add insert logic here
                docNegocio.agregarDoc(doc);
                

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
    }
}
