﻿using System;
using System.Collections.Generic;

namespace FactoryDP_09.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string Number { get; set; }
        public string Department { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
        public int EmployeeTypeId { get; set; }
        public decimal? HouseAllowances { get; set; }
        public decimal? MedicalAllowances { get; set; }

        public EmployeeType EmployeeType { get; set; }
    }
}
