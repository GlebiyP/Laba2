using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Laba2
{
    class Dom : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public Dom(string path)
        {
            doc.Load(path);
        }
        public List<CarSale> Algorithm(CarSale carSale, string path)
        {
            List<CarSale> res = new List<CarSale>();
            XmlNode node = doc.DocumentElement;
            foreach(XmlNode nod in node.ChildNodes)
            {
                string Body = "";
                string Brand = "";
                string Model = "";
                string Region = "";
                string Year = "";
                string Price = "";

                foreach(XmlAttribute attribute in nod.Attributes)
                {
                    if (attribute.Name.Equals("Body") && (attribute.Value.Equals(carSale.Body) || carSale.Body == null))
                        Body = attribute.Value;

                    if (attribute.Name.Equals("Brand") && (attribute.Value.Equals(carSale.Brand) || carSale.Brand == null))
                        Brand = attribute.Value;

                    if (attribute.Name.Equals("Model") && (attribute.Value.Equals(carSale.Model) || carSale.Model == null))
                        Model = attribute.Value;

                    if (attribute.Name.Equals("Region") && (attribute.Value.Equals(carSale.Region) || carSale.Region == null))
                        Region = attribute.Value;

                    if (attribute.Name.Equals("Year") && (isYearRange(attribute.Value, carSale.Year) || carSale.Year == null))
                        Year = attribute.Value;

                    if (attribute.Name.Equals("Price") && (isPriceRange(attribute.Value, carSale.Price) || carSale.Price == null))
                        Price = attribute.Value;
                }

                if (Body != "" && Brand != "" && Model != "" && Region != "" && Year != "" && Price != "")
                {
                    CarSale carSale1 = new CarSale();
                    carSale1.Body = Body;
                    carSale1.Brand = Brand;
                    carSale1.Model = Model;
                    carSale1.Region = Region;
                    carSale1.Year = Year;
                    carSale1.Price = Price;
                    res.Add(carSale1);
                }
            }
            return res;
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
