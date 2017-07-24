using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_Practice;

namespace Practicando.Areas.Reserva.Controllers
{
    public class MainController : Controller
    {
        // GET: Reserva/Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListReserva()
        {
            return PartialView((DAGeneral.listadoReserva()));
        }
        public ActionResult Editar(int ID)
        {
            EF_Practice.Reserva Reserva = DAGeneral.listadoReserva().Where(x => x.CodReserva == ID).FirstOrDefault();
            return View(Reserva);
        }

        [HttpPost]
        public ActionResult Editar(EF_Practice.Reserva Reserva)
        {
            bool exito = DAGeneral.ActualizarReserva(Reserva);
            return RedirectToAction("Index");
        }

       
        public ActionResult Crear()
        {
            ViewBag.ListadoReservas = DAGeneral.listadoReserva();
            return View();
        }
        [HttpPost]
        public ActionResult Crear(EF_Practice.Reserva Reserva)
        {
            bool exito = DAGeneral.RegistrarReserva(Reserva);
            return RedirectToAction("Index");
        }

       
        public ActionResult Eliminar(int ID)
        {
            EF_Practice.Reserva Reserva = DAGeneral.listadoReserva().Where(x => x.CodReserva == ID).FirstOrDefault();
            bool exito = DAGeneral.EliminarReserva(Reserva);
            return RedirectToAction("Index");
        }

    }
}