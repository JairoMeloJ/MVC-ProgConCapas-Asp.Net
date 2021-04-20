using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion.Controllers
{
    public class DepartamentoController : Controller
    {
        DepartamentoNegocio depNegocio = new DepartamentoNegocio();

        // GET: Departamento/Details/5
        public ActionResult Details()
        {
            return View(depNegocio.listarDatos());
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        public ActionResult Create(Departamento dep)
        {
            try
            {
                // TODO: Add insert logic here
                depNegocio.guardarDatos(dep);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Departamento/Edit/5
        [HttpPost]
        public ActionResult Edit(Departamento dep)
        {
            try
            {
                // TODO: Add update logic here
                depNegocio.editarDatos(dep);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Departamento/Delete/5
        [HttpPost]
        public ActionResult Delete(Departamento dep)
        {
            try
            {
                // TODO: Add delete logic here
                depNegocio.borrarDatos(dep);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
    }
}