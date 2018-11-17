using DAL;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TourSiteWith3LayersArch.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            List<Tour> tourList = TourServices.GetAllTours();
            return View(tourList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}