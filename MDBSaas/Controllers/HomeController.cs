using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDBSaas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.RenderFullPageIntro = true;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.RenderFullPageIntro = false;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.RenderFullPageIntro = false;
            return View();
        }

        public ActionResult Pricing()
        {
            ViewBag.RenderFullPageIntro = false;
            return View();
        }
    }
}