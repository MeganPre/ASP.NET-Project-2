using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10207_Megan_Pretorius_SLD521_SA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult PaperView()
        //{
        //    return View();
        //}

        public ActionResult News()
        {
            //ViewBag.Message = "This is the news page where all the latest news is that you want.";
            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "The page of all the information about our papers.";
            return View();
        }
    }
}