using SistemaFB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFB.Controllers
{
    public class ApoliceController : Controller
    {
        // GET: Apolice
        public ActionResult ApoliceDetalhada(int id)
        {
            var apolice = new ApoliceDAO();
            apolice.GetApoliceDetalhada(id);
            ViewBag.Apolice = apolice;
            return View();
        }
    }
}