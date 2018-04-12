using FactoryDP_09.Managers;

namespace FactoryDP_09.Factory
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
