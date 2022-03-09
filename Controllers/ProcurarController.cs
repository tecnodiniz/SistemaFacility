using SistemaFB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaFB.Controllers
{
    public class ProcurarController : Controller
    {
        // GET: Procurar
         public PartialViewResult GetCliente(string nome)
        {
            List<Contatos> informacaoPesquisa = new ClienteDAO().GetCliente(nome);

            return PartialView(informacaoPesquisa);
           
        }
    }
}