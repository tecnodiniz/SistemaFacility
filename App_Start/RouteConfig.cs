using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SistemaFB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Login",
                "Login/",
                new { Controller = "Login", Action = "Index"}
                );
            routes.MapRoute(
               "Clientes",
               "Home/Clientes",
               new { Controller = "Home", Action = "Clientes" }
               );
            routes.MapRoute(
              "Teste",
              "Home/Teste:id",
              new { Controller = "Home", Action = "Teste", id = 1340}
              );

            routes.MapRoute(
              "Segurado",
              "Segurado/Contato:id",
              new { Controller = "Segurado", Action = "Contato", id = 0}
              );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
