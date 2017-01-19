using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Get запрос";
            
            return View(new Test());
        }
        [HttpPost]
        public ActionResult About(Test model, HttpPostedFileBase file)
        {
            ViewBag.Message = $"Post запрос {model.name} ";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class Test
    {
        public string name { get; set; }
        public string tel { get; set; }
        public string dateBirth { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string message { get; set; }
        public string lang1 { get; set; }
        public string lang2 { get; set; }
        public string lang3 { get; set; }

    }
}

