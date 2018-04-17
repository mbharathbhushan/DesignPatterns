using FactoryDP_09.Models;

namespace FactoryDP_09.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;

            if (emp.EmployeeTypeId == 1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            return returnValue;
        }
    }
}
