using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningASP.NET_MVC_V0._0._4.Controllers
{
    public class Album
    {
        public string AlbumTitle { get; set; }
        public decimal Price { get; set; }

        public Artist Artist { get; set; }
    }
    
}