﻿using System.Web;
using System.Web.Mvc;

namespace Fit5032_wk9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
