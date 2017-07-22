using EF_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicando.Areas.Marca.Controllers
{
    public class MainController : Controller
    {
        // GET: Marca/Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listado()

        {
            return PartialView(DAGeneral.listadoMarca());
        }
        public ActionResult Eliminar(string ID)
        {
            EF_Practice.Marca marca = DAGeneral.listadoMarca().Where(x => x.CodMarca == ID).FirstOrDefault();
            bool exito = DAGeneral.EliminarMarca(marca);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(string ID)
        {
            EF_Practice.Marca marca = DAGeneral.listadoMarca().Where(x => x.CodMarca == ID).FirstOrDefault();
            return View(marca);
        }


        [HttpPost]
        public ActionResult Editar(EF_Practice.Marca marca)
        {
            bool exito = DAGeneral.ActualizarMarca(marca);
            return RedirectToAction("Index");
        }
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(EF_Practice.Marca marca)
        {
            bool exito = DAGeneral.RegistrarMarca(marca);
            return RedirectToAction("Index");
        }

    }
}