using EF_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicando.Areas.Cliente.Controllers
{
    public class MainController : Controller
    {
        // GET: Cliente/Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListadoClientes()
        {
            return PartialView(DAGeneral.listadoCliente());
        }

        public ActionResult Eliminar(string ID)
        {
            EF_Practice.Cliente cliente = DAGeneral.listadoCliente().Where(x => x.CodCliente == ID).FirstOrDefault();
            bool exito = DAGeneral.EliminarCliente(cliente);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(string ID)
        {
            EF_Practice.Cliente cliente = DAGeneral.listadoCliente().Where(x => x.CodCliente == ID).FirstOrDefault();
            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(EF_Practice.Cliente cliente)
        {
            bool exito = DAGeneral.ActualizarCliente(cliente);
            return RedirectToAction("Index");
        }

        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(EF_Practice.Cliente cliente)
        {
            bool exito = DAGeneral.RegistrarCliente(cliente);
            return RedirectToAction("Index");
        }

    }
}