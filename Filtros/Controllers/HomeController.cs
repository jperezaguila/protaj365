using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filtros.Filters;

namespace Filtros.Controllers
{
    public class HomeController : Controller
    {
      // [AutorizacionFiltro]
       //[AccionFiltro]
       //[ResultadoFiltro]
       [ExcepcionFiltro]
        public ActionResult Index()
       {
           ViewBag.Message = "Bienvenido a .NET en MVC";
            return View();
        }
    }
}