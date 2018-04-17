using FactoryDP_09.Managers;
using FactoryDP_09.Models;

namespace FactoryDP_09.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory

    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {


        }
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager permanentEmployeeManager = new PermanentEmployeeManager();
            _emp.HouseAllowances = permanentEmployeeManager.GetHouseAllowance();
            return permanentEmployeeManager;
        }


    }
}
