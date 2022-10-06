using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class Nurse
    {
        public Nurse()
        {
            Patients = new HashSet<Patient>();
        }

        public string Ssn { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public bool? Sex { get; set; }
        public double? Salary { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string DeptName { get; set; }

        public virtual Department DeptNameNavigation { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
