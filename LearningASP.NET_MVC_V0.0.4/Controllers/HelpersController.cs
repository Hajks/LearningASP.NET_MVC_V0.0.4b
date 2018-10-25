using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningASP.NET_MVC_V0._0._4.Models;

namespace LearningASP.NET_MVC_V0._0._4.Controllers
{
    public class HelpersController : Controller
    {
        public ActionResult Index()
        {
            var result = new HelpersModel()
            {
                Bool = true,
                DateTime = new DateTime(2000, 08, 15),
                Decimal = 312412431.120m,
                String = "Helpery w ASP.NET MVC!"
            };
            return View(result);
        }
    }
    
}