using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;
using Rotativa.Options;

namespace webcv.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PrintIndex()
        {
            return new ActionAsPdf("Index") { FileName = "cv.pdf" };
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}