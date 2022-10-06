using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class Room
    {
        public Room()
        {
            Patients = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Capacity { get; set; }
        public string DocSsn { get; set; }

        public virtual Doctor DocSsnNavigation { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
