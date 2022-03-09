using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaFB.Main;
using SistemaFB.Models;

namespace SistemaFB.Controllers
{
    public class SeguradoController : Controller
    {
        // GET: Segurado
        [HttpGet]
        public ActionResult Contato(int id)
        {
            var segurado = new ContatosDAO();
            segurado.GetSegurado(id);
            List<Apolice> resultado = new ApoliceDAO().GetApolice(id);
            ViewBag.Apolice = resultado;
            ViewBag.Segurado = segurado;
            return View();
        }
    }
}