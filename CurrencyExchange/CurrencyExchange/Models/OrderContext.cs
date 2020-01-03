using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CurrencyExchange.Models
{
    // Контекст данных использует EntityFramework для доступа к БД на основе модели.
    public class OrderContext : DbContext
    {
        public DbSet<ExchangeOptions> OrdersExchange { get; set; }
    }
}