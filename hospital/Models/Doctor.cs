using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Operations = new HashSet<Operation>();
            Patients = new HashSet<Patient>();
            Rooms = new HashSet<Room>();
        }

        public string Ssn { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public bool? Sex { get; set; }
        public double? Salary { get; set; }
        public string Adress { get; set; }
        public string Qualifications { get; set; }
        public string PhoneNumber { get; set; }
        public string DeptName { get; set; }

        public virtual Department DeptNameNavigation { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
