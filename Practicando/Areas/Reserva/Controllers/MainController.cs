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
    }
}