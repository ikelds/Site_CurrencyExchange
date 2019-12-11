using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace CurrencyExchange.Models
{
    public class LoadCursCB
    {
                
        public static XmlDocument LoadCurs()
        {
            XmlDocument xDoc = new XmlDocument();

            xDoc.Load("C:\\Temp\\XML_daily.asp.odm");

            return xDoc;
        }
       
    }
}