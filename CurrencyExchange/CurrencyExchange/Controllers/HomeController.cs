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
            ViewBag.usdSell = LoadCursCB.usdSell;
            ViewBag.eurSell = LoadCursCB.eurSell;
            ViewBag.usdBuy = LoadCursCB.usdBuy;
            ViewBag.eurBuy = LoadCursCB.eurBuy;
            
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

        public ActionResult Step2()
        {
            ViewBag.Message = "Шаг 2";
            
            return View();
        }

        public ActionResult Step3()
        {
            return View();
        }
    }
}