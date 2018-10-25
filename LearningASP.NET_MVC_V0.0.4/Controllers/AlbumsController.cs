using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASP.NET_MVC_V0._0._4.Controllers
{
    public class AlbumsController : Controller
    {
        //[NonAction] - using this we will be not allowed to use Edit method from url.
        //[ActionName("Edytuj")] - using ActionName we can change which word will get acces to Edit method
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost] // - We got two same named methods, but one will be used while using GET request, this one above and
                   // this one below will be used while for example we gonna edit album names
        public ActionResult Edit(Album newAlbum)
        {
            //return Content(string.Format("Title: {0}, Artist: {1}, Price:{2}", newAlbum.AlbumTitle, newAlbum.Artist.Name, newAlbum.Price));
            return Json(newAlbum);
            //test2
        }
    }

}