using AbstractDP10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractDP10.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            IComputerFactory computerFactory = null;

            if (employee.EmployeeTypeId == 1)
            {
                if (employee.JobDescription == "Manager")
                {
                    computerFactory = new MacLaptopFactory();
                }
                else
                {
                    computerFactory = new MacFactory();
                }
            }
            else if (employee.EmployeeTypeId == 2)
            {
                if (employee.JobDescription == "Manager")
                {
                    computerFactory = new DellLaptopFactory();
                }
                else
                {
                    computerFactory = new DellFactory();
                }
            }

            return computerFactory;

        }


    }
}
