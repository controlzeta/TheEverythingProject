using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheEverythingProject.Models;

namespace TheEverythingProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(RequestAQuoteModels m)
        {
            if (ModelState.IsValid)
            {
                return View("RequestAQuote", m);
            }
            ModelState.AddModelError("", "Se encontraron algunos campos vacios. Por favor revisa");
            return View("RequestAQuote", m);
        }

        public ActionResult RequestAQuote(RequestAQuoteModels m)
        {
            if (ModelState.IsValid)
            {
                return View("RequestAQuote", m);
            }
            ModelState.AddModelError("", "Se encontraron algunos campos vacios. Por favor revisa");
            return View("RequestAQuote", m);
        }

        //[HttpPost]
        //public ActionResult RequestAQuote(RequestAQuoteModels quote)
        //{
        //    try 
        //    { 
        //        //return RedirectToAction("ThankYou");
        //        return View("RequestAQuote");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        public ActionResult ThankYou()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
