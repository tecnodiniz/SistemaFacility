using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaFB.Models;

namespace SistemaFB.Controllers
{
    public class SeguradoController : Controller
    {
        // GET: Segurado
        [HttpGet]
        public ActionResult Segurado(int id)
        {
            var segurado = new Contatos();
            segurado.GetSegurado(id);
            ViewBag.Segurado = segurado;
            return View();
        }
    }
}