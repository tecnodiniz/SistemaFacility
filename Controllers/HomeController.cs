using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaFB.Models;

namespace SistemaFB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*if (Session["Autorizado"] != null)
            {
                ViewBag.Usuario = "Admin";
                ViewBag.Nome = Session["Usuario"].ToString();
               return View();

            }
            else
            {
                //Response.Redirect("/Login/Index");
                //return null;
                return RedirectToAction("Index", "Login");
            }*/
            return View();


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Clientes()
        {
            ViewBag.Message = "Your Client page.";

            var lista = Cliente.GetClientes();
            ViewBag.lista = lista;

            return View();
        }
    }
}