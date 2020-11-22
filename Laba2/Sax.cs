using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Laba2
{
    class Sax : IStrategy
    {
        public List<CarSale> Algorithm(CarSale carSale, string path)
        {
            List<CarSale> AllResults = new List<CarSale>();
            var xmlReader = new XmlTextReader(path);

            while (xmlReader.Read()) 
            {
                if (xmlReader.HasAttributes) 
                {
                    while (xmlReader.MoveToNextAttribute()) 
                    {
                        string Body = "";
                        string Brand = "";
                        string Model = "";
                        string Region = "";
                        string Year = "";
                        string Price = "";

                        if (xmlReader.Name.Equals("Body") && (xmlReader.Value.Equals(carSale.Body) || carSale.Body == null)) 
                        {
                            Body = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals("Brand") && (xmlReader.Value.Equals(carSale.Brand) || carSale.Brand == null))
                            {
                                Brand = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("Model") && (xmlReader.Value.Equals(carSale.Model) || carSale.Model == null))
                                {
                                    Model = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();

                                    if (xmlReader.Name.Equals("Region") && (xmlReader.Value.Equals(carSale.Region) || carSale.Region == null))
                                    {
                                        Region = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();

                                        if (xmlReader.Name.Equals("Year") && (isYearRange(xmlReader.Value, carSale.Year) || carSale.Year == null))
                                        {
                                            Year = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();

                                            if (xmlReader.Name.Equals("Price") && (isPriceRange(xmlReader.Value, carSale.Price) || carSale.Price == null))
                                            {
                                                Price = xmlReader.Value;
                                            }
                                        }
                                    }
                                }
                            }
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

                            AllResults.Add(carSale1);
                        }
                    }
                }
            }
            xmlReader.Close();
            return AllResults;
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
