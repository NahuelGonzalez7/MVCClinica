using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCClinica
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "buscar",
                url: "{controller}/{action}/{name}/{surname}",
                defaults: new {controller = "Home",action = "SearchByName"}
                );

            routes.MapRoute(
                name:"SearchByEspecialidad",
                url:"{controller}/{action}/{especialidad}",
                defaults: new {controller = "Medico",action = "SearchByEspecialidad"}            
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
