﻿using System.Web;
using System.Web.Mvc;

namespace Assignment_2_Bug_Tracker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
