using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class Operation
    {
        public Operation()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Hours { get; set; }
        public string DeptName { get; set; }
        public string DocSsn { get; set; }

        public virtual Department DeptNameNavigation { get; set; }
        public virtual Doctor DocSsnNavigation { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
