using FactoryDesignPattern_08.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryDesignPattern_08.Factory
{
    public class EmployeeManagerFactory
    {

        public IEmployeeManager GetEmployeeMangager(int employeeTypeId)
        {
            IEmployeeManager returnValue = null;
            if (employeeTypeId == 1)
            {
                returnValue = new PermanentEmployeeManager();
            }
            else if (employeeTypeId == 2)
            {
                returnValue = new ContractEmployeeManager();
            }

            return returnValue;
        }
    }
}
