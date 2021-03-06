using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaFB.Main;
using SistemaFB.Models;

namespace SistemaFB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Autorizado"] != null)
            {
               
                ViewBag.Usuario = Session["Usuario"].ToString();
                ViewBag.Email = Session["Email"].ToString();
                ViewBag.Grupo = Session["Grupo"].ToString();
                ViewBag.Ramal = Session["Ramal"].ToString();

                return View();

            }
            
            else
            {
                //Response.Redirect("/Login/Index");
                //return null;
                return RedirectToAction("Index", "Login");
            }
            


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Clientes()
        {
            ViewBag.Message = "Your Client page.";


            return View();
        }
        public ActionResult Teste()
        {
         
            
            return View();
        }
       
    }
}