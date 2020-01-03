using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyExchange.Models
{
    // Модель заявки на обмен валюты.
    public class ExchangeOptions
    {
        // ID запроса на обмен валюты.
        public int ID { get; set; }
        public String Operation { get; set; }
        public String Currency { get; set; }
        public Decimal Course { get; set; }
        public Decimal Amount { get; set; }
        public Decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public String Surname { get; set; }
        public String Name { get; set; }
        public String Patronymic { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
    }
}