using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LearningASP.NET_MVC_V0._0._4.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize] // Simply authorize, we need to be user with rights to see this page :D
        //[HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZeroView")]   - catching excepction and then redirect wherever we want
        [Timer]
        public ActionResult Index()
        {
    
            //var zero = 0;
            //float f = 2 / zero;

            Thread.Sleep(1000);
            return View();
        }

        #region ParametersBinding
        public void ParametersBinding(int p1, int p2, int p3, int p4)
        {
            Response.Write(string.Format("p1: {0}, p2: {1}, p3: {2}, p4: {3}", p1, p2, p3, p4));
        }      
        #endregion

        #region ParametersBindingToClass          
        public void ParametersBindingToClass(Album a)
        {
            Response.Write(string.Format("Title: {0}, Artist: {1}, Price:{2}", a.AlbumTitle, a.Artist.Name, a.Price));
        }
        #endregion

        #region Action Results

        public ActionResult GoToEdit()
        {
            return RedirectToAction("Edit", "Albums"); //It redirect us to adres /Home/Albums/Edit
        }

        public ActionResult GetFile(string filename)
        {
            var physicalFilePath = Server.MapPath("~/Files/" + filename);
            return File(physicalFilePath, "application/rar"); //GetFile let us download file that we need.
        }

        public ActionResult GetJson()
        {
            var a = new Album()
            {
                AlbumTitle = "Tytuł albumu",
                Artist = new Artist {Name = "Znany zespół"},
                Price = 29.99M
            };
            return Json(a, JsonRequestBehavior.AllowGet); //It return Json, but we have to allow for it first
        }

        public ActionResult GetCsv() // Own Action result which return excel file with information created inside this method.
        {
            return new MyCsvResult("Jan Kowalski" + Environment.NewLine + "Krzysztof Nowak");
        }

        #endregion

    }
}