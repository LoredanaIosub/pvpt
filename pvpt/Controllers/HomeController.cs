using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pvpt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   //comentariu
            return View();
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

        public ActionResult Eat()
        {
            ViewBag.Message = "Mancare buna.";

            return View();
        }

        public ActionResult Relax()
        {
            ViewBag.Message = "Relaxare";

            return View();
        }

        public ActionResult Travel()
        {
            ViewBag.Message = "Calatorie";

            return View();
        }

        public ActionResult Activities()
        {
            ViewBag.Message = "Activități";

            return View();
        }

        public ActionResult Play()
        {
            ViewBag.Message = "Play";

            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Evenimente";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Noutati";

            return View();
        }

        /*public ActionResult Opinion()
        {
            ViewBag.Message = "Parerea ta!";

            return View();
        }*/
    }
}