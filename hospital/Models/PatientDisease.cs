using System;
using System.Collections.Generic;

#nullable disable

namespace hospital.Models
{
    public partial class PatientDisease
    {
        public string PSsn { get; set; }
        public string DisName { get; set; }

        public virtual Disease DisNameNavigation { get; set; }
        public virtual Patient PSsnNavigation { get; set; }
    }
}
