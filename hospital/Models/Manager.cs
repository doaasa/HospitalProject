using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class Manager
    {
        public Manager()
        {
            Departments = new HashSet<Department>();
        }

        public string Ssn { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public bool? Sex { get; set; }
        public double? Salary { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
