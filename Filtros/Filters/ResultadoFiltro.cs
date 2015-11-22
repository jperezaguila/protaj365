using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Filters
{
    public class ResultadoFiltro:FilterAttribute,IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            ////Accion Lógica del Filtro - Antes  
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //Accion Lógica del Filtro - Después
        }
    }
}