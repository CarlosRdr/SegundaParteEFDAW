using EF_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicando.Areas.Clientes.Controllers
{
    public class MainController : Controller
    {
        // GET: Clientes/Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listado()

        {
            return PartialView(DAGeneral.listadoCliente());
        }

        public ActionResult Eliminar(string ID)
        {
            EF_Practice.Cliente Cliente = DAGeneral.listadoCliente().Where(x => x.CodCliente == ID).FirstOrDefault();
            bool exito = DAGeneral.EliminarCliente(Cliente);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(string ID)
        {
            EF_Practice.Cliente Cliente = DAGeneral.listadoCliente().Where(x => x.CodCliente == ID).FirstOrDefault();
            return View(Cliente);
        }
        [HttpPost]
        public ActionResult Editar(EF_Practice.Cliente Cliente)
        {
            bool exito = DAGeneral.ActualizarCliente(Cliente);
            return RedirectToAction("Index");
        }

        public ActionResult Crear()
        {
            ViewBag.ListadoClientes = DAGeneral.listadoCliente();
            return View();
        }
        [HttpPost]
        public ActionResult Crear(EF_Practice.Cliente Cliente)
        {
            bool exito = DAGeneral.RegistrarCliente(Cliente);
            return RedirectToAction("Index");
        }
    }
}