using System;
using System.Collections.Generic;

namespace AbstractDP10.Models
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string EmployeeType1 { get; set; }

        public ICollection<Employee> Employee { get; set; }
    }
}
