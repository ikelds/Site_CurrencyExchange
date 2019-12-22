using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Xml;

namespace CurrencyExchange.Models
{
    public class LoadCursCB
    {
        static decimal usdCursCB;
        static decimal eurCursCB;

        // Маржа банка
        static decimal deltaUSD = 1.6M; 
        static decimal deltaEUR = 1.8M;

        // Цены на валюту банка
        public static decimal usdSell;
        public static decimal eurSell;
        public static decimal usdBuy;
        public static decimal eurBuy;


        static NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
        static CultureInfo provider = new CultureInfo("RU-RU");

        public static XmlDocument LoadCurs()
        {
            XmlDocument xDoc = new XmlDocument();

            //xDoc.Load("http://www.cbr.ru/scripts/XML_daily.asp");
            xDoc.Load("C:\\Temp\\XML_daily.asp.odm");

            foreach (XmlElement node in xDoc.SelectNodes("ValCurs"))
            {
                foreach (XmlElement child in node.ChildNodes)
                {
                    if (child.SelectSingleNode("CharCode").InnerText == "USD")
                    {
                        usdCursCB = decimal.Parse(child.SelectSingleNode("Value").InnerText,
                            style, provider);
                    }
                    
                    if (child.SelectSingleNode("CharCode").InnerText == "EUR")
                    {
                        eurCursCB = decimal.Parse(child.SelectSingleNode("Value").InnerText,
                            style, provider);
                    }
                } 
            }

            usdSell = Decimal.Round((usdCursCB + deltaUSD), 2);
            eurSell = Decimal.Round((eurCursCB + deltaEUR), 2); 

            usdBuy = Decimal.Round((usdCursCB - deltaUSD), 2); 
            eurBuy = Decimal.Round((eurCursCB - deltaEUR), 2); 
                     
            return xDoc;
        }
    }
}