using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion.Controllers
{
    public class EmpleadosController : Controller
    {
        EmpleadoNegocio empNegocio = new EmpleadoNegocio();

        // GET: Empleados/Details/
        public ActionResult Details()
        {
            return View(empNegocio.ListarDatos());
        }

        // GET: Empleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        [HttpPost]
        public ActionResult Create(Empleados emp)
        {
            try
            {
                // TODO: Add insert logic here
                empNegocio.GuardarDatos(emp);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleados/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        public ActionResult Edit(Empleados emp)
        {
            try
            {
                // TODO: Add update logic here
                empNegocio.EditarDatos(emp);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleados/Delete/5
        public ActionResult Delete()
        {
            return View();
        }

        // POST: Empleados/Delete/5
        [HttpPost]
        public ActionResult Delete(Empleados emp)
        {
            try
            {
                // TODO: Add delete logic here
                empNegocio.BorrarDatos(emp);

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
    }
}
