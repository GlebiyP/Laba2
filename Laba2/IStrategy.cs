using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    interface IStrategy
    {
        List<CarSale> Algorithm(CarSale cs, string path);  
    }
}
