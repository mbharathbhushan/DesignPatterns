using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractDP10.Factory.AbstractFactory
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brand.Dell.ToString();
        }
    }
}
