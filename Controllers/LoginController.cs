﻿using SistemaFB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Session["Erro"] != null)
               ViewBag.Erro = Session["Erro"].ToString();
            return View();
        }

        [HttpPost]
        public void ChecarLogin()
        {

            var usuario = new Usuario();
            usuario.Login = Request["login"];
            usuario.Senha = Request["senha"];

            if (usuario.Logar())
            {
                Session["Autorizado"] = "OK";
                Session.Remove("Erro");
                Session["Usuario"] = usuario.Login;

                Response.Redirect("/Home/Index");
            }
            else
            {
                Session["Erro"] = "Usuário ou senha inválidos";
                Response.Redirect("/Login/Index");
            }
        }


    }
}