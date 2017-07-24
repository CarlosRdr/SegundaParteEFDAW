using EF_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicando.Areas.Vehiculos.Controllers
{
    public class MainController : Controller
    {
        // GET: Vehiculos/Main
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Listado()

        {
            ViewBag.ListadoModelo = DAGeneral.listadoModelo();
            return PartialView(DAGeneral.listadoVehiculo());
        }

        public ActionResult Eliminar(string ID)
        {
            EF_Practice.Vehiculo Vehiculo = DAGeneral.listadoVehiculo().Where(x => x.CodVehiculo == ID).FirstOrDefault();
            bool exito = DAGeneral.EliminarVehiculo(Vehiculo);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(string ID)
        {
            EF_Practice.Vehiculo Vehiculo = DAGeneral.listadoVehiculo().Where(x => x.CodVehiculo == ID).FirstOrDefault();
            return View(Vehiculo);
        }
        [HttpPost]
        public ActionResult Editar(EF_Practice.Vehiculo Vehiculo)
        {
            bool exito = DAGeneral.ActualizarVehiculo(Vehiculo);
            return RedirectToAction("Index");
        }

        public ActionResult Crear()
        {
            ViewBag.ListadoVehiculos = DAGeneral.listadoVehiculo();
            return View();
        }
        [HttpPost]
        public ActionResult Crear(EF_Practice.Vehiculo Vehiculo)
        {
            bool exito = DAGeneral.RegistrarVehiculo(Vehiculo);
            return RedirectToAction("Index");
        }
    }
}