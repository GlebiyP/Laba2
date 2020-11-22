using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Laba2
{
    class CarSale
    {
        public string Body = null;
        public string Brand = null;
        public string Model = null;
        public string Region = null;
        public string Year = null;
        public string Price = null;
        
        public CarSale() { }

        public CarSale(IStrategy alg)
        {
            Body = String.Empty;
            Brand = String.Empty;
            Model = String.Empty;
            Region = String.Empty;
            Year = String.Empty;
            Price = String.Empty;
        }

        public bool Comparing(CarSale carSale)
        {
            if ((this.Body == carSale.Body) &&
                (this.Brand == carSale.Brand) &&
                (this.Model == carSale.Model) &&
                (this.Region == carSale.Region) &&
                (this.Year == carSale.Year) &&
                (this.Price == carSale.Price))
                return true;
            else return false;
        }

        public IStrategy Alg { get; set; }

        public List<CarSale> Algorithm(CarSale parametrs, string path)
        {
            return Alg.Algorithm(parametrs, path);
        }
    }
}
