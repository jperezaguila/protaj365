    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Filters
{
    public class AccionFiltro:FilterAttribute,IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //Accion Lógica del Filtro - Antes  
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Accion Lógica del Filtro - Después
        }
    }
}