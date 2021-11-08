using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OperaWebSite.Filters
{
    public class MyFilterAction : ActionFilterAttribute
    {
        //Filtro de accion - Antes
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // controller/action
            // {controller}/{action}
            // Opera/Create
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];
            Debug.WriteLine("controller: " + controller + "Action: " + action + "Paso por OnActionExecuting");
        }

        // Filtro de accion - Despues
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var controller = filterContext.RouteData.Values["controller"];
            var action = filterContext.RouteData.Values["action"];
            Debug.WriteLine("controller: " + controller + "Action: " + action + "Paso por OnActionExecuted");
        }
    }
}