using System;
using System.Collections.Generic;

namespace SingleTon_07_WithCore.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public string Salaray { get; set; }
        public int AddressId { get; set; }
        public string Gender { get; set; }
    }
}
