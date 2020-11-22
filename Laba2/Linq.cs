using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace Laba2
{
    class Linq : IStrategy
    {
        List<CarSale> info = new List<CarSale>();
        XDocument doc = new XDocument();
        public Linq(string path)
        {
            doc = XDocument.Load(path);
        }
        public List<CarSale> Algorithm(CarSale carSale, string path)
        {
            List<XElement> result = (from val in doc.Descendants("Car")
                                     where
                                     ((carSale.Body == null || carSale.Body == val.Attribute("Body").Value) &&
                                     (carSale.Brand == null || carSale.Brand == val.Attribute("Brand").Value) &&
                                     (carSale.Model == null || carSale.Model == val.Attribute("Model").Value) &&
                                     (carSale.Region == null || carSale.Region == val.Attribute("Region").Value) &&
                                     (carSale.Year == null || isYearRange(val.Attribute("Year").Value, carSale.Year)) &&
                                     (carSale.Price == null || isPriceRange(val.Attribute("Price").Value, carSale.Price)))
                                     select val).ToList();
            foreach (XElement obj in result) 
            {
                CarSale carSale1 = new CarSale();
                carSale1.Body = obj.Attribute("Body").Value;
                carSale1.Brand = obj.Attribute("Brand").Value;
                carSale1.Model = obj.Attribute("Model").Value;
                carSale1.Region = obj.Attribute("Region").Value;
                carSale1.Year = obj.Attribute("Year").Value;
                carSale1.Price = obj.Attribute("Price").Value;
                info.Add(carSale1);
            }
            return info;
        }

        private bool isPriceRange(string val, string param)
        {
            double price = Convert.ToDouble(val);
            if (param == "до 10000" && (price <= 10000))
                return true;

            if (param == "10000-30000" && (price > 10000 && price <= 30000))
                return true;

            if (param == "30000-60000" && (price > 30000 && price <= 60000))
                return true;

            if (param == "60000+" && (price > 60000))
                return true;
            return false;
        }

        private bool isYearRange(string val, string param)
        {
            double year = Convert.ToDouble(val);
            if (param == "до 2010" && year <= 2010)
                return true;

            if (param == "2010-2015" && (year > 2010 && year <= 2015))
                return true;

            if (param == "2015-2020" && year > 2015)
                return true;
            return false;
        }
    }
}
