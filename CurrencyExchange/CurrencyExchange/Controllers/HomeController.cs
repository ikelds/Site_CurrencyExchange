using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CurrencyExchange.Models;

namespace CurrencyExchange.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.CursCB = LoadCursCB.LoadCurs();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Основная информация о нас.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Свяжитесь с нами по контактам указанным ниже.";

            return View();
        }
    }
}