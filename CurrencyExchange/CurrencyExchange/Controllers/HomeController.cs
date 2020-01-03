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
        // Создаем контекст данных.
        OrderContext db = new OrderContext();

        [HttpGet]
        public ActionResult Index()
        {
            // Все курсы валют с сайта ЦБ
            ViewBag.CursCB = LoadCursCB.LoadCurs();
            // Продажа и покупка usd и eur сайта с учетом маржи.
            ViewBag.usdSell = LoadCursCB.usdSell;
            ViewBag.eurSell = LoadCursCB.eurSell;
            ViewBag.usdBuy = LoadCursCB.usdBuy;
            ViewBag.eurBuy = LoadCursCB.eurBuy;
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Свяжитесь с нами по контактам указанным ниже.";

            return View();
        }

        [HttpGet]
        public ActionResult Step2(String operation,
            String currency, Decimal course, Decimal amount, Decimal sum)
        {
            DateTime dt = DateTime.Now;

            ViewBag.operation = operation == "buy" ? "продаю" : "покупаю";
            ViewBag.currency = currency == "usd" ? "$" : "€";
            ViewBag.course = course;
            ViewBag.amount = amount;
            ViewBag.sum = sum;
            ViewBag.date = dt.ToString("dd.MM.yyyy");

            return View();
        }

        [HttpPost]
        public ActionResult Step2(ExchangeOptions options)
        {
            options.Date = DateTime.Now;
            // Добавляем информацию о заказе в базу данных.
            db.OrdersExchange.Add(options);
            // Сохраняем в БД все изменения.
            db.SaveChanges();

            return RedirectToAction("Step3", new { name = options.Name });
        }

        public ActionResult Step3(String name)
        {
            ViewBag.name = name;
            return View();
        }
    }
}