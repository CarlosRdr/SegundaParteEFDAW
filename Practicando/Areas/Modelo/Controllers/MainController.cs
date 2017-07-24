using EF_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicando.Areas.Modelo.Controllers
{
    public class MainController : Controller
    {
        // GET: Modelo/Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listado()

        {
            ViewBag.ListadoMarca = DAGeneral.listadoMarca();
            return PartialView(DAGeneral.listadoModelo());
        }

        public ActionResult Eliminar(string ID)
        {
            EF_Practice.Modelo Modelo = DAGeneral.listadoModelo().Where(x => x.CodModelo == ID).FirstOrDefault();
            bool exito = DAGeneral.EliminarModelo(Modelo);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(string ID)
        {
            EF_Practice.Modelo Modelo = DAGeneral.listadoModelo().Where(x => x.CodModelo == ID).FirstOrDefault();
            return View(Modelo);
        }
        [HttpPost]
        public ActionResult Editar(EF_Practice.Modelo Modelo)
        {
            bool exito = DAGeneral.ActualizarModelo(Modelo);
            return RedirectToAction("Index");
        }

        public ActionResult Crear()
        {
            ViewBag.ListadoModelos = DAGeneral.listadoModelo();
            return View();
        }
        [HttpPost]
        public ActionResult Crear(EF_Practice.Modelo Modelo)
        {
            bool exito = DAGeneral.RegistrarModelo(Modelo);
            return RedirectToAction("Index");
        }
    }
}