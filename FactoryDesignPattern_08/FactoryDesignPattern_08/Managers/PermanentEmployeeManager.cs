using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_08.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;

        }
    }
}
