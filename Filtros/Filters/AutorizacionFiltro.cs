﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Filters
{
    public class AutorizacionFiltro:FilterAttribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //La accion Lógica del Filtro
        }
    }
}