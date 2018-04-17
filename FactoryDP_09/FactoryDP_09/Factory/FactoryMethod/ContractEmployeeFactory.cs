using FactoryDP_09.Managers;
using FactoryDP_09.Models;

namespace FactoryDP_09.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {

        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager contractEmployeeManager = new ContractEmployeeManager();
            _emp.MedicalAllowances = contractEmployeeManager.GetMedicalAllowance();
            return contractEmployeeManager;
        }
    }
}
