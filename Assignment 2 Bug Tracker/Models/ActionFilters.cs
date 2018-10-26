using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2_Bug_Tracker.Models
{
    public class ActionFilters : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Browser.Crawler)
            {
                filterContext.Result = new EmptyResult();
            }
        }
    }
}