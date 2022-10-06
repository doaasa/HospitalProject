using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class Department
    {
        public Department()
        {
            Doctors = new HashSet<Doctor>();
            Nurses = new HashSet<Nurse>();
            Operations = new HashSet<Operation>();
            Patients = new HashSet<Patient>();
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public string MSsn { get; set; }

        public virtual Manager MSsnNavigation { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Nurse> Nurses { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
