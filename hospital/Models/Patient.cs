using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class Patient
    {
        public Patient()
        {
            PatientDiseases = new HashSet<PatientDisease>();
        }

        public string Ssn { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public bool? Sex { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string DocSsn { get; set; }
        public string NurseSsn { get; set; }
        public string DeptName { get; set; }
        public int RoomId { get; set; }
        public int? OpeId { get; set; }

        public virtual Department DeptNameNavigation { get; set; }
        public virtual Doctor DocSsnNavigation { get; set; }
        public virtual Nurse NurseSsnNavigation { get; set; }
        public virtual Operation Ope { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<PatientDisease> PatientDiseases { get; set; }
    }
}
