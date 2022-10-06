using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class Disease
    {
        public Disease()
        {
            PatientDiseases = new HashSet<PatientDisease>();
        }

        public string Name { get; set; }

        public virtual ICollection<PatientDisease> PatientDiseases { get; set; }
    }
}
