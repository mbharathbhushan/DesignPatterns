using System;
using System.Collections.Generic;

namespace SingleTon_07_WithCore.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string BuildingName { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string Country { get; set; }
    }
}
