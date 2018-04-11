using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_08.Managers
{
    public interface IEmployeeManager
    {
        decimal GetBonus();
        decimal GetPay();
    }
}
